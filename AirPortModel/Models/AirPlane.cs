using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPortModel.Models
{
    class AirPlane
    {
        [Key]
        public int AirPlaneId { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="AirPlane Name must be les than 50 character")]
        public string AirPlaneName { get; set; }
        public int AirPlaneGalleryId { get; set; }
        public int AirlineId { get; set; }
        public int DetailId { get; set; }
    }
}
