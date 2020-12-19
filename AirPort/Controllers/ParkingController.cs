using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using AirPortDataLayer.Crud;
using AirPort.Model.ViewModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParkingController : ControllerBase
    {
        private readonly IPlace _place;
        private readonly IDetail _detail;
        private readonly IAirPort _airport;
        private readonly IAddress _address;
        private readonly ICategory _category;
        public ParkingController(IPlace place, IAirPort airPort, IAddress address, IDetail detail, ICategory category)
        {
            _place = place;
            _airport = airPort;
            _address = address;
            _detail = detail;
            _category = category;
        }
        [HttpGet]
        [Route("Parking")]
        public ParkingViewModel Parking(int id)
        {
            ParkingViewModel parkingOBJ = new ParkingViewModel();
            try
            {
                var parkingsobj2 = _place.FindById(Convert.ToInt32(id));
                if (parkingsobj2 != null)
                {
                    //parkingOBJ.Detail = _detail.FindById(parkingsobj2.DetailId).;
                    parkingOBJ.Cost = parkingsobj2.Cost.ToString();
                    parkingOBJ.Airport = _airport.FindById(parkingsobj2.Adress).Name;
                    parkingOBJ.LocationX = _address.FindById(parkingsobj2.Adress).LocationX;
                    parkingOBJ.LocationY = _address.FindById(parkingsobj2.Adress).LocationY;
                    parkingOBJ.LocationR = _address.FindById(parkingsobj2.Adress).LocationR;
                    parkingOBJ.AddressDetail = parkingsobj2.Adress;
                    parkingOBJ.CityName = parkingsobj2.Name;
                    parkingOBJ.StateName = parkingsobj2.Name;
                    parkingOBJ.Categori = _category.FindById(parkingsobj2.CategoryId).CategoryName;
                }
                return parkingOBJ;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return parkingOBJ;
            }
        }
    }
}
