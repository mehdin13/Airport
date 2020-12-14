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
        private readonly IAirPlane _airplane;
        private readonly IDetail _detail;
        private readonly IFeatrue _featrue;

        public AirPlaneDetailController(IAirPlane airPlane, IDetail detail, IFeatrue featrue)
        {
            _airplane = airPlane;
            _detail = detail;
            _featrue = featrue;
        }

        [HttpGet]
        [Route("AirplaneDetailList")]
        public AirPlaneDetailViewModel AirplaneDetailList(int id)
        {

            AirPlaneDetailViewModel airlinelistobj = new AirPlaneDetailViewModel();
            FeatureValueVeiwModel feature = new FeatureValueVeiwModel();
            try
            {
                foreach (var item in _detail.FeatureValues(id))
                {

                    feature.name = item.name;
                    feature.value = item.value;
                    airlinelistobj.Detail.Add(feature);
                }
                return airlinelistobj;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                return airlinelistobj;
            }
        }
    }
}
