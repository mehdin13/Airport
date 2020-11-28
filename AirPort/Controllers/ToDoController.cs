using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirPortDataLayer.Crud.InterFace;
using AirPortDataLayer.Crud;
using AirPort.Model.ViewModel;
using System.IO;
using AirPortDataLayer.Crud;
namespace AirPort.Controllers
{
    [ApiController]
    [Route("Controller")]

    public class ToDoController : ControllerBase
    {
        private readonly IFlightToDo _flighttodo;
        private readonly ICustomer _customer;
        public ToDoController(IFlightToDo flighttodo, ICustomer customer)
        {
            _flighttodo = flighttodo;
            _customer = customer;
        }

        [HttpPost]
        [Route("AddToDo")]
        public ProgressStatus AddToDo(ToDoViewModel toDoViewModel)
        {
            var Result = new ProgressStatus();
            try
            {
                if (_customer.CheckCustomerEmailExisting(toDoViewModel.Email).Number.Equals(1))
                {
                    AirPortModel.Models.FlightToDo Todoobj = new AirPortModel.Models.FlightToDo();
                    Todoobj.Title = toDoViewModel.Title;
                    Todoobj.Description = toDoViewModel.Description;
                    Todoobj.FlightId = toDoViewModel.Flight;
                    if (_flighttodo.Insert(Todoobj) == 0)
                    {
                        Result = new ProgressStatus { Message = " ثبت با موفقیت انجام نشد", Number = 1, Title = "ToDo Registerd Successfully !" };
                        return Result;
                    }
                    else
                    {
                        Result = new ProgressStatus { Message = " ثبت با موفقیت انجام شد", Number = 2, Title = "ToDo not Registerd !" };
                        return Result;
                    }
                }
                else
                {
                    Result = new ProgressStatus { Message = "کاربری با این ایمیل موجود نیست", Number = 3, Title = "Email not Registerd" };
                    return Result;
                }
            }
            catch (Exception ex)
            {
                Result = new ProgressStatus { Message = ex.Message, Number = 0, Title = "unhandled Error !" };
                return Result;
            }
        }
        [HttpPost]
        [Route("tolistTodo")]
        //check beshe hatman cherto pert neveshtam :((((
        public List<ToDoListViewModel> tolist(string email)
        {
            ToDoListViewModel todoobj = new ToDoListViewModel();
            List<ToDoListViewModel> todolistobj = new List<ToDoListViewModel>();
            try
            {
                if (_customer.CheckCustomerEmailExisting(email).Number.Equals(1))
                {
                    AirPortModel.Models.Customer customerobj = _customer.FindByEmail(email);
                    if (_flighttodo.FindByCustumerId(customerobj.Id) != null)
                    {
                        var listtodo = _flighttodo.FindByCustumerId(customerobj.Id);
                        foreach (var item in listtodo)
                        {
                            todoobj.id = item.id;
                            todoobj.Name = item.Name;
                            todoobj.LastUpdate = item.LastUpdate;
                            todoobj.IsDon = item.IsDon;
                            todoobj.FlightId = item.FlightId;
                            todoobj.DateCreate = item.DateCreate;
                            todoobj.Description = item.Description;
                            todoobj.LastUpdate = item.LastUpdate;
                            todolistobj.Add(todoobj);
                        }
                        return todolistobj;
                    }
                    else
                    {
                        return todolistobj;
                    }
                }
                else
                {

                    return todolistobj;

                }
            }
            catch (Exception ex)
            {
 return todolistobj;
            }
        }

    }
}
