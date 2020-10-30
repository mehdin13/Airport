using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    }
}
