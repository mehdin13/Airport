﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_AirPlane")]
    public class AirPlane
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AirPlaneId")]
        public int Id { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="AirPlane Name must be les than 50 character")]
        [Column("AirPlaneName")]
        public string Name { get; set; }
        //**********************new Feald*********************
        [Column("AirPlaneBrand")]
        [Required]
        public string Brand { get; set; }
        [Column("AirPlaneModel")]
        [Required]
        public string Model { get; set; }

        [Required]
        [Column("AirPlaneCode")]
        public string AirPlaneCode { get; set; }

        [ForeignKey("Brands")]
        [Required]
        [Column("BrandId")]
        public int BrandId { get; set; }
        public Brand Brands { get; set; }
        //*******************End of New feald *********************** 
        //foriegn Key
        [ForeignKey("Gallery")]
        [Required]
        [Column("AirPlaneGalleryId")]
        public int GalleryId { get; set; }
        public Gallery Gallery { get; set; }

        //***********************foriegen Key*******************
        [ForeignKey("Detail")]
        [Required]
        [Column("DetailId")]
        public int DetailId { get; set; }
        public Detail Detail { get; set; }
        //******************end FOreign Key***************
        //*******************Foreign Key******************
        [ForeignKey("AirlineId")]
        [Column("AirlineId")]
        public int AirlineId { get; set; }
        public Airline Airlines { get; set; }
        //**************End Foreign Key*****************************

        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("DateCreate")]
        public DateTime DateCrate { get; set; }
        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("LastUpdateDate")]
        public DateTime LastUpdate { get; set; }
        [Column("IsDelete")]
        public bool IsDelete { get; set; }

        public virtual ICollection<Flight> Flights { set; get; } // many-to-many

    }


}
