using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using AirPort.Model.ViewModel;
using System.Collections.Generic;


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
            List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel> featureValuesList = new List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel>();

            try
            {
                var parking = _place.FindById(Convert.ToInt32(id));
                if (parking != null && parking.AirportId != null)
                {
                    var featurelist = _detail.FeatureValues(parking.DetailId);
                    foreach (var x in featurelist)
                    {
                        AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel featureValue = new AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel();
                        featureValue.name = x.name;
                        featureValue.value = x.value;
                        featureValuesList.Add(featureValue);
                    }
                    parkingOBJ.Detail = featureValuesList;
                    // parkingOBJ.Detail =
                    parkingOBJ.Cost = parking.Cost.ToString();
                    parkingOBJ.Airport = _airport.FindById(parking.AirportId).Name;
                    parkingOBJ.LocationX = _address.FindById(parking.AdressId).LocationX;
                    parkingOBJ.LocationY = _address.FindById(parking.AdressId).LocationY;
                    parkingOBJ.LocationR = _address.FindById(parking.AdressId).LocationR;
                    parkingOBJ.AddressDetail = _address.FindById(parking.AdressId).Detail;
                    parkingOBJ.CityName = _city.FindById(_address.FindById(_place.FindById(parking.Id).AdressId).CityId).Name;
                    parkingOBJ.StateName = _state.FindById(_city.FindById(_address.FindById(_place.FindById(parking.Id).AdressId).CityId).CityStateId).Name;
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
        [HttpGet]
        [Route("ParkingList")]
        public JsonParking ParkingList(int id)
        {
            List<ParkingViewModel> parkingList = new List<ParkingViewModel>();
            List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel> featureValuesList = new List<AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel>();
            JsonParking jsonParking = new JsonParking();
            try
            {
                var parking = _place.AirportParkingList(Convert.ToInt32(id));
                foreach (var item in parking)
                {
                    ParkingViewModel parkingOBJ = new ParkingViewModel();
                    if (item != null && item.AirportId != null)
                    {
                        parkingOBJ.Cost = item.Cost.ToString();
                        parkingOBJ.Airport = item.Name;
                        parkingOBJ.LocationX = _address.FindById(item.AdressId).LocationX;
                        parkingOBJ.LocationY = _address.FindById(item.AdressId).LocationY;
                        parkingOBJ.LocationR = _address.FindById(item.AdressId).LocationR;
                        parkingOBJ.AddressDetail = _address.FindById(item.AdressId).Detail;
                        parkingOBJ.CityName = _city.FindById(_address.FindById(_place.FindById(item.Id).AdressId).CityId).Name;
                        parkingOBJ.StateName = _state.FindById(_city.FindById(_address.FindById(_place.FindById(item.Id).AdressId).CityId).CityStateId).Name;
                        parkingOBJ.Categori = _category.FindById(item.CategoryId).CategoryName;
                        parkingList.Add(parkingOBJ);
                        var featurelist = _detail.FeatureValues(item.DetailId);
                        foreach (var x in featurelist)
                        {
                            AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel featureValue = new AirPortDataLayer.Crud.VeiwModel.FeatureValueVeiwModel();
                            featureValue.name = x.name;
                            featureValue.value = x.value;
                            featureValuesList.Add(featureValue);
                        }
                        parkingOBJ.Detail = featureValuesList;
                    }

                }
                jsonParking.result = parkingList;
                return jsonParking;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return jsonParking;
            }
        }
    }
}
