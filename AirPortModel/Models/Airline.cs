using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_AirLine")]
    public class Airline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AirlineId")]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Airline Name Can Not Be Longer than 50 character")]
        [Column("AirlineName")]
        public string Name { get; set; }
        //foreign Key
        [ForeignKey("Detail")]
        [Required]
        [Column("AirlineDetailId")]
        public int DetailId { get; set; }
        public Detail Detail { get; set; }

        [Column("AirlineLogo")]
        public string Logo { get; set; }
    }
}
