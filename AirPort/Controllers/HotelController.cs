using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using AirPortDataLayer.Crud;
using AirPort.Model.ViewModel;

namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly IAddress _address;
        private readonly IPlace _place;
        private readonly IDetail _detail;
        public HotelController(IPlace place, IAddress address, IDetail detail)
        {
            _address = address;
            _place = place;
            _detail = detail;
        }
        [HttpGet]
        [Route("HotelList")]
        public List<HotelViewModel> HotelList()
        {
            HotelViewModel Hotellistobj = new HotelViewModel();
            List<HotelViewModel> hotellinklistobj = new List<HotelViewModel>();
            try
            {
                var listHotell = _place.PlaceHotellId();
                foreach (var item in listHotell)
                {
                    Hotellistobj.Name = item.Name;
                    Hotellistobj.AddresId = _address.FindById(item.Id).Id;
                    Hotellistobj.CategoryId = item.CategoryId;
                    Hotellistobj.DetailId = item.DetailId;
                    Hotellistobj.Cost = item.Cost;
                    Hotellistobj.LocationX = _address.FindById(item.Id).Id;
                    Hotellistobj.LocationY = _address.FindById(item.Id).Id;
                    Hotellistobj.LocationR = _address.FindById(item.Id).Id;
                    Hotellistobj.PhoneNumber = item.PhoneNumber;
                    hotellinklistobj.Add(Hotellistobj);
                }
                return hotellinklistobj;
            }
            catch (Exception)
            {
                return hotellinklistobj;
            }
        }
        [HttpGet]
        [Route("RestaurantList")]
        public List<HotelViewModel> RestaurantTolist()
        {
            HotelViewModel RestaurantListobj = new HotelViewModel();
            List<HotelViewModel> RestaurantlinkListobj = new List<HotelViewModel>();
            try
            {
                var ListRestaurant = _place.PlaceRestaurantid();
                foreach (var item in ListRestaurant)
                {
                    RestaurantListobj.Name = item.Name;
                    RestaurantListobj.CategoryId = _address.FindById(item.CustomerId).Id;
                    RestaurantListobj.GalleryId = item.GalleryId;
                    RestaurantListobj.DetailId = _detail.FindById(item.Id).Id;
                    RestaurantListobj.LocationX = _address.FindById(item.Id).Id;
                    RestaurantListobj.LocationY = _address.FindById(item.Id).Id;
                    RestaurantListobj.LocationR = _address.FindById(item.Id).Id;
                    RestaurantListobj.PhoneNumber = item.PhoneNumber;
                    RestaurantlinkListobj.Add(RestaurantListobj);
                }
                return RestaurantlinkListobj;
            }
            catch (Exception)
            {
                return RestaurantlinkListobj;
            }
        }
        [HttpGet]
        [Route("CofeeshopList")]
        public List<HotelViewModel> CofeeshopTolist()
        {
            HotelViewModel RestaurantListobj = new HotelViewModel();
            List<HotelViewModel> RestaurantlinkListobj = new List<HotelViewModel>();
            try
            {
                var ListRestaurant = _place.PlacesCofeeshopId();
                foreach (var item in ListRestaurant)
                {
                    RestaurantListobj.Name = item.Name;
                    RestaurantListobj.CategoryId = _address.FindById(item.CustomerId).Id;
                    RestaurantListobj.GalleryId = item.GalleryId;
                    RestaurantListobj.DetailId = _detail.FindById(item.Id).Id;
                    RestaurantListobj.LocationX = _address.FindById(item.Id).Id;
                    RestaurantListobj.LocationY = _address.FindById(item.Id).Id;
                    RestaurantListobj.LocationR = _address.FindById(item.Id).Id;
                    RestaurantListobj.PhoneNumber = item.PhoneNumber;
                    RestaurantlinkListobj.Add(RestaurantListobj);
                }
                return RestaurantlinkListobj;
            }
            catch (Exception)
            {
                return RestaurantlinkListobj;
            }
        }

        [HttpGet]
        [Route("ToureList")]
        public List<HotelViewModel> ToureList()
        {
            HotelViewModel tourelistobj = new HotelViewModel();
            List<HotelViewModel> tourelinklistobj = new List<HotelViewModel>();
            try
            {
                var ListToure = _place.PlaceToureId();
                foreach (var item in ListToure)
                {
                    tourelistobj.Name = item.Name;
                    // tourelistobj.date = item.Date;
                    tourelistobj.CategoryId = item.CategoryId;
                    tourelistobj.GalleryId = item.GalleryId;
                    tourelistobj.DetailId = item.DetailId;
                    tourelistobj.Cost = item.Cost;
                    tourelistobj.PhoneNumber = item.PhoneNumber;
                    tourelinklistobj.Add(tourelistobj);
                }
                return tourelinklistobj;
            }
            catch (Exception)
            {
                return tourelinklistobj;
            }
        }
        [HttpGet]
        [Route("ShopList")]
        public List<HotelViewModel> ShopList()
        {
            HotelViewModel shopListobj = new HotelViewModel();
            List<HotelViewModel> shopLinkListobj = new List<HotelViewModel>();
            try
            {
                var listShop = _place.PlacesShopId();
                foreach (var item in listShop)
                {
                    shopListobj.Name = item.Name;
                    shopListobj.AddresId = _address.FindById(item.Id).Id;
                    shopListobj.CategoryId = _place.FindById(item.Id).Id;
                    shopListobj.GalleryId = _place.FindById(item.Id).Id;
                    shopListobj.DetailId = _place.FindById(item.Id).Id;
                    shopListobj.LocationX = _address.FindById(item.Id).Id;
                    shopListobj.LocationY = _address.FindById(item.Id).Id;
                    shopListobj.LocationR = _address.FindById(item.Id).Id;
                    shopListobj.PhoneNumber = item.PhoneNumber;
                    shopLinkListobj.Add(shopListobj);
                }
                return shopLinkListobj;
            }
            catch (Exception)
            {
                return shopLinkListobj;
            }
        }
    }
}
