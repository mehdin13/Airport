using System;
using AirPort.Model.ViewModel;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AirPortDataLayer.Crud;
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
        public JsonFlight FlightList()
        {
            JsonFlight jsonFlight = new JsonFlight();
            List<FlightViewModel> flightlinklistObj = new List<FlightViewModel>();
            try
            {
                var ListFlights = _flight.ToList();
                foreach (var item in ListFlights)
                {
                    var Flight = _flight.FindById(item.Id);
                    FlightViewModel FlightlistObj = new FlightViewModel();
                    FlightlistObj.FlightNumber = item.Number;
                    FlightlistObj.Airplaincode = Flight.FlightAirPlaneId;
                    FlightlistObj.airplainid = Flight.FlightAirPlaneId;
                    FlightlistObj.AirplainName = _airPlane.FindById(Flight.FlightAirPlaneId).Name;
                    FlightlistObj.AirlineIcon = _airline.FindById(_airPlane.FindById(Flight.FlightAirPlaneId).AirlineId).Logo;
                    FlightlistObj.AirlineName = _airline.FindById(_airPlane.FindById(Flight.FlightAirPlaneId).AirlineId).Name;
                    FlightlistObj.AirlineId = _airline.FindById(_airPlane.FindById(Flight.FlightAirPlaneId).AirlineId).Id;
                    FlightlistObj.Flightid = Flight.Id;
                    FlightlistObj.StartAirPortId = _city.FindById(_address.FindById(_airport.FindById(Flight.StartAirPortId).AirPortAddressId).CityId).Id;
                    FlightlistObj.startCityName = _city.FindById(_address.FindById(_airport.FindById(Flight.StartAirPortId).AirPortAddressId).CityId).Name;
                    FlightlistObj.EndAirPortid = _city.FindById(_address.FindById(_airport.FindById(Flight.StartAirPortId).AirPortAddressId).CityId).Id;
                    FlightlistObj.EndcityName = _city.FindById(_address.FindById(_airport.FindById(Flight.StartAirPortId).AirPortAddressId).CityId).Name;

                    FlightlistObj.WeatherIcon = _Weatger.FindByAirportId(Flight.StartAirPortId).Icon;
                    FlightlistObj.StartTime = Flight.EndTimeDate;
                    FlightlistObj.EndTime = Flight.EndTimeDate;
                    FlightlistObj.Delay = Flight.Delay;

                    flightlinklistObj.Add(FlightlistObj);
                }
                jsonFlight.Result = flightlinklistObj;
                return jsonFlight;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return jsonFlight;
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

                    FlightdetailObj.FlightNumber = flightobj.Number;
                    FlightdetailObj.Airplaincode = flightobj.FlightAirPlaneId;
                    FlightdetailObj.airplainid = flightobj.FlightAirPlaneId;
                    FlightdetailObj.AirplainName = _airPlane.FindById(flightobj.FlightAirPlaneId).Name;
                    FlightdetailObj.AirlineIcon = _airline.FindById(_airPlane.FindById(flightobj.FlightAirPlaneId).AirlineId).Logo;
                    FlightdetailObj.AirlineName = _airline.FindById(_airPlane.FindById(flightobj.FlightAirPlaneId).AirlineId).Name;
                    FlightdetailObj.AirlineId = _airline.FindById(_airPlane.FindById(flightobj.FlightAirPlaneId).AirlineId).Id;
                    FlightdetailObj.Flightid = flightobj.Id;
                    FlightdetailObj.StartAirPortId = _city.FindById(_address.FindById(_airport.FindById(flightobj.StartAirPortId).AirPortAddressId).CityId).Id;
                    FlightdetailObj.startCityName = _city.FindById(_address.FindById(_airport.FindById(flightobj.StartAirPortId).AirPortAddressId).CityId).Name;
                    FlightdetailObj.EndAirPortid = _city.FindById(_address.FindById(_airport.FindById(flightobj.StartAirPortId).AirPortAddressId).CityId).Id;
                    FlightdetailObj.EndcityName = _city.FindById(_address.FindById(_airport.FindById(flightobj.StartAirPortId).AirPortAddressId).CityId).Name;
                    FlightdetailObj.WeatherIcon = _Weatger.FindByAirportId(flightobj.StartAirPortId).Icon;
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
        public JsonFlightlist MyflightList()
        {
            JsonFlightlist jsonFlightlist = new JsonFlightlist();
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
                    jsonFlightlist.Result = flightlistOBJ;
                    return jsonFlightlist;
                }

                return jsonFlightlist;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return jsonFlightlist;
            }
        }

    }
}
