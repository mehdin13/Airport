using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
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
        [StringLength(50, ErrorMessage = "Air Port Name Must Be at least 50 charachter")]
        [Column("AirPortName")]
        public string Name { get; set; }

        //foreign key :D
        [ForeignKey("Adress")]
        [Required]
        [Column("AirPortAddressId")]
        public int AirPortAddressId { get; set; }
        public Address Adress { get; set; }
        //end foreign Key :D
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
        //Abbreviation == ekhtesari 
        [StringLength(10)]
        [Column("AirAbbreviation")]
        public string Abbreviation { get; set; }

        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("DateCreate")]
        public DateTime DateCrate { get; set; }
        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("LastUpdateDate")]
        public DateTime LastUpdate { get; set; }
        [Column("IsDelete")]
        public bool IsDelete { get; set; }
        //One too many
        public List<Terminal> Terminals { get; set; }
        //end on to many
    }
}
