using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPortModel.Models
{
    [Table("Tbl_Adress")]
    public class Adress
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AdressId")]
        public int Id { get; set; }
        [Required]
        [StringLength(256)]
        [Column("AdressDetail")]
        public string Detail { get; set; }
        //data type nemikhad :D 
        [Column("AdressLocationX")]
        public double LocationX { get; set; }
        [Column("AdressLocationY")]
        public double LocationY { get; set; }
        [Column("AdressLocationR")]
        public double LocationR { get; set; }
        //Foreign Key 
        [ForeignKey("City")]
        [Required]
        [Column("AdressCityId")]
        public int CityId { get; set; }
        public City City { get; set; }

    }
}
