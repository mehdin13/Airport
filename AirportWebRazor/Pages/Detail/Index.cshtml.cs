using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;


namespace AirportWebRazor.Pages.Detail
{
    public class IndexModel : PageModel
    {

        private readonly IDetail _detail;

        public IndexModel(IDetail detail)
        {
            _detail = detail;
        }
        [BindProperty]
        public List<AirPortModel.Models.Detail> details { get; set; }
        public AirPortModel.Models.Detail detail1 { get; set; }

        public async Task<IActionResult> OnGet()
        {
            details = _detail.ToList();
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            try
            {
                
                _detail.Delete(id);
                return RedirectToPage("index");
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return Page();
            }
        }
    }
}
