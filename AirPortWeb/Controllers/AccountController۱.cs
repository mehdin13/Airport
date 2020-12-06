using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirPortWeb.Models;
using AirPortModel.Models;
using AirPortDataLayer.Crud;
using AirPortDataLayer.Crud.InterFace;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.IO;

namespace AirPortWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUser _user;
        public AccountController(IUser user)
        {
            _user = user;
        }
        [HttpGet]
        public IActionResult login()
        {
            return View(LoginVeiwModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult login(LoginVeiwModel loginVeiwModel)
        {
            if (_user.CheckLoginInfo(loginVeiwModel.Username, loginVeiwModel.Password).Number.Equals(1))
            {
                var userobj = _user.FindByUserName(loginVeiwModel.Username);
                if (userobj.IsActive)
                {
                    var claims = new List<Claim>()
                    {
                       new Claim(ClaimTypes.NameIdentifier.ToString(),userobj.Id.ToString()),
                     new Claim(ClaimTypes.Name,userobj.Name)
                    };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = loginVeiwModel.RememberMe
                    };
                    HttpContext.SignInAsync(principal, properties);

                    return Redirect("/admin");
                }
                else
                {
                    ModelState.AddModelError("PhoneNumber", "حساب کاربری شما فعال نمی باشد");
                }
            }
            return View(loginVeiwModel);
        }
    }
}
