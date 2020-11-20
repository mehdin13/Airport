using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("FlightToDo")]
     public class FlightToDo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FlightToDoId")]
        public int id { get; set; }

        [StringLength(50)]
        [AllowNull]
        [Column("Name")]
        public string Name { get; set; }

        [ForeignKey("CustomerId")]
        [Required]
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }

        [Column("Title")]
        public string Title { get; set; }
        //**************foreign key**************
        [ForeignKey("flight")]
        [Column("FlightId")]
        public int FlightId { get; set; }
        public Flight flight { get; set; }
        //************end Foreign key************
        [StringLength(255)]
        [Column("Descriptions")]
        public string Description { get; set; }
        [Column("IsDon")]
        public bool IsDon { get; set; }
        //Need to Return 0 and 1 

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
