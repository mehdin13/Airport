using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AirportWebRazor.Pages.AirPort
{
    public class CreateModel : PageModel
    {
        private readonly IAirPort _airPort;

        private readonly IDetail _detail;
        private readonly IFeatrue _featrue;
        private readonly IDetailValue _detailValue;
        private readonly IGallery _gallery;
        private readonly IGalleryImage _galleryImage;
        private readonly IAddress _address;
        private readonly ICity _city;
        private readonly IState _state;

        public CreateModel(IAirPort airPort, IBrand brand, IDetail detail, IFeatrue featrue, IDetailValue detailValue, IGallery gallery, IGalleryImage galleryImage, IAddress address, ICity city, IState state)
        {
            _airPort = airPort;
            _gallery = gallery;
            _galleryImage = galleryImage;
            _detail = detail;
            _featrue = featrue;
            _detailValue = detailValue;
            _address = address;
            _city = city;
            _state = state;
        }

        [BindProperty]
        public AirPortModel.Models.AirPort airportobj { get; set; }

        public async Task<IActionResult> OnGet()
        {
            ViewData["state"] = _state.ToList();
            ViewData["city"] = _city.ToList();
            ViewData["featruelist"] = _featrue.ToListbyid(6);
            return Page();
        }

        public async Task<IActionResult> OnPost(int[] id, string[] value, List<IFormFile> images, IFormFile mapimage, string AdressDetail, string AdressLocationX, string AdressLocationY, string AdressLocationR, int AdressCityId)
        {
            ViewData["state"] = _state.ToList();
            ViewData["city"] = _city.ToList();
            ViewData["featruelist"] = _featrue.ToListbyid(6);
            try
            {
                AirPortModel.Models.Address addressObj = new AirPortModel.Models.Address();
                if (AdressDetail != null && AdressLocationX != null && AdressLocationY != null && AdressLocationR != null && AdressCityId != null)
                {
                    addressObj.LocationR = AdressLocationR;
                    addressObj.LocationX = AdressLocationX;
                    addressObj.LocationY = AdressLocationY;
                    addressObj.Detail = AdressDetail;
                    addressObj.CityId = AdressCityId;
                    var adid = _address.Insert(addressObj);
                    if (adid != 0)
                    {
                        airportobj.AirPortAddressId = adid;
                    }
                    else
                    {
                        return Page();
                    }
                }
                AirPortModel.Models.Detail detailobj = new AirPortModel.Models.Detail();
                AirPortModel.Models.Gallery galleryobg = new AirPortModel.Models.Gallery();
                AirPortModel.Models.GalleryImage galleryImageObj = new AirPortModel.Models.GalleryImage();
                galleryobg.Name = string.Format("{0}", Guid.NewGuid().ToString().Replace("_", ""));
                int gid = _gallery.Insert(galleryobg);
                if (gid != 0)
                {
                    airportobj.GalleryId = gid;
                    long size = images.Sum(f => f.Length);
                    foreach (var fileimage in images)
                    {
                        if (fileimage.Length > 0 && fileimage.ContentType != null)
                        {
                            var path = Path.Combine("images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(fileimage.FileName)));
                            using (var stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\", path), FileMode.Create))
                            {
                                fileimage.CopyTo(stream);
                                galleryImageObj.Url = string.Format("{0}{1}", "\\", path);
                                galleryImageObj.GalleryId = gid;
                                int img = _galleryImage.Insert(galleryImageObj);
                            }
                        }
                        else
                        {
                            return Page();
                        }
                    }
                    if (mapimage.Length > 0 && mapimage.ContentType != null)
                    {
                        var path = Path.Combine("images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(mapimage.FileName)));
                        using (var stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\", path), FileMode.Create))
                        {
                            mapimage.CopyTo(stream);
                            airportobj.Url = string.Format("{0}{1}", "\\", path);
                        }
                    }
                    else
                    {
                        return Page();
                    }
                    detailobj.TypeId = 6;
                    int deid = _detail.Insert(detailobj);
                    if (deid != 0)
                    {
                        AirPortModel.Models.DetailValue de = new AirPortModel.Models.DetailValue();
                        for (int i = 0; i <= id.Count() - 1; i++)
                        {
                            de.DetailId = deid;
                            de.FeacherId = id[i];
                            de.Value = value[i];
                            if (_detailValue.Insert(de) != 0)
                            {
                                airportobj.Detailid = deid;
                            }
                            else
                            {
                                return Page();
                            }
                        }
                        if (_airPort.Insert(airportobj) != 0)
                        {
                            return Redirect("index");
                        }
                        else
                        {
                            return Redirect("index");
                        }
                    }
                    else
                    {
                        return Page();
                    }
                }
                else
                {
                    return Page();
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return Page();
            }
        }

    }
}
