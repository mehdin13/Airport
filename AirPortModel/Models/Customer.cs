using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPortModel.Models
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerAdress { get; set; }

        [DataType(DataType.Date)]
        public DateTime CustomerBDate { get; set; }

        public string CustomerMobile { get; set; }
        public string ProfileImage { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerEmail { get; set; }
        public bool Isactive { get; set; }
        public bool Isdelete { get; set; }

    }
}
