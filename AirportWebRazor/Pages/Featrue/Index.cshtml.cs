using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Featrue
{
    public class IndexModel : PageModel
    {
        private readonly IFeatrue _featrue;

        public IndexModel(IFeatrue featrue)
        {
            _featrue = featrue;
        }

        public List<AirPortModel.Models.Featrue> featrues { get; set; }


        public async Task<IActionResult> OnGet()
        {
            featrues = _featrue.ToList();
            return Page();
        }
        public async Task<IActionResult> OnPost(int id)
        {
            _featrue.Delete(id);
            return RedirectToPage("index");
        }
    }
}
