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
        private readonly ICity _city;
        private readonly IState _state;
        public ParkingController(IPlace place, IAirPort airPort, IAddress address, IDetail detail, ICategory category, ICity city, IState state)
        {
            _place = place;
            _airport = airPort;
            _address = address;
            _detail = detail;
            _category = category;
            _city = city;
            _state = state;
        }
        [HttpGet]
        [Route("Parking")]
        public ParkingViewModel Parking(int id)
        {
            ParkingViewModel parkingOBJ = new ParkingViewModel();
            try
            {
                var parking = _place.FindById(Convert.ToInt32(id));
                if (parking != null && parking.AirportId != null)
                {

                    // parkingOBJ.Detail =
                    parkingOBJ.Cost = parking.Cost.ToString();
                    parkingOBJ.Airport = _airport.FindById(parking.AdressId).Name;
                    parkingOBJ.LocationX = _address.FindById(parking.AdressId).LocationX;
                    parkingOBJ.LocationY = _address.FindById(parking.AdressId).LocationY;
                    parkingOBJ.LocationR = _address.FindById(parking.AdressId).LocationR;
                    parkingOBJ.AddressDetail = _address.FindById(parking.AdressId).Detail;
                    parkingOBJ.CityName = _city.FindById(_address.FindById(_place.FindById(parking.Id).AdressId).CityId).Name;
                    parkingOBJ.StateName = _state.FindById(_address.FindById(_city.FindById(parking.Id).CityStateId).Id).Name;

                    parkingOBJ.Categori = _category.FindById(parking.CategoryId).CategoryName;

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
