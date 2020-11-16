using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Feature")]
    public class Featrue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FeatrueId")]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column("FeatrueName")]
        public string Name { get; set; }
        //foreign key
        [ForeignKey("typeDetail")]
        [Required]
        [Column("TypeDetailId")]
        public int TypeId { get; set; }
        public TypeDetail typeDetail { get; set; }


        [Column("FeatrueIcon")]
        public string Icon { get; set; }


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
    }
}
