using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("TypeDetail")]
        [Required]
        [Column("TypeDetailId")]
        public int TypeId { get; set; }
        public TypeDetail TypeDetail { get; set; }


        [Column("FeatrueIcon")]
        public string Icon { get; set; }
    }
}
