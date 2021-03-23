using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Terminal
{
    public class IndexModel : PageModel
    {
        private readonly ITerminal _terminal;
        private readonly IAirPort _airport;

        public IndexModel(ITerminal terminal , IAirPort airPort)
        {
            _terminal = terminal;
            _airport = airPort;
        }

        [BindProperty]
        public List<AirPortModel.Models.Terminal> TerminalsObj { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["Airport"] = _airport.Tolist();
                TerminalsObj = _terminal.ToList();
                return Page();
            }
        }
        public async Task<IActionResult> OnPost(int id)
        {
            _terminal.Delete(id);
            return RedirectToPage("Index");
        }
    }
}
