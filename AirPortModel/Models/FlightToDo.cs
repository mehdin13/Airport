using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("FlightToDo")]
    class FlightToDo
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

        [Column("IsDon")]
        public bool IsDon { get; set; }
        //Need to Return 0 and 1 

        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("DateCreate")]
        public DateTime DateCrate { get; set; }
        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("LastUpdateDate")]
        public int LastUpdate { get; set; }
        [Column("IsDelete")]
        public bool IsDelete { get; set; }
    }
}
