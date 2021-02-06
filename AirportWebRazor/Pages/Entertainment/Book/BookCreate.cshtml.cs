using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AirportWebRazor.Pages.Entertainment.Book
{
    public class BookCreateModel : PageModel
    {
        private readonly IEntertainment _entertainment;

        public BookCreateModel(IEntertainment entertainment)
        {
            _entertainment = entertainment;
        }

        public AirPortModel.Models.Entertainment entertainment { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("BookList");
        }

    }
}
