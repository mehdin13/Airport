using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class EntertainmentViewModel
    {
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string LinkId { get; set; }
        public int Galleryid { get; set; }
        public string Title { get; set; }
    }
}
