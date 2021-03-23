using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AirportWebRazor.Pages.Category
{
    public class IndexModel : PageModel
    {

        private readonly ICategory _category;

        public IndexModel(ICategory category)
        {
            _category = category;
        }

        public List<AirPortModel.Models.Category> categories { get; set; }

        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                categories = _category.ToList();
                return Page();
            }
        }
    }
}
