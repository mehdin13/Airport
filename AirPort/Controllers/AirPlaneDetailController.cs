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
        private readonly IGallery _gallery;
        public AirPlaneDetailController(IAirPlane airPlane, IGallery gallery)
        {
            _airplane = airPlane;
            _gallery = gallery;
        }

        [HttpGet]
        [Route("AirlinDetail")]
        public List<AirPlaneDetailViewModel> airplanedetaillist(int id)
        {
            List<AirPlaneDetailViewModel> airlinelinklistobj = new List<AirPlaneDetailViewModel>();
            try
            {
                //var airplainsdetails = _airplane.FindById(id);
                foreach (var item in _airplane.FindById(id))
                {
                    AirPlaneDetailViewModel airlinelistobj = new AirPlaneDetailViewModel();
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
            catch (Exception ex)
            {
                string mes = ex.Message;
                return airlinelinklistobj;
            }
        }
    }
}
