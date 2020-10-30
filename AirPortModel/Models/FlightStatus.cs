using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_FlightStatus")]
    public class FlightStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FlightStatusId")]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Column("FlightStatusType")]
        public string StatusType { get; set; }
    }
}
