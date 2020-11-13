using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Detail")]
     public class Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("DetailId")]
        public int Id { get; set; }
        //foreign Key 
        [ForeignKey("TypeDetail")]
        [Required]
        [Column("TypeDetailId")]
        public int TypeId { get; set; }
        public TypeDetail TypeDetail { get; set; }
        //***end Key
        //*********************new Feald *****************************
        [Column("DetailRating")]
        public double Rating { get; set; }

        //********************end New Feald **************************
        [Column("DetailValue")]
        public int Value { get; set; }

        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("DateCreate")]
        public DateTime DateCrate { get; set; }
        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("LastUpdateDate")]
        public DateTime LastUpdate { get; set; }
        [Column("IsDelete")]
        public bool IsDelete { get; set; }
    }
}
