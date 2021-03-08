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
        public string LocationX { get; set; }
        public string LocationY { get; set; }
        public string LocationR { get; set; }
        public string AddressId { get; set; }
        public string GalleryId { get; set; }
        public int CatagoriId { get; set; }
    }
    public class JsonInstitute
    {
        public List<InstituteViewModel> Result { get; set; }
    }
}
