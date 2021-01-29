using System;
using AirPort.Model.ViewModel;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicesController : Controller
    {
        private readonly ILinks _link;
        private readonly IPlace _place;
        private readonly IAddress _address;

        public ServicesController(ILinks links, IPlace place, IAddress address)
        {
            _link = links;
            _place = place;
            _address = address;
        }
        //animal

        [HttpGet]
        [Route("CargoServices")]
        public JsonServices CargoServices()
        {
            JsonServices jsonServices = new JsonServices();
            List<ServicesViewModel> CargoServicesOBJ = new List<ServicesViewModel>();
            try
            {
                var Cargoes = _place.ServicesTypeCargo();
                foreach (var item in Cargoes)
                {
                    ServicesViewModel CargoObj = new ServicesViewModel();

                    //Places
                    CargoObj.Name =  item.Name;
                    CargoObj.Phone = item.PhoneNumber;
                    //link
                    CargoObj.Title = _link.FindById(item.Id).Title;
                    CargoObj.Description = _link.FindById(item.Id).Description;
                    CargoObj.Icon = _link.FindById(item.Id).Icon;
                    CargoObj.Type = _link.FindById(item.Id).Type;
                    //address
                    CargoObj.LocationX = _address.FindById(item.Id).LocationX;
                    CargoObj.LocationX = _address.FindById(item.Id).LocationY;
                    CargoObj.LocationX = _address.FindById(item.Id).LocationR;
                    CargoServicesOBJ.Add(CargoObj);
                }
                jsonServices.Result = CargoServicesOBJ;
                return jsonServices;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return jsonServices;
            }
        }
        [HttpGet]
        [Route("ClearanceServices")]
        public JsonServices ClearanceServices()
        {
            JsonServices jsonServices = new JsonServices();
            List<ServicesViewModel> ClearanceServicesOBJ = new List<ServicesViewModel>();
            try
            {
                var Cargoes = _place.ServicesTypeClearance();
                foreach (var item in Cargoes)
                {
                    ServicesViewModel ClearanceObj = new ServicesViewModel();

                    //Places
                    ClearanceObj.Name =  item.Name;
                    ClearanceObj.Phone = item.PhoneNumber;
                    //link
                    ClearanceObj.Title = _link.FindById(item.Id).Title;
                    ClearanceObj.Description = _link.FindById(item.Id).Description;
                    ClearanceObj.Icon = _link.FindById(item.Id).Icon;
                    ClearanceObj.Type = _link.FindById(item.Id).Type;
                    //address
                    ClearanceObj.LocationX = _address.FindById(item.Id).LocationX;
                    ClearanceObj.LocationX = _address.FindById(item.Id).LocationY;
                    ClearanceObj.LocationX = _address.FindById(item.Id).LocationR;
                    ClearanceServicesOBJ.Add(ClearanceObj);
                }
                jsonServices.Result = ClearanceServicesOBJ;
                return jsonServices;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return jsonServices;
            }
        }
        [HttpGet]
        [Route("AnimalsServices")]
        public JsonServices AnimalsServices()
        {
            JsonServices jsonServices = new JsonServices();
            List<ServicesViewModel> AnimalsServicesOBJ = new List<ServicesViewModel>();
            try
            {
                var Cargoes = _place.ServicesTypeAnimal();
                foreach (var item in Cargoes)
                {
                    ServicesViewModel AnimalsObj = new ServicesViewModel();

                    //Places
                    AnimalsObj.Name =  item.Name;
                    AnimalsObj.Phone = item.PhoneNumber;
                    //link
                    AnimalsObj.Title = _link.FindById(item.Id).Title;
                    AnimalsObj.Description = _link.FindById(item.Id).Description;
                    AnimalsObj.Icon = _link.FindById(item.Id).Icon;
                    AnimalsObj.Type = _link.FindById(item.Id).Type;
                    //address
                    AnimalsObj.LocationX = _address.FindById(item.Id).LocationX;
                    AnimalsObj.LocationX = _address.FindById(item.Id).LocationY;
                    AnimalsObj.LocationX = _address.FindById(item.Id).LocationR;
                    AnimalsServicesOBJ.Add(AnimalsObj);
                }
                jsonServices.Result = AnimalsServicesOBJ;
                return jsonServices;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return jsonServices;
            }
        }
    }
}
