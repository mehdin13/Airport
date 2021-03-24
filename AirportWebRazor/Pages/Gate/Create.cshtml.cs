using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.Gate
{
    
    public class CreateModel : PageModel
    {
        private readonly IGate _gate;
        private readonly ITerminal _terminal;


        public CreateModel(IGate gate , ITerminal terminal)
        {
            _gate = gate;
            _terminal = terminal;
        }

        [BindProperty]
        public AirPortModel.Models.Gate gateobj { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["Terminal"] = _terminal.ToList();

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
                        return Page();
                    }
                    else
                    {
                        _gate.Insert(gateobj);
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
