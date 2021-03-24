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
    public class EditModel : PageModel
    {
        private readonly IState _state;

        public EditModel(IState state)
        {
            _state = state;
        }

        [BindProperty]
        public AirPortModel.Models.State StateObj { get; set; }

        public IActionResult OnGet(int id)
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                StateObj = _state.FindById(id);
                return Page();
            }
        }

        public IActionResult OnPost()
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
                    if (_state.Update(StateObj).Number.Equals(1))
                    {
                        return RedirectToPage("index");
                    }
                    else
                    {
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
}
