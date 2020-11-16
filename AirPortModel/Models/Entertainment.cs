using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Entertainment")]
    public class Entertainment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("EntertainmentId")]
        public int Id { get; set; }
        [Column("Type")]
        public int Type { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        //**************ForeignKey**************
        [ForeignKey("LinkIds")]
        [Column("LinkId")]
        public int LId { get; set; }
        public Links LinkIds { get; set; }
        //***********End foreignKay**************
        //********** Foreign Key*****************
        [ForeignKey("Gallery")]
        [Column("Gallery")]
        public int Galleryid { get; set; }
        public Gallery Gallery { get; set; }
        //**********End ForeignKey******************
        [StringLength(50)]
        [Column("Title")]
        public string Title { get; set; }
        [Column("Description")]
        [StringLength(255)]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("DateCreate")]
        public DateTime DateCreate { get; set; }
        [DataType(DataType.DateTime)]
        [AllowNull]
        [Column("LastUpdateDate")]
        public DateTime LastUpdate { get; set; }
        [Column("IsDelete")]
        public bool IsDelete { get; set; }

        //one to many

        //end one to many
    }
}
