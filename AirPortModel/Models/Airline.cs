using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace AirPortModel.Models
{
    class Airline
    {
        [Key]
        public int AirlineId { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="Airline name can not be longer than 50 character")]
        public string AirlineName { get; set; }

        public string AirlineDetailId { get; set; }

        public string AirlineLogo { get; set; }
    }
}
