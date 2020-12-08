using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using System.Collections.Generic;
using AirPort.Model.ViewModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirportDetailController : ControllerBase
    {
        public readonly IAirPort _airPort;
        public readonly IAddress _address;
        public readonly IGallery _gallery;
        public AirportDetailController(IAirPort airport,IAddress address ,IGallery gallery )
        {
            _airPort = airport;
            //_address = address;
            //_gallery = gallery;
        }
        [HttpGet]
        [Route("AirportList")]
        public List<AirportDetailViewModel> AirportList()
        {
            AirportDetailViewModel airportobj = new AirportDetailViewModel();
            List<AirportDetailViewModel> airportlinklistobj = new List<AirportDetailViewModel>();
            try
            {
                var Listairport = _airPort.airportdetails();
                foreach (var item in Listairport)
                {
                    airportobj.AirporId = item.Id;
                    airportobj.Name = item.Name;
                  //airportobj.GalleryId = _airPort.FindById(item.Id).GalleryId;  
                    airportobj.AirportCode = item.Code;
                    airportobj.Abbreviation = item.Abbreviation;
                    airportobj.DetailId = item.Id;
                    //airportobj.Phone=item. air port aslan phone nadare ke :((
                   // airportobj.AddressId = _address.FindById(item.Adress).Id; 
                    airportlinklistobj.Add(airportobj);
                }
                return airportlinklistobj;
            }
            catch (Exception)
            {
                return airportlinklistobj;
            }

        }
    }
}
