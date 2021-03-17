using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPort.Model.ViewModel
{
    public class Requests
    {
        public string title { get; set; }
        public string Description { get; set; }
    }
    public class JsonRequest
    {
        public List<Requests> Result { get; set; }
    }

}
