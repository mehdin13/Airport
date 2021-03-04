using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.AirPlane
{
    public class IndexModel : PageModel
    {
        private readonly IAirPlane _airplane;

        public IndexModel(IAirPlane airPlane)
        {
            _airplane = airPlane;
        }

        [BindProperty]
        public List<AirPortModel.Models.AirPlane> airPlanes { get; set; }

        public async Task<IActionResult> OnGet()
        {
            airPlanes = _airplane.ToList();
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            _airplane.Delete(id);
            return RedirectToPage("index");
        }
    }
}
