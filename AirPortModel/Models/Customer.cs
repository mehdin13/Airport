﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CustomerId")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Column("CustomerName")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [Column("CustomerLastName")]
        public string LastName { get; set; }

        [StringLength(255)]
        [Column("CustomerAdress")]
        public string Adress { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-mm-dd}")]
        [Column("CustomerBDate")]
        public DateTime BDate { get; set; }
        //jensiat Sex New input 
        [Required]
        [NotNull]
        [Column("CustomerSex")]
        public bool Sex { get; set; }

        [Required]
        [StringLength(12)]
        [Column("CustomerMobile")]
        public string Mobile { get; set; }

        [Column("CustomerProfileImage")]
        public string ProfileImage { get; set; }

        [DataType(DataType.Password)]
        [DisplayName(displayName:"System Password")]
        [Column("CustomerPassword")]
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)]
        [DisplayName(displayName:"Emal Address")]
        [Column("CustomerEmail")]
        public string Email { get; set; }
        //Hmmm :D
        [Column("Isactive")]
        public bool Isactive { get; set; }
        [Column("Isdelete")]
        public bool Isdelete { get; set; }

    }
}
