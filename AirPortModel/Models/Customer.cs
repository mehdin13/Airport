using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerLastName { get; set; }

        [StringLength(255)]
        public string CustomerAdress { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-mm-dd}")]
        public DateTime CustomerBDate { get; set; }
        //jensiat Sex New input 
        [Required]
        [NotNull]
        public bool CustomerSex { get; set; }

        [Required]
        [StringLength(12)]
        public string CustomerMobile { get; set; }

        public string CustomerProfileImage { get; set; }

        [DataType(DataType.Password)]
        [DisplayName(displayName:"System Password")]
        public string CustomerPassword { get; set; }

        [DataType(DataType.EmailAddress)]
        [DisplayName(displayName:"Emal Address")]
        public string CustomerEmail { get; set; }
        //Hmmm :D
        public bool Isactive { get; set; }
        public bool Isdelete { get; set; }

    }
}
