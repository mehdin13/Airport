using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AirportWebRazor.Pages.Services.Animal
{
    public class CreateModel : PageModel
    {
        private readonly IPlace _place;
        private readonly IAddress _address;
        private readonly ICategory _category;
        private readonly IGallery _gallery;
        private readonly IGalleryImage _galleryImage;
        private readonly IDetail _detail;
        private readonly IFeatrue _featrue;
        private readonly IDetailValue _detailValue;
        private readonly ICity _city;
        private readonly IState _state;
        private readonly ICustomer _customer;
        private readonly IAirPort _airport;

        public CreateModel(IPlace place, IAddress address, ICategory category, IGallery gallery, IGalleryImage galleryImage, IDetail detail, IFeatrue featrue, IDetailValue detailValue, ICity city, IState state, IAirPort airPort, ICustomer customer)
        {
            _place = place;
            _address = address;
            _category = category;
            _gallery = gallery;
            _galleryImage = galleryImage;
            _detail = detail;
            _featrue = featrue;
            _detailValue = detailValue;
            _state = state;
            _city = city;
            _airport = airPort;
            _customer = customer;
        }

        [BindProperty]
        public AirPortModel.Models.Place placeobj { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["Addresses"] = _address.ToList();
                ViewData["Statees"] = _state.ToList();
                ViewData["Cityes"] = _city.ToList();
                ViewData["Feathrue"] = _featrue.ToListbyid(21);
                ViewData["Airport"] = _airport.Tolist();
                ViewData["Customer"] = _customer.ToList();

                return Page();
            }
        }

        public async Task<IActionResult> OnPost(int[] id, string[] value, List<IFormFile> images, string Detail, string LocationX, string LocationY, string LocationR, int CityId)
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                try
                {
                    //insert into address
                    AirPortModel.Models.Address addressObj = new AirPortModel.Models.Address();
                    if (Detail != null && LocationX != null && LocationY != null && LocationR != null && CityId != null)
                    {
                        addressObj.LocationR = LocationR;
                        addressObj.LocationX = LocationX;
                        addressObj.LocationY = LocationY;
                        addressObj.Detail = Detail;
                        addressObj.CityId = CityId;
                        var adid = _address.Insert(addressObj);
                        if (adid != 0)
                        {
                            placeobj.AdressId = adid;
                        }
                        else
                        {
                            return Page();
                        }
                    }
                    //insert to Gallery and GalleryImages
                    placeobj.CategoryId = 8;
                    AirPortModel.Models.Detail detailobj = new AirPortModel.Models.Detail();
                    AirPortModel.Models.Gallery galleryobg = new AirPortModel.Models.Gallery();
                    AirPortModel.Models.GalleryImage galleryImageObj = new AirPortModel.Models.GalleryImage();


                    galleryobg.Name = string.Format("{0}", placeobj.Name);
                    int gid = _gallery.Insert(galleryobg);
                    if (gid != 0)
                    {
                        placeobj.GalleryId = gid;
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
                        //Insert detail
                        detailobj.TypeId = 21;

                        int deid = _detail.Insert(detailobj);
                        if (deid == 0)
                        {
                            return Redirect("index");
                        }
                        else
                        {
                            AirPortModel.Models.DetailValue de = new AirPortModel.Models.DetailValue();
                            for (int i = 0; i <= id.Count() - 1; i++)
                            {
                                de.DetailId = deid;
                                de.FeacherId = id[i];
                                de.Value = value[i];
                                if (_detailValue.Insert(de) == 0)
                                {
                                    return Redirect("index");
                                }
                            }
                            //insert into place:D
                            placeobj.DetailId = deid;
                            if (_place.Insert(placeobj) == 0)
                            {
                                return Redirect("index");
                            }
                            else
                            {
                                return Redirect("index");
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    _ = ex.Message;
                    return Page();
                }
                return Redirect("index");
            }
        }

    }
}

