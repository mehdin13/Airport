using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Links")]
    public class Links
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("LinkId")]
        public int Id { get; set; }
        [StringLength(50)]

        [Column("Title")]
        public string Title { get; set; }

        [Column("Url")]
        public string Url { get; set; }

        [Column("Type")]
        public int Type { get; set; } 

        [Column("Icon")]
        public string Icon { get; set; }

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

        public List<Entertainment> entertainments { get; set; }

    }
}
