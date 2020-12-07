using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using System.Collections.Generic;
using AirPort.Model.ViewModel;


namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirportController : ControllerBase
    {
        private readonly IAirPort _airport;
        public AirportController(IAirPort airPort)
        {
            _airport = airPort;
        }
        [HttpGet]
        [Route("Airportslists")]
        public List<AirportViewModel> Airportslist()
        {
            AirportViewModel airportlistobj = new AirportViewModel();
            List<AirportViewModel> airportlinklistobj = new List<AirportViewModel>();
            try
            {
                var listairports = _airport.airportlists();
                foreach (var item in listairports)
                {
                    airportlistobj.Name = item.Name;
                    airportlistobj.AirportId = item.Id;
                    airportlistobj.GalleryId = _airport.FindById(item.Gallery).Id;
                    airportlistobj.AirportCode = item.Code;
                    airportlistobj.Abbreviation = item.Abbreviation;
                    airportlinklistobj.Add(airportlistobj);
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
