using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;


namespace AirportWebRazor.Pages.AirPort
{
    public class IndexModel : PageModel
    {
        private readonly IAirPort _airport;

        public IndexModel(IAirPort airPort)
        {
            _airport = airPort;
        }

        public List<AirPortModel.Models.AirPort> airPorts { get; set; }


        public async Task<IActionResult> OnGet()
        {
            airPorts = _airport.Tolist();
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            _airport.Delete(id);
            return RedirectToPage("index");
        }
    }
}
