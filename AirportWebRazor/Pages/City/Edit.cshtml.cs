using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.City
{
    public class EditModel : PageModel
    {
        private readonly ICity _city;
        private readonly IState _stat;

        public EditModel(ICity city, IState state)
        {
            _city = city;
            _stat = state;
        }

        [BindProperty]
        public AirPortModel.Models.City cityObj { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            cityObj = _city.FindById(id);
            ViewData["States"] = _stat.ToList();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (_city.Update(cityObj).Number.Equals(1))
                {
                    return Redirect("index");
                }
                else
                {
                    return Page();
                    
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
