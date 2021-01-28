using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class PadcastViewModel
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
    }
    public class JsonPadcast
    {
        public List<PadcastViewModel> Result { get; set; }
    }
}
