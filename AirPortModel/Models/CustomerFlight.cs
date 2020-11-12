using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_CustomerFlight")]
    public class CustomerFlight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CustomerFlightId")]
        public int id { get; set; }
        //****************foreignKey CusttomerID*************
        [ForeignKey("CustomerId")]
        [Required]
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        //*****************end ForeignKey*********************
        //*****************ForeignKey FlightId****************
        [ForeignKey("FlightId")]
        [Required]
        [Column("FlightId")]
        public int FlightId { get; set; }
        public Flight Flights { get; set; }
        //************* End Foreignkey FlightId****************
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
