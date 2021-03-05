using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;


namespace AirportWebRazor.Pages.DitailValue
{
    public class IndexModel : PageModel
    {
        private readonly IDetailValue _detailValue;

        public IndexModel(IDetailValue detailValue)
        {
            _detailValue = detailValue;
        }

        public List<AirPortModel.Models.DetailValue> detailValues { get; set; }


        public async Task<IActionResult> OnGet()
        {
            detailValues = _detailValue.ToList();
            return Page();
        }
    }
}