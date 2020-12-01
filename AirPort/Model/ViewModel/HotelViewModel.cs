using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class HotelViewModel
    {
        public string Name { get; set; }
        public int AddresId { get; set; }
        public int CategoryId { get; set; }
        public int GalleryId { get; set; }
        public int DetailId { get; set; }
        public double Cost { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationR { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class ShopViewModel
    {
        public string Name { get; set; }
        public int AddresId { get; set; }
        public int CategoryId { get; set; }
        public int GalleryId { get; set; }
        public int DetailId { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationR { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class CofeeShopViewModel
    {
        public string Name { get; set; }
        public int AddresId { get; set; }
        public int CategoryId { get; set; }
        public int GalleryId { get; set; }
        public int DetailId { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationR { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class RestaurantViewModel
    {
        public string Name { get; set; }
        public int AddresId { get; set; }
        public int CategoryId { get; set; }
        public int GalleryId { get; set; }
        public int DetailId { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationR { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class ToursViewModel
    {
        public string Name { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public int GalleryId { get; set; }
        public int DetailId { get; set; }
        public double Cost { get; set; }
        public string PhoneNumber { get; set; }
    }
}
//eghamatgah nadarim ? toye XD 
