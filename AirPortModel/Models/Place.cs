using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortModel.Models
{
    class Place
    {
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }
        public string PlaceAdress { get; set; }
        public int PlaceCategoryId { get; set; }
        public int PlaceGalleryId { get; set; }
        public int PlaceDetailId { get; set; }
        public bool PlaceIsactive { get; set; }
        public string PlaceCustomer { get; set; }
    }
}
