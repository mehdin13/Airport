using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using AirportWebRazor.Model.ViewMode;

namespace AirportWebRazor.Pages.Accunt
{
    public class LoginModel : PageModel
    {
        private readonly IUser _User;
        public LoginModel(IUser user)
        {
            _User = user;
        }
        [BindProperty]
        public LoginViewModel loginViewModel { get; set; }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            try
            {
                if (_User.CheckUserName(loginViewModel.Name).Equals("CorrectUsername"))
                {
                    if (_User.CheckPassword(loginViewModel.PassWord, loginViewModel.Name).Equals("CorrectPassword"))
                    {
                        var user = _User.FindByUserName(loginViewModel.Name);
                        if (user != null)
                        {

                            var userClime = new List<Claim>()
                            {
                              new Claim( ClaimTypes.NameIdentifier, user.Id.ToString()),
                              new Claim( ClaimTypes.Name, user.Name.ToString())
                              
                             
                        };
                            var identity = new ClaimsIdentity(userClime, CookieAuthenticationDefaults.AuthenticationScheme);


                            var properties = new AuthenticationProperties
                            {
                                IsPersistent = loginViewModel.RememberMe
                            };
                            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                            return Redirect("~/");
                        }
                        else
                        {
                            ModelState.AddModelError("User ", "نام کاربری یا کلمه عبور اشتباه است");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Password ", "نام کاربری یا کلمه عبور اشتباه است");
                    }
                }
                return Page();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return Page();
            }
        }
    }
}
