using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using System.Collections.Generic;
using AirPort.Model.ViewModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirlineController : ControllerBase
    {
        public readonly IAirline _airline;
        public AirlineController(IAirline airline)
        {
            _airline = airline;
        }
        public List<AirlineviewModel> AirlineListes()
        {
            AirlineviewModel airlinelistobj = new AirlineviewModel();
            List<AirlineviewModel> airlinelinklist = new List<AirlineviewModel>();
            try
            {
                var listairLines = _airline.airlinelists();
                foreach (var item in listairLines)
                {
                    airlinelistobj.Name = item.Name;
                    airlinelistobj.Logo = item.Logo;
                    airlinelistobj.DetailId = item.Id;
                    airlinelinklist.Add(airlinelistobj);
                }
                return airlinelinklist;
            }
            catch (Exception)
            {
                return airlinelinklist;
            }
        }
    }
}
