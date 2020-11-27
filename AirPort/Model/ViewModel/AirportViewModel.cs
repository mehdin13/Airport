﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirPort.Model.ViewModel
{
    public class AirportViewModel
    {
        public string Name { get; set; }
        public int AirportId { get; set; }
        public string GalleryId { get; set; }
        public string AirportCode { get; set; }
        public string Abbreviation { get; set; }
    }
}