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
    public class CreateModel : PageModel
    {
        private readonly IState _state;

        public CreateModel(IState state)
        {
            _state = state;
        }
        [BindProperty]
        public AirPortModel.Models.State state1 { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
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
                        _state.Insert(state1);
                        return Redirect("index");
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
}
