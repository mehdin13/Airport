using System;
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

        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("DateCreate")]
        public DateTime DateCreate { get; set; }
        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("LastUpdateDate")]
        public DateTime LastUpdate { get; set; }
        [Column("IsDelete")]
        public bool IsDelete { get; set; }

        //one to many 

        public List<GalleryImage> galleryImages { get; set; }
        public List<AirPlane> airPlanes { get; set; }
        public List<Place> places { get; set; }
        //end one to many 
    }
}
