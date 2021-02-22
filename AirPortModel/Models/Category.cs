using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CategoryId")]
        public int Id { get; set; }// kelide dakheli
        [StringLength(50)]
        public string CategoryName { get; set; }//name daste bandi
        public string Icon { get; set; }

        [Required]
        [Column("CategoryType")]
        public int CategoryType { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        [Column("DateCreate")]
        public DateTime DateCreate { get; set; }//tarikhe tolid
        [DataType(DataType.DateTime)]
        [Required]
        [Column("LastUpdateDate")]
        public DateTime LastUpdate { get; set; }//tarikhe akharin berooz resani
        [Required]
        [Column("IsDelete")]
        public bool IsDelete { get; set; }//delete shode ast ya na :((

        public List<Links> links { get; set; }//ertebat
        public List<Place> places { get; set; }//ertebat
    }
}
