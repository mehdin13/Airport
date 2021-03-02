using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;


namespace AirportWebRazor.Pages.Advertizment
{
    public class IndexModel : PageModel
    {
        private readonly IAdvertizment _advertizment;

        public IndexModel(IAdvertizment advertizment)
        {
            _advertizment = advertizment;
        }

        public List<AirPortModel.Models.Advertizment> advertizments { get; set; }

        public async Task<IActionResult> OnGet()
        {
            advertizments = _advertizment.ToList();
            return Page();
        }

        public async Task<IActionResult> OnPost(int id)
        {
            try
            {
                if (_advertizment.Delete(id).Number.Equals(1))
                {
                    return Page();
                }
                
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
