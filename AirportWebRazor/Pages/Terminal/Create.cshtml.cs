using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AirportWebRazor.Pages.Terminal
{
    public class CreateModel : PageModel
    {
        private readonly ITerminal _terminal;
        private readonly IAirPort _airport;

        public CreateModel(ITerminal terminal, IAirPort airPort)
        {
            _terminal = terminal;
            _airport = airPort;
        }

        [BindProperty]
        public AirPortModel.Models.Terminal terminals { get; set; }


        public async Task<IActionResult> OnGet()
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                ViewData["airportes"] = _airport.Tolist();
                string err = "";
                ViewData["err"] = err;
                return Page();
            }
        }


        public async Task<IActionResult> OnPost(IFormFile images)
        {
            string name = HttpContext.Session.GetString("admin");
            if (name != "jimbo.23@23")
            {
                return Redirect("~/accunt/login");
            }
            else
            {
                string err = "";
                try
                {
                    if (images != null && images.Length > 0 && images.ContentType != null)
                    {
                        var path = Path.Combine("images", string.Format("{0}{1}", Guid.NewGuid().ToString().Replace("_", ""), Path.GetExtension(images.FileName)));
                        using (var stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\", path), FileMode.Create))
                        {
                            images.CopyTo(stream);
                            terminals.Image = string.Format("{0}{1}", "\\", path);
                        }
                    }
                    else
                    {
                        err = "آپلود عکس با مشکل مواجه شد لطفا مقادیر را کنترل کنید";
                        ViewData["err"] = err;
                        return Page();
                    }
                    if (_terminal.Insert(terminals) == 0)
                    {
                        return Redirect("index");
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
}
