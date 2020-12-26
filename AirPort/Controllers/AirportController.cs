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
    public class AirportController : ControllerBase
    {
        private readonly IAirPort _airport;
        private readonly IDetail _detail;
        private readonly IGallery _gallery;
        
        public AirportController(IAirPort airPort, IDetail detail, IGallery gallery)
        {
            _airport = airPort;
            _detail = detail;
            _gallery = gallery;
        }
        [HttpGet]
        [Route("Airportslists")]
        public List<AirportViewModel> Airportslist()
        {
            List<AirportViewModel> airportlinklistobj = new List<AirportViewModel>();
            try
            {
                var listairports = _airport.Tolist();
                foreach (var item in listairports)
                {
                    AirportViewModel airportlistobj = new AirportViewModel();
                    airportlistobj.Name = item.Name;
                    airportlistobj.AirportId = item.Id;
                    airportlistobj.Gallery = _gallery.FindById(item.GalleryId).Name;
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
        [HttpGet]
        [Route("AirportDetail")]
        public AirportDetailViewModel AirportDetail(int Id)
        {
            AirportDetailViewModel airportlinkOBJ = new AirportDetailViewModel();
            try
            {
                List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel> featureList = new List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel>();
                var airport = _airport.FindById(Id);
                airportlinkOBJ.Name = airport.Name;
                airportlinkOBJ.AirporId = airport.Id;
                airportlinkOBJ.GalleryId = airport.Url;
                airportlinkOBJ.AirportCode = airport.Code;
                airportlinkOBJ.Abbreviation = airport.Abbreviation;
                
                foreach (var item in _detail.FeatureValues(Id))
                {
                    AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel feature = new AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel();
                    feature.name = item.name;
                    feature.value = item.value;
                    featureList.Add(feature);
                }
                airportlinkOBJ.Detail = featureList;
                return airportlinkOBJ;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return airportlinkOBJ;
            }
        }
    }
}
