using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortModel.Models
{
    public class AirPort
    {
        public int AirPortId { get; set; }
        public string AirPortName { get; set; }
        public int AirPortAddressId { get; set; }
        public string MapImageUrl { get; set; }
        public int GalleryId { get; set; }
        public int Detail { get; set; }
    }
}
