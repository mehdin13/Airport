using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.City
{
    public class CreateModel : PageModel
    {
        private readonly ICity _city;
        private readonly IState _state;

        public CreateModel(ICity city, IState state)
        {
            _city = city;
            _state = state;
        }

        [BindProperty]
        public AirPortModel.Models.City city1 { get; set; }
        

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["states"] = _state.ToList();
                return Page();
            }
        }

        public async Task<IActionResult> OnPost()
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
                    if (!ModelState.IsValid)
                    {

                        ViewData["states"] = _state.ToList();
                        return Page();
                    }
                    else
                    {
                        _city.insert(city1);
                        return Redirect("index");
                    }
                }
                catch (Exception ex)
                {
                    _ = ex.Message;
                    return Page();
                }
            }
        }
    }
}
