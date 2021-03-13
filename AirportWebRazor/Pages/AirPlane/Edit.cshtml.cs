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
    public class EditModel : PageModel
    {
        private readonly IAirPlane _airplane;
        private readonly IBrand _Brand;
        private readonly IAirline _airline;
        private readonly IDetail _detail;
        private readonly IFeatrue _featrue;
        private readonly IDetailValue _detailValue;
        private readonly IGallery _gallery;
        private readonly IGalleryImage _galleryImage;
        public EditModel(IAirPlane airPlane, IBrand brand, IAirline airline, IDetail detail, IFeatrue featrue, IDetailValue detailValue, IGallery gallery, IGalleryImage galleryImage)
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


        public async Task<IActionResult> OnGet(int id)
        {
            airPlaneobj = _airplane.FindById(id);

            ViewData["Brandes"] = _Brand.ToList();
            ViewData["AirLine"] = _airline.FindById(id);
            ViewData["featruelist"] = _featrue.ToListbyid(7);
            return Page();
        }
        public async Task<IActionResult> OnPost(int[] dfid, int[] id, string[] value, List<IFormFile> images)
        {
            try
            {
                AirPortModel.Models.DetailValue de = new AirPortModel.Models.DetailValue();
                for (int i = 0; i <= id.Count() - 1; i++)
                {
                    de = _detailValue.FindById(dfid[i]);
                    de.DetailId = airPlaneobj.DetailId;
                    de.FeacherId = id[i];
                    de.Value = value[i];
                    if (_detailValue.Update(de).Number.Equals(0))
                    {
                        return Redirect("index");
                    }
                }
                if (_airplane.Update(airPlaneobj).Number.Equals(0))
                {
                    return Redirect("index");
                }
                else
                {
                    return RedirectToPage("index");
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return Redirect("index");
            }
        }
    }
}