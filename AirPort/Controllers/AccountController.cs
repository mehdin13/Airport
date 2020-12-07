using System;
using AirPort.Model;
using AirPort.Model.ViewModel;
using AirPortDataLayer.Crud;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Linq;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ICustomer _Customer;
        private readonly AppSettings _appSettings;

        public AccountController(ICustomer customerService, IOptions<AppSettings> appSettings)
        {
            _Customer = customerService;
            _appSettings = appSettings.Value;
        }
        [HttpPost]
        [Route("Register")]
        public ProgressStatus UserRegister([FromForm] RegisterViewModel registerViewModel)
        {
            var Result = new ProgressStatus();
            try
            {
                if (_Customer.CheckCustomerEmailExisting(registerViewModel.Email).Number.Equals(2))
                {
                    AirPortModel.Models.Customer customerobj = new AirPortModel.Models.Customer();
                    customerobj.Name = registerViewModel.Name;
                    customerobj.LastName = registerViewModel.LastName;
                    customerobj.Email = registerViewModel.Email;
                    customerobj.Password = PasswordHelper.EncodePasswordMd5(registerViewModel.Password);
                    if (_Customer.Insert(customerobj) != 0)
                    {
                        var tokenDescriptor = new SecurityTokenDescriptor
                        {
                            Subject = new ClaimsIdentity(new Claim[]
                           {
                        new Claim("Customer",_Customer.FindByEmail(registerViewModel.Email).Id.ToString())
                           }),
                            Expires = DateTime.UtcNow.AddYears(1),
                            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWT_Token)), SecurityAlgorithms.HmacSha256Signature)
                        };
                        var tokenHandler = new JwtSecurityTokenHandler();
                        var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                        string token = tokenHandler.WriteToken(securityToken);
                        Result = new ProgressStatus { Message = " ثبت نام با موفقیت انجام شد", Number = 1, Title = "Register Successful !", Token = token };
                        return Result;
                    }
                    else
                    {
                        Result = new ProgressStatus { Message = " ثبت نام با موفقیت انجام نشد", Number = 1, Title = "Register Successful !" };
                        return Result;
                    }

                }
                else
                {
                    Result = new ProgressStatus { Message = "کاربری با این ایمیل موجود می باشد", Number = 2, Title = "Register UnSuccessful !" };
                    return Result;
                }
            }
            catch (Exception ex)
            {
                Result = new ProgressStatus { Message = ex.Message, Number = 0, Title = "Unhandeled ERROR !" };
                return Result;
            }


        }

        [HttpPost]
        [Route("UserLogin")]
        public ProgressStatus UserLogin([FromForm] LoginViewModel loginViewModel)
        {
            var Result = new ProgressStatus();
            try
            {
                if (_Customer.CheckLoginInfo(loginViewModel.Email, loginViewModel.Password).Number.Equals(1))
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                         {
                        new Claim("Customer",_Customer.FindByEmail(loginViewModel.Email).Id.ToString())
                          }),
                        Expires = DateTime.UtcNow.AddYears(1),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWT_Token)), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    string token = tokenHandler.WriteToken(securityToken);
                    Result = new ProgressStatus { Message = "با موفقیت وارد شدید", Number = 1, Title = "Login SuccessFul", Token = token };
                    return Result;
                }
                else if (_Customer.CheckLoginInfo(loginViewModel.Email, loginViewModel.Password).Number.Equals(2))
                {
                    Result = new ProgressStatus { Message = "کلمه عبور وارد شده صحیح نیست", Number = 2, Title = "Incorrect PassWord !" };

                }
                else if (_Customer.CheckLoginInfo(loginViewModel.Email, loginViewModel.Password).Number.Equals(0))
                {
                    Result = new ProgressStatus { Message = "نام کاربری وارد شده صحیح نیست", Number = 2, Title = "Incorrect Username !" };
                }
                return Result;
            }
            catch (Exception ex)
            {
                Result = new ProgressStatus { Message = ex.Message, Number = 0, Title = "Unhandeled Error" };
                return Result;
            }
        }
        [HttpPost]
        [Route("EditProfile")]
        public ProgressStatus Userprofile([FromForm] ProfileViewModel profileViewModel)
        {
            try
            {
                string Custumerid = User.Claims.First(u => u.Type == "Customer").Value;
                var result = new ProgressStatus();
                if (_Customer.FindById(Convert.ToInt32(Custumerid)) != null)
                {
                    AirPortModel.Models.Customer customerobj = _Customer.FindById(Convert.ToInt32(Custumerid));
                    customerobj.Name = profileViewModel.Name;
                    customerobj.LastName = profileViewModel.LastName;
                    customerobj.Email = profileViewModel.Email;
                    customerobj.Mobile = profileViewModel.Mobile;
                    customerobj.Sex = profileViewModel.Sex;
                    customerobj.BDate = profileViewModel.Bdate;

                    if (_Customer.Update(customerobj).Number.Equals(1))
                    {
                        result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = "ویرایش با موفقیت انجام شد" };
                        return result;
                    }
                    else
                    {
                        result = new ProgressStatus { Number = 2, Title = "Update Successful", Message = "ویرایش با مموفقیت انجام نشد" };
                        return result;
                    }
                }
                else
                {
                    result = new ProgressStatus { Number = 4, Title = "Token NotValid", Message = "توکن معتبر نیست" };
                    return result;
                }
            }
            catch (Exception ex)
            {

                var result = new ProgressStatus { Number = 0, Title = "UnHandeled Error", Message = ex.Message };
                return result;
            }
        }
        [HttpPost]//check shavad :(
        [Route("ChangePassword")]
        public ProgressStatus ChengePassWord([FromForm] ChengePasswordViewModel chengePasswordViewModel)
        {
            try
            {
                if (_Customer.CheckLoginInfo(_Customer.FindById(Convert.ToInt32(User.Claims.First(u => u.Type.Equals("Customer")).Value)).Email, chengePasswordViewModel.OldPassword).Number.Equals(1))
                {
                    if (chengePasswordViewModel.NewPassword == chengePasswordViewModel.RNewPassword)
                    {
                        if (_Customer.ChengePassWord(Convert.ToInt32(User.Claims.First(u => u.Type == "Customer").Value), chengePasswordViewModel.NewPassword).Number.Equals(1))
                        {
                            var result = new ProgressStatus { Number = 1, Title = "Successful", Message = "رمز عبور با موفقیت تغییر کرد" };
                            return result;
                        }
                        else
                        {
                            var result = new ProgressStatus { Number = 2, Title = "unSuccessfulr", Message = "رمز عبور وارد شده با رمز قدیمی برابر نیست" };
                            return result;
                        }
                    }
                    else
                    {
                        var result = new ProgressStatus { Number = 3, Title = "unSuccessful", Message = "رمز عبور جدید با هم همخوانی ندارد" };
                        return result;
                    }
                }
                else
                {
                    var result = new ProgressStatus { Number = 4, Title = "unSuccessful", Message = "رمز عبور را دوباره وار کنید" };
                    return result;
                }

            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "UnHandeled Error", Message = ex.Message };
                return result;
            }
        }
    }
}
