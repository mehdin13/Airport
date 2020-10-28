using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPortModel.Models
{
    class Adress
    {
        [Key]
        public int AdressId { get; set; }
        [Required]
        [StringLength(256)]
        public string AdressDetail { get; set; }
        //data type nemikhad :D 
        public double AdressLocationX { get; set; }
        public double AdressLocationY { get; set; }
        public double AdressLocationR { get; set; }
       // [ForeignKey("AdressCityId")]
        public int AdressCityId { get; set; }

    }
}
