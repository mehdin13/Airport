using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPortModel.Models
{
    class City
    {
        [Key]
        public int CityId { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="the City Name Must Be Les Than 50 character")]
        public string CityName { get; set; }
        public int CityStateId { get; set; }
    }
}
