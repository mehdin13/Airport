using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_type")]
    public class Type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TypeId")]
        public int Id { get; set; }
        
        [Required]
        [Column("TypeName")]
        public string Name { get; set; }
        
        [Required]
        [Column("TypeIcon")]
        public string Icon { get; set; }
    }
}
