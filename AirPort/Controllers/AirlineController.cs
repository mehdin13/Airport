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
    public class AirlineController : ControllerBase
    {
        public readonly IAirline _airline;
        public readonly IDetail _detail;
        public AirlineController(IAirline airline, IDetail detail)
        {
            _airline = airline;
            _detail = detail;
        }
        [HttpGet]
        [Route("AirlineList")]
        public JsonAirline AirlineListes()
        {
            JsonAirline jsonAirline = new JsonAirline();
            List<AirlineviewModel> airlinelinklist = new List<AirlineviewModel>();
            try
            {
                var listairLines = _airline.ToList();
                foreach (var item in listairLines)
                {
                    AirlineviewModel airlinelistobj = new AirlineviewModel();
                    airlinelistobj.Name = item.Name;
                    airlinelistobj.Logo = item.Logo;
                    airlinelistobj.DetailId = item.Id;
                    airlinelinklist.Add(airlinelistobj);
                }
                jsonAirline.Result = airlinelinklist;
                return jsonAirline;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return jsonAirline;
            }
        }
        [HttpGet]
        [Route("AirlineDetail")]
        public AirlinedetailViewModel AirlineDetail(int id)
        {
            AirlinedetailViewModel airlineListObj = new AirlinedetailViewModel();
            FeatureValueVeiwModel feature = new FeatureValueVeiwModel();
            try
            {
                List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel> featuresLists = new List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel>();
                var airlins = _airline.FindById(id);
                airlineListObj.Name = airlins.Name;
                airlineListObj.Airline = airlins.Name;
                airlineListObj.Logo = airlins.Logo;
                foreach (var item in _detail.FeatureValues(id))
                {
                    feature.name = item.name;
                    feature.value = item.value;
                    featuresLists.Add(feature);
                }
                airlineListObj.Detail = featuresLists;
                return airlineListObj;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return airlineListObj;
            }
        }
    }

}
