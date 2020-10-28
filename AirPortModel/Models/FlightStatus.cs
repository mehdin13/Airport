using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPortModel.Models
{
    class FlightStatus
    {
        [Key]
        public int FlightStatusId { get; set; }
        [Required]
        [StringLength(255)]
        public string FlightStatusType { get; set; }
    }
}
