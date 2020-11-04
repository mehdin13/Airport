using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column("CityId")]
        public int CityId { get; set; }
    }
}
