using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    class Place
    {
        [Key]
        public int PlaceId { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="Place Name Must Be Less than 50 character")]
        public string PlaceName { get; set; }

        [NotNull]
        [StringLength(255,ErrorMessage ="Adress Must be Less than 255 character")]
        public string PlaceAdress { get; set; }

        public int PlaceCategoryId { get; set; }
        public int PlaceGalleryId { get; set; }
        public int PlaceDetailId { get; set; }
        [NotNull]
        public bool PlaceIsactive { get; set; }
        //**************************************check shavad dobare ***************************
        [StringLength(50)]
        public string PlaceCustomer { get; set; }
    }
}
