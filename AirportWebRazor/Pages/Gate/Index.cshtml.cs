using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Gate
{
    public class IndexModel : PageModel
    {
        private readonly IGate _gate;
        private readonly ITerminal _terminal;

        public IndexModel(IGate gate, ITerminal terminal)
        {
            _gate = gate;
            _terminal = terminal;
        }

        [BindProperty]
        public List<AirPortModel.Models.Gate> GateObj { get; set; }

        public async Task<IActionResult> OnGet()
        {
            ViewData["Terminales"] = _terminal.ToList();
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            try
            {
                _gate.Delete(id);
                return Page();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return Page();
            }
        }

    }
}
