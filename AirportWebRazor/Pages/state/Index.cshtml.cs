using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.state
{
    public class IndexModel : PageModel
    {

        private readonly IState _state;

        public IndexModel(IState state)
        {
            _state = state;
        }
        [BindProperty]
        public List<AirPortModel.Models.State> states { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                states = _state.ToList();
                return Page();
            }
        }
        public async Task<IActionResult> OnPost(int id)
        {
            _state.Delete(id);
            return RedirectToPage("index");
        }
    }
}
