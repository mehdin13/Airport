using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AirPortModel.Models
{
    [Table("Tbl_AirLine")]
    public class Airline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AirlineId")]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Airline Name Can Not Be Longer than 50 character")]
        [Column("AirlineName")]
        public string Name { get; set; }
        //*******************foreign Key***********************
        [ForeignKey("Detail")]
        [Required]
        [Column("AirlineDetailId")]
        public int DetailId { get; set; }
        public Detail Detail { get; set; }
        //*************end Deatail Foreign Kay******************
        [Column("AirlineLogo")]
        public string Logo { get; set; }

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
        public List<AirPlane> airPlanes { get; set; }
    }
}
