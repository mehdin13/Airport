using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using System.Collections.Generic;
using AirPort.Model.ViewModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirPlaneDetailController : ControllerBase
    {
        private readonly IAirPlane _airplane;
        public AirPlaneDetailController(IAirPlane airPlane)
        {
            _airplane = airPlane;
        }

        [HttpPost]
        [Route("AirlinDetail")]
        public List<AirPlaneDetailViewModel> airplanedetaillist()
        {
            AirPlaneDetailViewModel airlinelistobj = new AirPlaneDetailViewModel();
            List<AirPlaneDetailViewModel> airlinelinklistobj = new List<AirPlaneDetailViewModel>();
            try
            {
                var listdetailairplane = _airplane.AirplaneDetailList();
                foreach (var item in listdetailairplane)
                {
                    airlinelistobj.AirPlaneId = item.Id;
                    airlinelistobj.Name = item.Name;
                    airlinelistobj.Model = item.Model;
                    airlinelistobj.AirplaneCode = item.AirPlaneCode;
                    airlinelistobj.BrandId = item.BrandId;
                    airlinelistobj.GalleryId = item.GalleryId;
                    airlinelistobj.DetailId = item.Id;
                    airlinelistobj.AirLineId = item.AirlineId;
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
