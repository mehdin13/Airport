using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    class Gallery
    {
        [Key]
        public int GalleryId { get; set; }
        [NotNull]
        [StringLength(50)]
        public string GalleryName { get; set; }
    }
}
