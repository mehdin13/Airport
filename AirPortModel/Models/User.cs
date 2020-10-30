using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("UserId")]
        public int Id { get; set; }
        [StringLength(50)]
        [Column("UserName")]
        public string Name { get; set; }
        //Foreign Key 
        [ForeignKey("Customer")]
        [Required]
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        //****End 
    }
}
