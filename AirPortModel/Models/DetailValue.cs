using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_DetailValue")]
    public class DetailValue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ValueId")]
        public int Id { get; set; }
        ////******************foreign key **********************
        [ForeignKey("Detail")]
        [Required]
        [Column("DetailId")]
        public int DetailId { get; set; }
        public Detail Detail { get; set; }
        //***********end Key*********************
        //*************************foreign Key**************** 
        [ForeignKey("Featrue")]
        [Required]
        [Column("FeatrueId")]
        public int FeacherId { get; set; }
        public Featrue Featrue { get; set; }
        //*************************end Key********************
        [Column("Value")]
        public string Value { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        [Column("DateCreate")]
        public DateTime DateCreate { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        [Column("LastUpdateDate")]
        public DateTime LastUpdate { get; set; }
        [Column("IsDelete")]
        [Required]
        public bool IsDelete { get; set; }
    }
}
