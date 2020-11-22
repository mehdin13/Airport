using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

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

        //***************** foreign Key***************
        [ForeignKey("CustomerAdress")]
        [Column("CustomerAdress")]
        public int Adress { get; set; }
        public Address address { get; set; }
        //***************End Foreign Key**************

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-mm-dd}")]
        [Column("CustomerBDate")]
        public DateTime BDate { get; set; }
        //jensiat:Sex New input 
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
        [Required]
        [DataType(DataType.Password)]
        [DisplayName(displayName:"Password")]
        [Column("CustomerPassword")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName(displayName:"Emal Address")]
        [Column("CustomerEmail")]
        public string Email { get; set; }
        //Hmmm :D
        [Required]
        [Column("Isactive")]
        public bool Isactive { get; set; }
        [Required]
        [Column("Isdelete")]
        public bool IsDelete { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        [Column("DateCreate")]
        public DateTime DateCreate { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        [Column("LastUpdateDate")]
        public DateTime LastUpdate { get; set; }
        public List<Request> requests { get; set; }
        public List<Place> places { get; set; }
        public List<User> users { get; set; }
        public List<FlightToDo> flightToDos { get; set; }
        public virtual ICollection<CustomerFlight> CustomerFlights { get; set; }
    }
}
