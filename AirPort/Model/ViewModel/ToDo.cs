using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class ToDo
    {
        public string Title { get; set; }
        public string Fly { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool isdon { get; set; }
    }
}
