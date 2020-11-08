using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Entertainment")]
    public class Entertainment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("EntertainmentId")]
        public int Id { get; set; }
        [Column("Type")]
        public int Type { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [ForeignKey("LinkId")]
        [Column("LinkId")]
        public int LId { get; set; }
        public Links LinkIds { get; set; }
        [Column("Gallery")]
        public string Gallery { get; set; }
        [StringLength(50)]
        [Column("Title")]
        public string Title { get; set; }
    }
}
