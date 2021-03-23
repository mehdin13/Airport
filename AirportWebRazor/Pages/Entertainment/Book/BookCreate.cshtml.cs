using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AirportWebRazor.Pages.Entertainment.Book
{
    public class BookCreateModel : PageModel
    {
        private readonly IEntertainment _entertainment;
        private readonly IGallery _gallery;
        private readonly ILinks _links;
        private readonly IGalleryImage _Galleryimage;
        public BookCreateModel(IEntertainment entertainment, IGallery gallery, ILinks links, IGalleryImage galleryImage)
        {
            _entertainment = entertainment;
            _gallery = gallery;
            _links = links;
            _Galleryimage = galleryImage;
        }

        [BindProperty]
        public AirPortModel.Models.Entertainment entertainment { get; set; }


        public IActionResult OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["Linkes"] = _links.ToList();
                ViewData["Galleryes"] = _gallery.ToList();
                ViewData["GalleryImages"] = _Galleryimage.ToList();

                return Page();
            }
        }

        public async Task<IActionResult> OnPost(List<IFormFile> images, string Title, string Url, IFormFile Icon, string Description)
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                try
                {
                    AirPortModel.Models.Links linksobj = new AirPortModel.Models.Links();
                    linksobj.CategoryId = 16;
                    entertainment.Type = 1;

                    if (Title != null && Url != null && Icon != null && Description != null)
                    {
                        if (Icon.Length > 0 && Icon.ContentType != null)
                        {
                            var path = Path.Combine("images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(Icon.FileName)));
                            using (var stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\", path), FileMode.Create))
                            {
                                Icon.CopyTo(stream);
                                linksobj.Icon = string.Format("{0}{1}", "\\", path);
                            }
                        }
                        else
                        {
                            return Page();
                        }
                        linksobj.Title = Title;
                        linksobj.Url = Url;
                        linksobj.Description = Description;
                        var addLinkid = _links.Insert(linksobj);
                        if (addLinkid != 0)
                        {
                            entertainment.LId = addLinkid;
                        }
                        else
                        {
                            return Page();
                        }
                    }
                    AirPortModel.Models.Gallery galleryobg = new AirPortModel.Models.Gallery();
                    AirPortModel.Models.GalleryImage galleryImageObj = new AirPortModel.Models.GalleryImage();
                    galleryobg.Name = string.Format("{0}{1}", entertainment.Name, Guid.NewGuid().ToString().Replace("_", ""));
                    int gid = _gallery.Insert(galleryobg);
                    if (gid != 0)
                    {
                        entertainment.Galleryid = gid;
                        long size = images.Sum(f => f.Length);
                        foreach (var fileimage in images)
                        {
                            if (fileimage.Length > 0 && fileimage.ContentType != null)
                            {
                                var path = Path.Combine("images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(fileimage.FileName)));
                                using (var stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\", path), FileMode.Create))
                                {
                                    fileimage.CopyTo(stream);
                                    galleryImageObj.Url = string.Format("{0}{1}", "\\", path);
                                    galleryImageObj.GalleryId = gid;
                                    int img = _Galleryimage.Insert(galleryImageObj);
                                }
                            }
                            else
                            {
                                return Page();
                            }

                        }
                        if (_entertainment.Insert(entertainment) != 0)
                        {
                            return Redirect("index");
                        }
                        else
                        {
                            return Page();
                        }
                    }
                }
                catch (Exception ex)
                {
                    _ = ex.Message;
                    return Page();
                }
                return RedirectToPage("BookList");
            }
        }
    }
}
