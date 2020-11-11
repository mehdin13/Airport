using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
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
        [Column("Password")]
        [StringLength(15)]
        public string Password { get; set; }
        [Column("IsActive")]
        public bool IsActive { get; set; }
        [Column("IsDelete")]
        public bool IsDelete { get; set; }

        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("DateCreate")]
        public DateTime DateCrate { get; set; }
        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("LastUpdateDate")]
        public int LastUpdate { get; set; }
    }
}
