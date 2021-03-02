using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;


namespace AirportWebRazor.Pages.Featrue
{
    public class CreateModel : PageModel
    {
        private readonly IFeatrue _featrue;
        private readonly ITypeDetail _typeDetail;
        public CreateModel(IFeatrue featrue , ITypeDetail typeDetail)
        {
            _featrue = featrue;
            _typeDetail = typeDetail;
        }
        [BindProperty]
        public AirPortModel.Models.Featrue featrue1 { get; set; }

        public async Task<IActionResult> OnGet()
        {
            ViewData["detail"] = _typeDetail.ToList();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                else
                {
                    _featrue.Insert(featrue1);
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
