using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Column("Type")]
        public int Type { get; set; } //check shavad

        [Column("Icon")]
        public string Icon { get; set; }

    }
}
