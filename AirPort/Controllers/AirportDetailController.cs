using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using AirPortDataLayer.Crud;
using AirPort.Model.ViewModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirportDetailController : ControllerBase
    {
        public readonly IAirPort _airPort;
        public readonly IFlight _flight;
        public readonly IAirPlane _airplane;
        public AirportDetailController(IAirPort airport, IFlight flight, IAirPlane airPlane)
        {
            _airPort = airport;
            _flight = flight;
            _airplane = airPlane;
        }
        public List<AirportViewModel> AirportList()
        {
            AirportViewModel airportobj = new AirportViewModel();
            List<AirportViewModel> airportlinklistobj = new List<AirportViewModel>();
            try
            {
                var Listairport = _airPort.airportlists();
                foreach (var item in Listairport)
                {
                    airportobj.Name = item.Name;
                    airportobj.AirportId = item.Id;
                    //airportobj.GalleryId = _airplane.FindById(item.Gallery).Id;
                    airportobj.AirportCode = item.Code;
                    airportobj.Abbreviation = item.Abbreviation;
                    airportlinklistobj.Add(airportobj);
                }
                return airportlinklistobj;
            }
            catch (Exception)
            {
                return airportlinklistobj;
            }

        }
    }
}
