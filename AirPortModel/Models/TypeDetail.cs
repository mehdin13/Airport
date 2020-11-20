using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_TypeDetail")]
    public class TypeDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TypeDetailId")]
        public int Id { get; set; }

        [StringLength(50)]
        [Column("TypeDetailName")]
        public string Name { get; set; }

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
        public List<Featrue> featrues { get; set; }
    }
}
