﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirPortModel.Models
{
    class State
    {
        [Key]
        public int StateId { get; set; }
        [Required]
        [StringLength(50)]
        public string StateName { get; set; }
    }
}