using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Flight")]
   public class Flight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FlightId")]
        public int Id { get; set; }
        //foriegn key 
        [ForeignKey("AirPlane")]
        [AllowNull]
        [Column("FlightAirPlaneId")]
        public int FlightAirPlaneId { get; set; }
        public AirPlane AirPlane { get; set; }
        // End
        //foreign Key 
        [ForeignKey("AirPort")]
        [Required]
        [Column("AirPortId")]
        public int AirPortId { get; set; }
        public AirPort AirPort { get; set; }
        //end key 
        [Required]
        [DataType(DataType.Time)]
        [Column("FlightTime")]
        public DateTime Time { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column("FlighttDate")]
        public DateTime Date { get; set; }
        //foreignKey
        [ForeignKey("FlightStatus")]
        [Column("FlightstatusId")]
        [Required]
        public int FlightstatusId { get; set; }
        public FlightStatus FlightStatus { get; set; }
        //** End 
        //foreign Key 
        [ForeignKey("StartAirPortId")]
        [Required]
        [Column("StartAirPortId")]
        public int StartAirPortId { get; set; }
        public AirPort StartAirPort { get; set; }
        //end
        //foreign Key
        [ForeignKey("EndAirport")]
        [Required]
        [Column("FlightEndAirportId")]
        public int FlightEndAirportId { get; set; }
        public AirPort EndAirport { get; set; }

        //end
        //foregn key
        [ForeignKey("Gate")]
        [Required]
        [Column("FlightGateId")]
        public int GateId { get; set; }
        public Gate Gate { get; set; }
        //End
        //check shavad dobare 
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy-mm-dd-hh:mm tt}")]
        [Column("FlightStartTimeDate")]
        public DateTime StartTimeDate { get; set; }
        //*******************New Feald********************
        [Column("FlightNumber")]
        [Required]
        public int Number { get; set; }

        [Column("FlightDelay")]
        [Required]
        [DataType(DataType.Time)]
        public DateTime Delay { get; set; }
        //********************End of New Feald*************
        [Required]
        [DataType(DataType.DateTime)]
        //check shavad dobare
        [DisplayFormat(DataFormatString ="{0:yyyy-mm-dd-hh:mm tt}")]
        [Column("FlightEndTimeDate")]
        public DateTime EndTimeDate { get; set; }

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

        public virtual ICollection<CustomerFlight> CustomerFlights { get; set; }
    }
}
