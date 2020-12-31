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
    public class AirPlainController : Controller
    {
        private readonly IDetail _detail;
        private readonly IAirPort _airport;
        private readonly IGallery _gallery;
        private readonly IAirPlane _airplane;
        private readonly IBrand _brand;

        public AirPlainController(IAirPlane airPlane, IBrand brand, IDetail detail, IAirPort airPort, IGallery gallery)
        {
            _brand = brand;
            _detail = detail;
            _airport = airPort;
            _gallery = gallery;
            _airplane = airPlane;
        }
        [HttpGet]
        [Route("AirplainList")]
        public List<AirplaneBrandListViewModel> AirplainList(int Id)
        {
            List<AirplaneBrandListViewModel> airplainlinklistobj = new List<AirplaneBrandListViewModel>();
            try
            {

                foreach (var item in _airplane.getbybrand(Id))
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
