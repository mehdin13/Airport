using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class InstituteViewModel
    {
        public string Logo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string WebUrl { get; set; }
        public string Phone { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationR { get; set; }
        public string AddressId { get; set; }
        public string GalleryId { get; set; }
        public int CatagoriId { get; set; }
    }
    public class JsonInstitute
    {
        public List<InstituteViewModel> Result { get; set; }
    }
}
