using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Brand")]
   public class Brand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("BrandId")]
        public int Id { get; set; }

        [Column("BrandName")]
        public string BrandName { get; set; }
        [Column("BrandIcon")]
        public string BrandIcon { get; set; }


    }
}
