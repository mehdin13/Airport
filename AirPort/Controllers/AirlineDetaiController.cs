using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using System.Collections.Generic;
using AirPort.Model.ViewModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirlineDetaiController : ControllerBase
    {
        public readonly IAirline _airline;
        public AirlineDetaiController(IAirline airlinedetail)
        {
            _airline = airlinedetail;
        }
        [HttpPost]
        [Route("AirlinDetail")]
        public List<AirlinedetailViewModel> AirlinDetaiLlist()
        {
            AirlinedetailViewModel airlinelistobj = new AirlinedetailViewModel();
            List<AirlinedetailViewModel> airlinelinklistobj = new List<AirlinedetailViewModel>();
            try
            {
                var AirlinedetailList = _airline.airlinedetaillists();
                foreach (var item in AirlinedetailList)
                {
                    airlinelistobj.Name = item.Name;
                    airlinelistobj.DetailId = item.DetailId;
                    airlinelistobj.Logo = item.Logo;
                    // airlinelistobj.Phone=item.     //aslan phone nadare ke :((
                    airlinelistobj.AirlineId = item.Id;
                    airlinelinklistobj.Add(airlinelistobj);
                }
                return airlinelinklistobj;
            }
            catch (Exception)
            {
                return airlinelinklistobj;
            }
        }
    }
}
