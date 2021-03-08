using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AirPortModel.Models
{
    [Table("Tbl_Adress")]
    public class Address
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AdressId")]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Column("AdressDetail")]
        public string Detail { get; set; }
        [Column("AdressLocationX")]
        public string LocationX { get; set; }
        [Column("AdressLocationY")]
        public string LocationY { get; set; }
        [Column("AdressLocationR")]
        public string LocationR { get; set; }
        //Foreign Key 
        [ForeignKey("City")]
        [Required]
        [Column("AdressCityId")]
        public int CityId { get; set; }
        public City City { get; set; }
        //end foriegn key
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

        public List<AirPort> airPorts { get; set; }
        public List<Customer> customers { get; set; }
        public List<Place> places { get; set; }


    }
}
