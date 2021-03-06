using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_GalleryImage")]
    public class GalleryImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("GalleryImageId")]
        public int Id { get; set; }
        [NotNull]
        [Column("ImageUrl")]
        public string Url { get; set; }
        //foreigen key 
        [ForeignKey("Gallery")]
        [Required]
        [Column("GalleryId")]
        public int GalleryId { get; set; }
        public Gallery Gallery { get; set; }
        //End 

        [DataType(DataType.DateTime)]
        [Required]
        [Column("DateCreate")]
        public DateTime DateCreate { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        [Column("LastUpdateDate")]
        public DateTime LastUpdate { get; set; }
        [Required]
        [Column("IsDelete")]
        public bool IsDelete { get; set; }

    }
}
