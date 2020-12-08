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
        private readonly IGallery _gallery;
        private readonly IAddress _address;
        private readonly IPlace _place;
        private readonly IDetail _detail;
        public HotelController(IPlace place, IAddress address, IDetail detail, IGallery gallery)
        {
            _gallery = gallery;
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
                var listHotell = _place.PlaceHotellList();
                foreach (var item in listHotell)
                {
                    Hotellistobj.Name = item.Name;
                    Hotellistobj.Address = _address.FindById(item.Adress).Detail;
                    Hotellistobj.CategoryId = item.CategoryId;
                    Hotellistobj.DetailId = item.DetailId;
                    Hotellistobj.Cost = item.Cost;
                    Hotellistobj.LocationX = _address.FindById(item.Adress).LocationX;
                    Hotellistobj.LocationY = _address.FindById(item.Adress).LocationY;
                    Hotellistobj.LocationR = _address.FindById(item.Adress).LocationR;
                    Hotellistobj.PhoneNumber = item.PhoneNumber;
                    hotellinklistobj.Add(Hotellistobj);
                }
                return hotellinklistobj;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return hotellinklistobj;
            }
        }
        [HttpGet]
        [Route("RestaurantList")]
        public List<RestaurantViewModel> RestaurantTolist()
        {
            RestaurantViewModel RestaurantListobj = new RestaurantViewModel();
            List<RestaurantViewModel> RestaurantlinkListobj = new List<RestaurantViewModel>();
            try
            {
                var ListRestaurant = _place.PlaceRestaurantid();
                foreach (var item in ListRestaurant)
                {
                    RestaurantListobj.Name = item.Name;
                    RestaurantListobj.CategoryId = _address.FindById(item.CustomerId).Id;
                    RestaurantListobj.GalleryId = item.GalleryId;
                    RestaurantListobj.DetailId = _detail.FindById(item.DetailId).Id;//jaye kar dare
                    RestaurantListobj.LocationX = _address.FindById(item.Adress).LocationX;
                    RestaurantListobj.LocationY = _address.FindById(item.Adress).LocationY;
                    RestaurantListobj.LocationR = _address.FindById(item.Adress).LocationR;
                    RestaurantListobj.PhoneNumber = item.PhoneNumber;
                    RestaurantlinkListobj.Add(RestaurantListobj);
                }
                return RestaurantlinkListobj;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
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
        public List<ToursViewModel> ToureList()
        {
            ToursViewModel tourelistobj = new ToursViewModel();
            List<ToursViewModel> tourelinklistobj = new List<ToursViewModel>();
            try
            {
                var ListToure = _place.PlaceToureId();
                foreach (var item in ListToure)
                {
                    tourelistobj.Name = item.Name;
                    //tourelistobj.Date =item.DetailId //tarikhe tour ro az koja bayad gereft ??
                    tourelistobj.CategoryId = item.CategoryId;
                    tourelistobj.GalleryId = item.GalleryId;
                    tourelistobj.DetailId = item.DetailId;
                    tourelistobj.Cost = item.Cost;
                    tourelistobj.PhoneNumber = item.PhoneNumber;
                    tourelinklistobj.Add(tourelistobj);
                }
                return tourelinklistobj;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return tourelinklistobj;
            }
        }
        [HttpGet]
        [Route("ShopList")]
        public List<ShopViewModel> ShopList()
        {
            ShopViewModel shopListobj = new ShopViewModel();
            List<ShopViewModel> shopLinkListobj = new List<ShopViewModel>();
            try
            {
                var listShop = _place.PlacesShopId();
                foreach (var item in listShop)
                {
                    shopListobj.Name = item.Name;
                    shopListobj.Address = _address.FindById(item.Adress).Detail;
                    shopListobj.CategoryId = item.CategoryId;
                    foreach (var items in _gallery.ListImage(item.GalleryId))
                    {
                        shopListobj.Imagelist.Add(items.Url);
                    }
                    shopListobj.DetailId = item.DetailId;
                    shopListobj.LocationX = _address.FindById(item.Adress).LocationX;
                    shopListobj.LocationY = _address.FindById(item.Adress).LocationY;
                    shopListobj.LocationR = _address.FindById(item.Adress).LocationR;
                    shopListobj.PhoneNumber = item.PhoneNumber;
                    shopLinkListobj.Add(shopListobj);
                }
                     return shopLinkListobj;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return shopLinkListobj;
            }
        }
    }
}
