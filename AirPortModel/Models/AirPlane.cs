using System;
using System.Collections.Generic;
using System.Text;

namespace AirPortModel.Models
{
    class AirPlane
    {
        public int AirPlaneId { get; set; }
        public string AirPlaneName { get; set; }
        public int AirPlaneGalleryId { get; set; }
        public int AirlineId { get; set; }
        public int DetailId { get; set; }
    }
}
