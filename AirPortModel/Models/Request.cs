using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Request")]
    public class Request
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("RequestId")]
        public int Id { get; set; }

        //***************Foreign Key**********************
        [ForeignKey("requests")]
        [Column("TypeId")]
        public int TypeId { get; set; }
        public RequestType requests { get; set; }
        //**************End Foreign Key*******************
        [Column("Title")]
        public string Title { get; set; }

        [StringLength(255)]
        [Column("Description")]
        public string Description { get; set; }
        //**********************Foreign Key **********************
        [ForeignKey("CustomerId")]
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        //********************End Foreign Key**********************
        //*********************Estefade Dar Versione Badi ****************
        //[AllowNull]
        //public string Image { get; set; }
        //
        //*******************End Comment****************

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
    }
}
