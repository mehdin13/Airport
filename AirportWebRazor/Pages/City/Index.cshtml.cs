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
    public class IndexModel : PageModel
    {
        private readonly ICity _city;
        private readonly IState _state;

        public IndexModel(ICity city,IState state)
        {
            _city = city;
            _state = state;
        }

        [BindProperty]
        public List<AirPortModel.Models.City> cities { get; set; }
        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["State"] = _state.ToList();
                cities = _city.ToList();
                return Page();
            }
        }
        public async Task<IActionResult> OnPost(int id)
        {
            _city.Delete(id);
            return RedirectToPage("Index");
        }
    }
}
