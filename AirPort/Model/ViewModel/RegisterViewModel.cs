using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class LoginViewModel
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class ProfileViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public string Mobile { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Sex { get; set; }
        [DataType(DataType.Date)]
        public DateTime Bdate { get; set; }
    }
}
