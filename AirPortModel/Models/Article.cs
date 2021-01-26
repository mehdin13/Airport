using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AirPortModel.Models
{
    [Table("Tbl_Article")]
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("Title")]
        public string Title { get; set; }
        [Required]
        [Column("Description")]
        public string Description { get; set; }
        //****************new foreignKey**************
        [ForeignKey("Gallery")]
        [Column("GalleryId")]
        public int GalleryId { get; set; }
        public Gallery gallery { get; set; }
        //***************End ForeignKey****************
        [Required]
        [DataType(DataType.DateTime)]
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
