using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportWebRazor.Model.ViewMode
{
    public class AccountViewModel
    {

    }
    public class LoginViewModel
    {
        public string Name { get; set; }
        public string PassWord { get; set; }
        public bool RememberMe { get; set; }
    }
}
