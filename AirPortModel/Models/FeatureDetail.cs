﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPortModel.Models
{
    class FeatureDetail
    {
        [Key]
        public int FdId { get; set; }
        
        public int DetailId { get; set; }
        public int FeatureId { get; set; }
        [StringLength(50)]
        public string Value { get; set; }
    }
}