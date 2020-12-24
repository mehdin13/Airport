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
        public AirportController(IAirPort airPort, IDetail detail)
        {
            _airport = airPort;
            _detail = detail;
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
                    //  airportlistobj.Gallery = 
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
                foreach (var item in _detail.FeatureValues(Id))
                {
                    FeatureValueVeiwModel feature = new FeatureValueVeiwModel();
                    feature.name = item.name;
                    feature.value = item.value;
                    airportlinkOBJ.Detail.Add(feature);
                }
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
