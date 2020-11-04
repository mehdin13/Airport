using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_AirPort")]
    public class AirPort
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AirPortId")]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Air Port Name Must Be 50 charachter")]
        [Column("AirPortName")]
        public string Name { get; set; }

        //foreign key :D
        [ForeignKey("Adress")]
        [Required]
        [Column("AirPortAddressId")]
        public int AirPortAddressId { get; set; }
        public Adress Adress { get; set; }

        [Column("MapImageUrl")]
        public string Url { get; set; }

        //foreign Key 
        [ForeignKey("Gallery")]
        [Required]
        [Column("GalleryId")]
        public int GalleryId { get; set; }
        public Gallery Gallery { get; set; }
        //end
        // ***************************new Feald****************
        [Column("AirPortCode")]
        public int Code { get; set; }
        //***************************End New Feald ************

        [StringLength(255)]
        [Column("Detail")]
        public string Detail { get; set; }
    }
}
