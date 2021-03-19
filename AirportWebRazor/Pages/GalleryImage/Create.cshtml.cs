using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace AirportWebRazor.Pages.GalleryImage
{
    public class CreateModel : PageModel
    {
        private readonly IGalleryImage _galleryImage;
        private readonly IGallery _gallery;

        public CreateModel(IGalleryImage galleryImage, IGallery gallery)
        {
            _galleryImage = galleryImage;
            _gallery = gallery;
        }
        [BindProperty]
        public AirPortModel.Models.GalleryImage galleryImage1 { get; set; }

        public async Task<IActionResult> OnGet(int ids)
        {
            ViewData["GalleryImagesid"] = ids;
            ViewData["GalleryImages"] = _gallery.ToList();
            return Page();
        }
        public async Task<IActionResult> OnPost(IFormFile fileimage)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (fileimage.Length > 0 && fileimage.ContentType != null)
                    {
                        var path = Path.Combine("images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(fileimage.FileName)));
                        using (var stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\", path), FileMode.Create))
                        {
                            fileimage.CopyTo(stream);
                            galleryImage1.Url = string.Format("{0}{1}", "\\", path);
                            int img = _galleryImage.Insert(galleryImage1);
                        }
                        string address = string.Format("index?id={0}", galleryImage1.GalleryId);
                        return Redirect(address);
                    }
                    else
                    {
                        return Page();
                    }
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
