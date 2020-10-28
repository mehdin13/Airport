using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPortModel.Models
{
    class Feacher
    {
        [Key]
        public int FeacherId { get; set; }
        [Required]
        [StringLength(50)]
        public string FeacherName { get; set; }
        public int TypeId { get; set; }
        public string FeacherIcon { get; set; }
    }
}
