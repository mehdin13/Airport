using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AirPortModel.Models
{
    class Detail
    {
        [Key]
        public int DetailId { get; set; }

        public int TypeId { get; set; }

        public int DetailValue { get; set; }
    }
}
