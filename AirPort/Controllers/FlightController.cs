using System;
using AirPort.Model.ViewModel;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AirPort.Model;
using AirPortDataLayer.Crud;
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
    public class FlightController : ControllerBase
    {
        private readonly IFlight _flight;
        private readonly IAirPlane _airPlane;
        private readonly IAirPort _airport;
        private readonly IDetail _detail;
        private readonly ICustomer _customer;
        private readonly IFlightStatus _flightStatus;
        private readonly IGate _gate;
        private readonly IWeather _Weatger;
        private readonly ITypeDetail _TypeDetail;
        private readonly ICustomerFlight _customerFlight;
        private readonly IAirline _airline;
        private readonly ICity _city;
        private readonly IAddress _address;

        public FlightController(IFlight flight, IDetail detail, IAirPlane airPlane, IAirPort airPort, IFlightStatus flightStatus, IGate gate, IWeather weather, ITypeDetail typeDetail, ICustomer customer, ICustomerFlight customerFlight, IAirline airline, ICity city, IAddress address)
        {
            _flight = flight;
            _detail = detail;
            _airPlane = airPlane;
            _airport = airPort;
            _flightStatus = flightStatus;
            _gate = gate;
            _Weatger = weather;
            _TypeDetail = typeDetail;
            _customer = customer;
            _customerFlight = customerFlight;
            _airline = airline;
            _city = city;
            _address = address;
        }
        [HttpGet]
        [Route("FlightList")]
        public List<FlightViewModel> FlightList()
        {
            List<FlightViewModel> flightlinklistObj = new List<FlightViewModel>();
            try
            {
                var ListFlights = _flight.ToList();
                foreach (var item in ListFlights)
                {
                    FlightViewModel FlightlistObj = new FlightViewModel();
                    FlightlistObj.Number = item.Number;
                    FlightlistObj.AirplainName = _airPlane.FindById(item.FlightAirPlaneId).Name;
                    FlightlistObj.AirPortName = _airport.FindById(item.AirPortId).Name;
                    FlightlistObj.FlightStatus = _flightStatus.FindById(item.FlightstatusId).StatusType;
                    FlightlistObj.StartAirPort = _airport.FindById(item.AirPortId).Name;
                    FlightlistObj.EndAirPortId = _airport.FindById(item.AirPortId).Name;
                    FlightlistObj.Gate = _gate.FindById(item.GateId).Name;
                    //FlightlistObj.Weather =
                    //FlightlistObj.Temperature = item.AirPort.weathers.;
                    FlightlistObj.StartTime = item.StartTimeDate;
                    FlightlistObj.EndTime = item.EndTimeDate;
                    FlightlistObj.Delay = item.Delay;
                    flightlinklistObj.Add(FlightlistObj);
                }
                return flightlinklistObj;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return flightlinklistObj;
            }
        }
        [HttpGet]
        [Route("FlightDetail")]
        public FlightDetailViewModel FlightDetail(int Id)
        {
            FlightDetailViewModel FlightdetailObj = new FlightDetailViewModel();
            try
            {
                var flightobj = _flight.FindById(Convert.ToInt32(Id));
                if (flightobj != null)
                {
                    FlightdetailObj.Number = flightobj.Number;
                    FlightdetailObj.Airplain = _airPlane.FindById(flightobj.FlightAirPlaneId).Name;
                    FlightdetailObj.AirPort = _airport.FindById(flightobj.AirPortId).Name;
                    FlightdetailObj.StartAirPort = _airport.FindById(flightobj.AirPortId).Name;
                    FlightdetailObj.EndAirPort = _airport.FindById(flightobj.AirPortId).Name;
                    FlightdetailObj.FlightStatus = _flightStatus.FindById(flightobj.FlightstatusId).StatusType;
                    FlightdetailObj.Gate = _gate.FindById(flightobj.GateId).Name;
                    FlightdetailObj.StartAirportWeather = _TypeDetail.FindById(flightobj.StartAirPortId).Name;
                    FlightdetailObj.EndAirportWeather = _TypeDetail.FindById(flightobj.FlightEndAirportId).Name;
                    FlightdetailObj.StartAirportTemperature = _TypeDetail.FindById(flightobj.StartAirPortId).Name;
                    FlightdetailObj.EndAirportTemperature = _TypeDetail.FindById(flightobj.FlightEndAirportId).Name;
                    FlightdetailObj.StartTime = flightobj.StartTimeDate;
                    FlightdetailObj.EndTime = flightobj.EndTimeDate;
                    FlightdetailObj.Delay = flightobj.Delay;
                }
                return FlightdetailObj;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return FlightdetailObj;
            }
        }
        [HttpGet]
        [Route("DetailFlight")]
        public DetailFlightViewModel DetailFlight(int id)
        {
            DetailFlightViewModel DFOBJ = new DetailFlightViewModel();
            try
            {
                var flightobj = _flight.FindById(Convert.ToInt32(id));
                if (flightobj != null)
                {
                    DFOBJ.AirportStartName = _airport.FindById(flightobj.AirPortId).Name;
                    DFOBJ.AirportEnd = _airport.FindById(flightobj.AirPortId).Name;
                    DFOBJ.typeName = _TypeDetail.FindById(flightobj.Id).Name;
                    DFOBJ.Temperature = _Weatger.FindById(flightobj.Id).Temperature;
                    DFOBJ.StartTime = flightobj.StartTimeDate;
                    DFOBJ.EndTime = flightobj.EndTimeDate;
                    DFOBJ.Delay = flightobj.Delay;
                }
                return DFOBJ;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return DFOBJ;
            }
        }
        [HttpPost]
        [Route("AddToMyFlyght")]
        public ProgressStatus AddToMyFlyght([FromForm] AddtoFlightList addtoFlightList)
        {
            var result = new ProgressStatus();
            try
            {
                string Custumerid = User.Claims.First(u => u.Type == "Customer").Value;
                var Userobj = _customer.FindById(Convert.ToInt32(Custumerid));
                if (Userobj != null)
                {
                    if (_flight.FindById(addtoFlightList.Flightid) != null)
                    {
                        AirPortModel.Models.CustomerFlight customerFlightobj = new AirPortModel.Models.CustomerFlight();
                        customerFlightobj.CustomerId = Userobj.Id;
                        customerFlightobj.FlightId = addtoFlightList.Flightid;
                        if (_customerFlight.Insert(customerFlightobj) != 0)
                        {
                            result = new ProgressStatus { Number = 1, Title = "Update Successful", Message = " با موفقیت به لیست پرواز من اضافه شد" };

                        }
                        else
                        {

                            result = new ProgressStatus { Number = 4, Title = "Update Successful", Message = " با خطا مواجه شد" };
                        }
                    }
                    else
                    {
                        result = new ProgressStatus { Number = 2, Title = "Update Successful", Message = "شناسه پرواز نا معتبر" };
                    }


                }
                else
                {
                    result = new ProgressStatus { Number = 3, Title = "Update Successful", Message = "توکن نا معتبر" };
                }

                return result;
            }
            catch (Exception ex)
            {
                result = new ProgressStatus { Number = 0, Title = "UnhandledError", Message = ex.Message };
                return result;
            }
        }
        [HttpGet]
        [Route("MyflightList")]
        public List<FlightListViewModel> MyflightList()
        {
            List<FlightListViewModel> flightlistOBJ = new List<FlightListViewModel>();
            try
            {
                string Custumerid = User.Claims.First(u => u.Type == "Customer").Value;
                var Userobj = _customer.FindById(Convert.ToInt32(Custumerid));
                if (Userobj != null)
                {
                    foreach (var item in _customerFlight.ToList(Userobj.Id))
                    {
                        var Flight = _flight.FindById(item.FlightId);
                        FlightListViewModel flightObj = new FlightListViewModel();
                        flightObj.FlightNumber = Flight.Number;
                        flightObj.airplainid = Flight.FlightAirPlaneId;
                        flightObj.Airplaincode = Flight.FlightAirPlaneId;
                        flightObj.AirlineIcon = _airline.FindById(_airPlane.FindById(Flight.FlightAirPlaneId).AirlineId).Logo;
                        flightObj.AirlineName = _airline.FindById(_airPlane.FindById(Flight.FlightAirPlaneId).AirlineId).Name;
                        flightObj.AirlineId = _airline.FindById(_airPlane.FindById(Flight.FlightAirPlaneId).AirlineId).Id;
                        flightObj.Flightid = Flight.Id;
                        flightObj.StartAirPort = _city.FindById(_address.FindById(_airport.FindById(Flight.StartAirPortId).AirPortAddressId).CityId).Name;
                        flightObj.EndAirPort = _city.FindById(_address.FindById(_airport.FindById(Flight.StartAirPortId).AirPortAddressId).CityId).Name;
                        flightObj.WeatherIcon = _Weatger.FindByAirportId(Flight.StartAirPortId).Icon;
                        flightObj.StartTime = Flight.StartTimeDate;
                        flightObj.EndTime = Flight.EndTimeDate;
                        flightObj.Delay = Flight.Delay;
                        flightlistOBJ.Add(flightObj);
                    }
                    return flightlistOBJ;
                }

                return flightlistOBJ;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return flightlistOBJ;
            }
        }

    }
}
