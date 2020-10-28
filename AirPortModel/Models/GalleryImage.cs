using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    class GalleryImage
    {
        [Key]
        public int ImageId { get; set; }
        [NotNull]
        public string ImageUrl { get; set; }
        //foreigen key 
        public int GalleryId { get; set; }
    }
}
