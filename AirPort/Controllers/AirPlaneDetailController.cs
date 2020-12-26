using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using System.Collections.Generic;
using AirPort.Model.ViewModel;
using AirPortDataLayer.Crud.VeiwModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirPlaneDetailController : ControllerBase
    {

        private readonly IDetail _detail;
        private readonly IAirPlane _airplane;
        private readonly IAirPort _airport;
        private readonly IGallery _gallery;

        public AirPlaneDetailController(IDetail detail, IAirPort airPort, IGallery gallery, IAirPlane airPlane)
        {

            _detail = detail;
            _airport = airPort;
            _gallery = gallery;
            _airplane = airPlane;
        }

        [HttpGet]
        [Route("AirplaneDetailList")]
        public AirPlaneDetailViewModel AirplaneDetailList(int id)
        {

            AirPlaneDetailViewModel airPlanelistobj = new AirPlaneDetailViewModel();
            try
            {
                List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel> featuresLists = new List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel>();
                var airplane = _airplane.FindById(id);
                airPlanelistobj.AirPlaneId = airplane.Id;
                airPlanelistobj.Name = airplane.Name;
                airPlanelistobj.Model = airplane.Model;
                airPlanelistobj.AirplaneCode = airplane.AirPlaneCode;
                airPlanelistobj.BrandId = airplane.BrandId;
                airPlanelistobj.GalleryId = airplane.GalleryId;
                airPlanelistobj.AirLineId = airplane.AirlineId;
                foreach (var item in _detail.FeatureValues(id))
                {
                    FeatureValueVeiwModel feature = new FeatureValueVeiwModel();
                    feature.name = item.name;
                    feature.value = item.value;
                    featuresLists.Add(feature);
                }
                airPlanelistobj.Detail = featuresLists;
                return airPlanelistobj;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return airPlanelistobj;
            }
        }
    }
}
