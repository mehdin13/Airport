using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AirportWebRazor.Pages.AirLine
{
    public class EditModel : PageModel
    {

        private readonly IAirline _airline;
        private readonly IDetailValue _detailValue;
        private readonly IFeatrue _featrue;
        private readonly IDetail _detail;

        public EditModel(IAirline airline, IDetailValue detailValue, IFeatrue featrue, IDetail detail)
        {
            _detail = detail;
            _featrue = featrue;
            _airline = airline;
            _detailValue = detailValue;
        }

        [BindProperty]
        public AirPortModel.Models.Airline airlines { get; set; }


        public async Task<IActionResult> OnGet(int id)
        {
            airlines = _airline.FindById(id);
            ViewData["detailValue"] = _detailValue.FindByDetailId(airlines.DetailId);
            ViewData["featruelist"] = _featrue.ToListbyid(_detail.FindById(_airline.FindById(id).DetailId).TypeId);

            return Page();
        }

        public async Task<IActionResult> OnPost(int[] dfid,int[] id2, string[] value, IFormFile images)
        {
            try
            {
                //Logo
                if (images != null)
                {
                    if (images.Length > 0 && images.ContentType != null)
                    {
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(images.FileName)));
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            images.CopyTo(stream);
                            airlines.Logo = filePath;
                        }
                    }
                    else
                    {
                        return Page();
                    }
                }
                //detail Value
                AirPortModel.Models.DetailValue de = new AirPortModel.Models.DetailValue();
                for (int i = 0; i <= id2.Count() - 1; i++)
                {
                    de = _detailValue.FindById(dfid[i]);
                    de.DetailId = airlines.DetailId;
                    de.FeacherId = id2[i];
                    de.Value = value[i];
                    if (_detailValue.Update(de).Number.Equals(0))
                    {
                        return Redirect("index");
                    }
                }
                if (_airline.Update(airlines).Number.Equals(0))
                {
                    return Redirect("index");
                }
                else
                {
                    return Redirect("index");
                }
            }
            catch (Exception ex)
            {
                string massage = ex.Message;
                return Redirect("index");
            }
        }
    }
}

