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
        public string Code { get; set; }
        //***************************End New Feald ************
        //Abbreviation == ekhtesari 
        [StringLength(10)]
        [Column("AirPortAbbreviation")]
        public string Abbreviation { get; set; }

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
        //One too many
        public List<Terminal> Terminals { get; set; }
        public List<Weather> weathers { get; set; }
        public List<Place> places { get; set; }
        //end on to many
    }
}
