using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
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
        private readonly ICategory _category;
        public HotelController(IPlace place, IAddress address, IDetail detail, IGallery gallery, ICategory category)
        {
            _gallery = gallery;
            _address = address;
            _place = place;
            _detail = detail;
            _category = category;
        }
        [HttpGet]
        [Route("HotelList")]
        public JsonHotel HotelList()
        {
            JsonHotel jsonHotel = new JsonHotel();
            HotelViewModel Hotellistobj = new HotelViewModel();
            List<HotelViewModel> hotellinklistobj = new List<HotelViewModel>();
            try
            {
                var listHotell = _place.PlaceHotellList();
                foreach (var item in listHotell)
                {
                    Hotellistobj.Name = item.Name;
                    Hotellistobj.Address = _address.FindById(item.AdressId).Detail;
                    Hotellistobj.CategoryId = item.CategoryId;
                    Hotellistobj.DetailId = item.DetailId;
                    Hotellistobj.Cost = item.Cost;
                    Hotellistobj.LocationX = _address.FindById(item.AdressId).LocationX;
                    Hotellistobj.LocationY = _address.FindById(item.AdressId).LocationY;
                    Hotellistobj.LocationR = _address.FindById(item.AdressId).LocationR;
                    Hotellistobj.PhoneNumber = item.PhoneNumber;
                    hotellinklistobj.Add(Hotellistobj);
                }
                jsonHotel.result = hotellinklistobj;
                return jsonHotel;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return jsonHotel;
            }
        }
        [HttpGet]
        [Route("RestaurantList")]
        public JsonRestaurant RestaurantTolist()
        {
            JsonRestaurant jsonRestaurant = new JsonRestaurant();
            RestaurantViewModel RestaurantListobj = new RestaurantViewModel();
            List<RestaurantViewModel> RestaurantlinkListobj = new List<RestaurantViewModel>();
            try
            {
                var ListRestaurant = _place.PlaceRestaurantid();
                foreach (var item in ListRestaurant)
                {
                    RestaurantListobj.Name = item.Name;
                    RestaurantListobj.CategoryId = _category.FindById(item.CategoryId).Id;
                    RestaurantListobj.GalleryId = item.GalleryId;
                    RestaurantListobj.DetailId = _detail.FindById(item.DetailId).Id;
                    RestaurantListobj.LocationX = _address.FindById(item.AdressId).LocationX;
                    RestaurantListobj.LocationY = _address.FindById(item.AdressId).LocationY;
                    RestaurantListobj.LocationR = _address.FindById(item.AdressId).LocationR;
                    RestaurantListobj.PhoneNumber = item.PhoneNumber;
                    RestaurantlinkListobj.Add(RestaurantListobj);
                }
                jsonRestaurant.result = RestaurantlinkListobj;
                return jsonRestaurant;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return jsonRestaurant;
            }
        }
        [HttpGet]
        [Route("CofeeshopList")]
        public JsonCofeeshop CofeeshopTolist()
        {
            JsonCofeeshop jsonCofeeshop = new JsonCofeeshop();
            CofeeShopViewModel RestaurantListobj = new CofeeShopViewModel();
            List<CofeeShopViewModel> RestaurantlinkListobj = new List<CofeeShopViewModel>();
            try
            {
                var ListRestaurant = _place.PlacesCofeeshopId();
                foreach (var item in ListRestaurant)
                {
                    RestaurantListobj.Name = item.Name;
                    RestaurantListobj.CategoryId = _category.FindById(item.CategoryId).Id;
                    RestaurantListobj.GalleryId = item.GalleryId;
                    RestaurantListobj.DetailId = _detail.FindById(item.DetailId).Id;
                    RestaurantListobj.LocationX = _address.FindById(item.AdressId).LocationX;
                    RestaurantListobj.LocationY = _address.FindById(item.AdressId).LocationY;
                    RestaurantListobj.LocationR = _address.FindById(item.AdressId).LocationR;
                    RestaurantListobj.PhoneNumber = item.PhoneNumber;
                    RestaurantlinkListobj.Add(RestaurantListobj);
                }
                jsonCofeeshop.result = RestaurantlinkListobj;
                return jsonCofeeshop;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return jsonCofeeshop;
            }
        }

        [HttpGet]
        [Route("ToureList")]
        public JsonTours ToureList()
        {
            JsonTours jsonTours = new JsonTours();
            List<ToursViewModel> tourelinklistobj = new List<ToursViewModel>();
            try
            {
                var ListToure = _place.PlaceToureId();
                foreach (var item in ListToure)
                {
                    ToursViewModel tourelistobj = new ToursViewModel();
                    tourelistobj.Name = item.Name;
                    tourelistobj.Date = item.DateCreate;
                    tourelistobj.CategoryId = item.CategoryId;
                    tourelistobj.GalleryId = item.GalleryId;
                    tourelistobj.DetailId = item.DetailId;
                    tourelistobj.Cost = item.Cost;
                    tourelistobj.PhoneNumber = item.PhoneNumber;
                    tourelinklistobj.Add(tourelistobj);
                }
                jsonTours.result = tourelinklistobj;
                return jsonTours;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return jsonTours;
            }
        }
        [HttpGet]
        [Route("ShopList")]
        public JsonShop ShopList()
        {
            JsonShop jsonShop = new JsonShop();
            ShopViewModel shopListobj = new ShopViewModel();
            List<string> urllist = new List<string>();
            List<ShopViewModel> shopLinkListobj = new List<ShopViewModel>();
            try
            {
                var listShop = _place.PlacesShopId();
                foreach (var item in listShop)
                {
                    shopListobj.Name = item.Name;
                    shopListobj.Address = _address.FindById(item.AdressId).Detail;
                    shopListobj.CategoryId = item.CategoryId;
                    var imagees = _gallery.ListImage(item.GalleryId);
                    if (imagees != null)
                    {
                        foreach (var items in imagees)
                        {
                            urllist.Add(items.Url);
                            shopListobj.Imagelist = urllist;
                        }
                    }
                    shopListobj.DetailId = item.DetailId;
                    shopListobj.LocationX = _address.FindById(item.AdressId).LocationX;
                    shopListobj.LocationY = _address.FindById(item.AdressId).LocationY;
                    shopListobj.LocationR = _address.FindById(item.AdressId).LocationR;
                    shopListobj.PhoneNumber = item.PhoneNumber;
                    shopLinkListobj.Add(shopListobj);
                }
                jsonShop.result = shopLinkListobj;
                return jsonShop;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return jsonShop;
            }
        }
    }
}
