using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPortModel.Models
{
    public class AirPort
    {
        [Key]
        public int AirPortId { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="Air Port Name Must Be 50 charachter")]
        public string AirPortName { get; set; }

        public int AirPortAddressId { get; set; }
        public string MapImageUrl { get; set; }
        public int GalleryId { get; set; }
        [StringLength(255)]
        public string Detail { get; set; }
    }
}
