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
        [Column("DetailRating")]
        public double Rating { get; set; }

        [Column("DetailValue")]
        public int Value { get; set; }

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

        public List<Airline> airlines { get; set; }
        public List<AirPort> airPorts { get; set; }
        public List<AirPlane> airPlanes { get; set; }
        public List<DetailValue> detailValues { get; set; }


    }
}
