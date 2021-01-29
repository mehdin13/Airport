using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPort.Model.ViewModel
{
    public class FaqViewModel
    {
        public int FaqType { get; set; }
        public string Title { get; set; }   
        public string Description { get; set; }
    }
    public class JsonFaq
    {
        public List<FaqViewModel> Result { get; set; }
    }
}
