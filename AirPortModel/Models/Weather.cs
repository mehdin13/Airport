using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Weather")]
    public class Weather
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("WeatherId")]
        public int Id { get; set; }
        [Required]
        [Column("TypeId")]
        public int TypeId { get; set; }
        [Required]
        [Column("Temperature")]

        public int Temperature { get; set; }

        //********foreigen key ******************
        [ForeignKey("AirportId")]
        [Column("AirportId")]
        public int airportid { get; set; }
        public AirPort AirPort { get; set; }
        //***********End Foreigne Key***********

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
