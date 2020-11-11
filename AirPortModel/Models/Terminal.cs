using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Terminal")]
    public class Terminal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TerminalId")]
        public int Id { get; set; }
        [StringLength(50)]
        [Column("TerminalName")]
        public string Name { get; set; }
        //Url 
        [Column("TerminalImage")]
        public string Image { get; set; }
        //foriegen Key
        [ForeignKey("AirPort")]
        [Required]
        [Column("AirPortId")]
        public int AirPortId { get; set; }
        public AirPort AirPort { get; set; }
        //**End 

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
