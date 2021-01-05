using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class LinkViewModel
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string UrL { get; set; }
    }
    public class JsonApplication
    {
        public List<LinkViewModel> Result { get; set; }
    }
}
