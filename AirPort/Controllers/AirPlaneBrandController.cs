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
        private readonly IBrand _brand;

        public AirPlaneBrandController(IBrand brand)
        {
            _brand = brand;
        }
        [HttpGet]
        [Route("AirplaneBrandList")]
        public List<AirPlaneBrandviewModel> AirplaneBrandList()
        {

            List<AirPlaneBrandviewModel> airplainBrandlinklistobj = new List<AirPlaneBrandviewModel>();
            try
            {
                foreach (var item in _brand.ToList())
                {
                    AirPlaneBrandviewModel airplaneBrandlistobj = new AirPlaneBrandviewModel();
                    airplaneBrandlistobj.BrandIcon = item.BrandIcon;
                    airplaneBrandlistobj.BrandId = item.Id;
                    airplaneBrandlistobj.BrandName = item.BrandName;
                    airplainBrandlinklistobj.Add(airplaneBrandlistobj);
                }
                return airplainBrandlinklistobj;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return airplainBrandlinklistobj;
            }
        }
    }
}
