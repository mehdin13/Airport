using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using AirPortDataLayer.Crud;
using AirPort.Model.ViewModel;


namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AccountController : ControllerBase
    {
        private readonly ICustomer _Customer;
        public AccountController(ICustomer customerService)
        {
            _Customer = customerService;
        }
        [HttpPost]
        [Route("Register")]
        public ProgressStatus UserRegister(RegisterViewModel registerViewModel)
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
                    customerobj.Password = registerViewModel.Password;
                    if (_Customer.Insert(customerobj) != 0)
                    {
                        Result = new ProgressStatus { Message = " ثبت نام با موفقیت انجام شد", Number = 1, Title = "Register Successful !" };
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
        public ProgressStatus UserLogin(LoginViewModel loginViewModel)
        {
            var Result = new ProgressStatus();
            try
            {
                if (_Customer.CheckLoginInfo(loginViewModel.Email, loginViewModel.Password).Number.Equals(1))
                {
                    Result = new ProgressStatus { Message = "با موفقیت وارد شدید", Number = 1, Title = "Login SuccessFul" };
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
        public ProgressStatus userprofile(ProfileViewModel profileViewModel)
        {

            try
            {
                var result = new ProgressStatus();
                if (profileViewModel.Token.Equals("1"))
                {

                    AirPortModel.Models.Customer customerobj = _Customer.FindByEmail(profileViewModel.Email);
                    customerobj.Name = profileViewModel.Name;
                    customerobj.LastName = profileViewModel.LastName;
                    customerobj.Email = profileViewModel.Email;
                    customerobj.Mobile = profileViewModel.Mobile;
                    customerobj.Sex = profileViewModel.Sex;
                    customerobj.BDate = profileViewModel.Bdate;

                    if (_Customer.Update(customerobj).Number.Equals(1))
                    {
                        result = new ProgressStatus { Number = 1, Title = "Updete Successful", Message = "ویرایش با موفقیت انجام شد" };
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
        public ProgressStatus ChengePassWord(ChengePasswordViewModel chengePasswordViewModel)
        {
            var Result = new ProgressStatus();

            try
            {
                if (_Customer.CheckLoginInfo(chengePasswordViewModel.Token, chengePasswordViewModel.OldPassword).Number.Equals(1))
                {
                    if (chengePasswordViewModel.NewPassword == chengePasswordViewModel.RNewPassword)
                    {
                        if (_Customer.ChengePassWord(chengePasswordViewModel.Token, chengePasswordViewModel.NewPassword).Number.Equals(1))
                        {
                            var result = new ProgressStatus { Number = 1, Title = "Successful", Message = "Successful" };
                            return result;
                        }
                        else
                        {
                            var result = new ProgressStatus { Number = 2, Title = "unSuccessfulr", Message = "Unsuccessful" };
                            return result;
                        }
                    }
                    else
                    {
                        var result = new ProgressStatus { Number = 3, Title = "unSuccessful", Message = "Unsuccessful" };
                        return result;
                    }

                }
                else
                {
                    var result = new ProgressStatus { Number = 4, Title = "unSuccessful", Message = "Unsuccessful" };
                    return result;
                }

                return Result;
            }
            catch (Exception ex)
            {
                var result = new ProgressStatus { Number = 0, Title = "UnHandeled Error", Message = ex.Message };
                return result;

            }
        }
    }
}
