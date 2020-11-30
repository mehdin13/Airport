using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class NewsViewModel
    {
        public int LinkId { get; set; } //Enterteinment
        public string Title { get; set; }
        public string Icon { get; set; }
    }
}
