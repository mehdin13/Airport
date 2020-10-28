using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPortModel.Models
{
    class Feature
    {
        [Key]
        public int FeatureId { get; set; }
        [StringLength(50)]
        public string FeatureName { get; set; }
    }
}
