using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using System.Collections.Generic;
using AirPort.Model.ViewModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirPlaneBrandController : ControllerBase
    {
        private readonly IAirPlane _airplane; 
        public AirPlaneBrandController (IAirPlane airPlane)
        {
            _airplane = airPlane;
        }
        [HttpGet]
        [Route("AirplaneList")]
        public List<AirPlaneBrandviewModel> AirplaneList()
        {
            AirPlaneBrandviewModel airplanelistobj = new AirPlaneBrandviewModel();
            List<AirPlaneBrandviewModel> airplainlinklistobj = new List<AirPlaneBrandviewModel>();
            try
            {
                var Airplanelistes = _airplane.AirplaneList();
                foreach (var item in Airplanelistes)
                {
                    airplanelistobj.BrandId = item.BrandId;
                    airplanelistobj.BrandName = item.Name;
                    //airplanelistobj.BrandIcon = item.Gallery;
                    airplainlinklistobj.Add(airplanelistobj);
                }
                return airplainlinklistobj;
            }
            catch (Exception)
            {
                return airplainlinklistobj;
            }
        }
    }
}
