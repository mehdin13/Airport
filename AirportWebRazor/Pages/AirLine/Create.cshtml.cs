using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
namespace AirportWebRazor.Pages.AirLine
{
    public class CreateModel : PageModel
    {
        private readonly IAirline _airline;
        private readonly IDetailValue _detailValue;
        private readonly IFeatrue _featrue;
        private readonly IDetail _detail;

        public CreateModel(IAirline airline, IDetailValue detailValue, IFeatrue featrue, IDetail detail)
        {
            _detail = detail;
            _featrue = featrue;
            _airline = airline;
            _detailValue = detailValue;
        }
        [BindProperty]
        public AirPortModel.Models.Airline airlines { get; set; }


        public async Task<IActionResult> OnGet()
        {
            ViewData["featruelist"] = _featrue.ToListbyid(5);
            return Page();
        }
        public async Task<IActionResult> Onpost(int[] id, string[] value)
        {
            try
            {
                AirPortModel.Models.Detail detailobj = new AirPortModel.Models.Detail();
                detailobj.TypeId = 5;
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
                    airlines.Detail = detailobj;
                    if (_airline.Insert(airlines) == 0)
                    {
                        return Redirect("index");
                    }
                    else
                    {
                        return Redirect("index");
                    }

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