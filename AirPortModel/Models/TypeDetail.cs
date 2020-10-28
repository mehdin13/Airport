using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPortModel.Models
{
    class TypeDetail
    {
        [Key]
        public int TypeDetailId { get; set; }

        [StringLength(50)]
        public string TypeDetailName { get; set; }
    }
}
