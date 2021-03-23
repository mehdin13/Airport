using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.AirLine
{
    public class IndexModel : PageModel
    {
        private readonly IAirline _airline;

        public IndexModel(IAirline airline)
        {
            _airline = airline;
        }
        [BindProperty]
        public List<AirPortModel.Models.Airline> airlines { get; set; }
        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                airlines = _airline.ToList();
                return Page();
            }
        }
        public async Task<IActionResult> OnPost(int id)
        {
            try
            {
                _airline.Delete(id);
                return RedirectToPage("index");
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return Page();
            }
        }
    }
}
