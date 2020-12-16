using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using System.Collections.Generic;
using AirPort.Model.ViewModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirPlainController : Controller
    {
        private readonly IAirPlane _airplain;
        private readonly IBrand _brand;
        public AirPlainController(IAirPlane airPlane, IBrand brand)
        {
            _airplain = airPlane;
            _brand = brand;
        }
        [HttpGet]
        [Route("AirplainList")]
        public List<AirplaneBrandListViewModel> AirplainList(int Id)
        {
            List<AirplaneBrandListViewModel> airplainlinklistobj = new List<AirplaneBrandListViewModel>();
            try
            {

                foreach (var item in _airplain.getbybrand(Id))
                {
                    AirplaneBrandListViewModel airplaineListobj = new AirplaneBrandListViewModel();
                    airplaineListobj.Icon = _brand.FindById(item.BrandId).BrandIcon;
                    airplaineListobj.Name = item.Name;
                    airplaineListobj.AirplainCode = item.AirPlaneCode;
                    airplaineListobj.Brand = _brand.FindById(item.BrandId).BrandName;
                    airplainlinklistobj.Add(airplaineListobj);
                }
                return airplainlinklistobj;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return airplainlinklistobj;
            }
        }

    }
}
