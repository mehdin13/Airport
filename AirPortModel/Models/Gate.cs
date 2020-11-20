using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Gate")]
    public class Gate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("GateId")]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        [Column("GetName")]
        public string Name { get; set; }
        //****************foreigan key****************
        [ForeignKey("Terminal")]
        [Column("GateTerminal")]
        public string Terminal { get; set; }
        public Terminal terminal { get; set; }
        //*******************End *********************

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
