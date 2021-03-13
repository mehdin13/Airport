using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;

namespace AirportWebRazor.Pages.Tutorial
{
    public class EditModel : PageModel
    {

        private readonly ILinks _link;
        private readonly ICategory _category;

        public EditModel(ILinks links, ICategory category)
        {
            _link = links;
            _category = category;
        }

        [BindProperty]
        public AirPortModel.Models.Links linkesobj { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            linkesobj = _link.FindById(id);
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                linkesobj.CategoryId = 13;
                if (_link.Update(linkesobj).Number.Equals(1))
                {
                    return RedirectToPage("Index");
                }
                else
                {
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
