using System;
using AirPort.Model.ViewModel;
using AirPortDataLayer.Crud.InterFace;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AirPortDataLayer.Crud.VeiwModel;

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
        public FlightController(IFlight flight, IDetail detail, IAirPlane airPlane,IAirPort airPort)
        {
            _flight = flight;
            _detail = detail;
            _airPlane = airPlane;
            _airport = airPort;
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
                    FlightlistObj.FlightStatus = item.FlightStatus.StatusType;
                    FlightlistObj.StartAirPort = item.StartAirPort.Name;
                    FlightlistObj.EndAirPortId = item.EndAirport.Name;
                    FlightlistObj.Gate = item.Gate.Name;
                    //FlightlistObj.Weather = item.AirPort.weathers;
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
            FeatureValueVeiwModel feature = new FeatureValueVeiwModel();
            try
            {
                foreach (var item in _detail.FeatureValues(Id))
                {
                    feature.name = item.name;
                    feature.value = item.value;
                    FlightdetailObj.Detail.Add(feature);
                }
                return FlightdetailObj;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return FlightdetailObj;
            }
        }
    }
}
