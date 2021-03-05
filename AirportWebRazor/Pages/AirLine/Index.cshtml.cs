using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

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
            airlines = _airline.ToList();
            return Page();
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