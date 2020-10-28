using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace AirPortModel.Models
{
    class DetailValue
    {
        [Key]
        public int ValueId { get; set; }

        public int DetailId { get; set; }

        public int FeacherId { get; set; }

        public string Value { get; set; }
    }
}
