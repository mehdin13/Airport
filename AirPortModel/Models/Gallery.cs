﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Gallery")]
    public class Gallery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("GalleryId")]
        public int Id { get; set; }
        [NotNull]
        [StringLength(50)]
        [Column("GalleryName")]
        public string Name { get; set; }
    }
}
