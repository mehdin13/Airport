using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;


namespace AirportWebRazor.Pages.AirPort
{
    public class CreateModel : PageModel
    {
        private readonly IAirPort _airport;

        public CreateModel(IAirPort airPort)
        {
            _airport = airPort;
        }

        public AirPortModel.Models.AirPort airPort1 { get; set; }

        public async Task<IActionResult> OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                else
                {
                    //codes


                    //end code
                    return RedirectToPage("index");
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
