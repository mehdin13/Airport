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
            ViewData["Airport"] = _airport.Tolist();
            return Page();
        }
        public async Task<IActionResult> OnPost(int id)
        {
            _terminal.Delete(id);
            return RedirectToPage("Index");
        }
    }
}
