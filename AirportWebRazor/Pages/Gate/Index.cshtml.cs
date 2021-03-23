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
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                GateObj = _gate.ToList();
                ViewData["Terminales"] = _terminal.ToList();
                return Page();
            }
        }

        public async Task<IActionResult> OnPost(int id)
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
                    _gate.Delete(id);
                    return Page();
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
