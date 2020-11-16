using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_City")]
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CityId")]
        public int Id { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="the City Name Must Be Les Than 50 character")]
        [Column("CityName")]
        public string Name { get; set; }
        //foriegen Key ? 
        [ForeignKey("state")]
        [Required]
        [Column("CityStateId")]
        public int CityStateId { get; set; }
        public State state { get; set; }

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
        public List<Address> Addresses { get; set; }
    }
}
