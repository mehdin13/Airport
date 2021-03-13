using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AirportWebRazor.Pages.Entertainment.Magazain
{
    public class EditModel : PageModel
    {
        private readonly IEntertainment _entertaiment;
        private readonly IGallery _gallery;
        private readonly ILinks _links;
        private readonly IGalleryImage _Galleryimage;

        public EditModel(IEntertainment entertainment, IGallery gallery, ILinks links, IGalleryImage galleryImage)
        {
            _entertaiment = entertainment;
            _gallery = gallery;
            _links = links;
            _Galleryimage = galleryImage;
        }

        [BindProperty]
        public AirPortModel.Models.Entertainment entertainment { get; set; }

        public IActionResult OnGet(int id)
        {
            entertainment = _entertaiment.FindById(id);
            ViewData["Linkes"] = _links.FindById(id);


            return Page();
        }


        public async Task<IActionResult> OnPost(string Title, string Url, string Icon, string Description)
        {
            try
            {

                //*********************Link
                AirPortModel.Models.Links linksobj = new AirPortModel.Models.Links();
                entertainment.Type = 3;
                if (Title != null && Url != null && Icon != null && Description != null)
                {
                    linksobj.Title = Title;
                    linksobj.Url = Url;
                    linksobj.Icon = Icon;
                    linksobj.Description = Description;
                    linksobj.CategoryId = 18;
                    var addLinkid = _links.Update(linksobj);
                    if (addLinkid.Number.Equals(1))
                    {
                        entertainment.LId = linksobj.Id;
                    }
                    else
                    {
                        return Page();
                    }
                }
                //********************** End Link******************

                if (_entertaiment.Update(entertainment).Number.Equals(1))
                {
                    return RedirectToPage("index");
                }
                else
                {
                    return Redirect("index");
                }


            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return Page();
            }
        }
    }
}
