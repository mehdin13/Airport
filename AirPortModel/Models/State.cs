using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_State")]
    public class State
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("StateId")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Column("StateName")]
        public string Name { get; set; }
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
        public List<City> Cities { get; set; }
    }
}
