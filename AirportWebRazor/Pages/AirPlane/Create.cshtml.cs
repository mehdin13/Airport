using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AirportWebRazor.Pages.AirPlane
{
    public class CreateModel : PageModel
    {
        private readonly IAirPlane _airplane;
        private readonly IBrand _Brand;
        private readonly IAirline _airline;
        private readonly IDetail _detail;
        private readonly IFeatrue _featrue;
        private readonly IDetailValue _detailValue;
        private readonly IGallery _gallery;
        private readonly IGalleryImage _galleryImage;
        public CreateModel(IAirPlane airPlane, IBrand brand, IAirline airline, IDetail detail, IFeatrue featrue, IDetailValue detailValue, IGallery gallery, IGalleryImage galleryImage)
        {
            _gallery = gallery;
            _galleryImage = galleryImage;
            _airplane = airPlane;
            _Brand = brand;
            _airline = airline;
            _detail = detail;
            _featrue = featrue;
            _detailValue = detailValue;
        }

        [BindProperty]
        public AirPortModel.Models.AirPlane airPlaneobj { get; set; }

        public async Task<IActionResult> OnGet()
        {
            ViewData["Brandes"] = _Brand.ToList();
            ViewData["AirLine"] = _airline.ToList();
            ViewData["featruelist"] = _featrue.ToListbyid(7);
            return Page();
        }

        public async Task<IActionResult> OnPost(int[] id, string[] value, List<IFormFile> images)
        {
            try
            {
                AirPortModel.Models.Detail detailobj = new AirPortModel.Models.Detail();
                AirPortModel.Models.Gallery galleryobg = new AirPortModel.Models.Gallery();
                AirPortModel.Models.GalleryImage galleryImageObj = new AirPortModel.Models.GalleryImage();
                galleryobg.Name = string.Format("{0}{2}{1}", airPlaneobj.Name, _airline.FindById(airPlaneobj.AirlineId).Name, _Brand.FindById(airPlaneobj.BrandId).BrandName);
                int gid = _gallery.Insert(galleryobg);
                if (gid != 0)
                {
                    airPlaneobj.GalleryId = gid;
                    long size = images.Sum(f => f.Length);
                    foreach (var fileimage in images)
                    {
                        if (fileimage.Length > 0 && fileimage.ContentType != null)
                        {
                            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(fileimage.FileName)));
                            using (var stream = new System.IO.FileStream(filePath, FileMode.Create))
                            {
                                fileimage.CopyTo(stream);
                                galleryImageObj.Url = filePath;
                                galleryImageObj.GalleryId = gid;
                                int img = _galleryImage.Insert(galleryImageObj);
                            }
                        }
                        else
                        {
                            return Page();
                        }
                    }
                    detailobj.TypeId = 7;
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
                                airPlaneobj.DetailId = deid;
                            }
                            else
                            {
                                return Page();
                            }
                        }
                        if (_airplane.Insert(airPlaneobj) != 0)
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
