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

        [StringLength(50)]
        [Column("Name")]
        public string Name { get; set; }

        [StringLength(50)]
        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Type")]
        public int Type { get; set; }
        [StringLength(12)]
        [Column("Phone")]
        public string Phone { get; set; }

        [StringLength(255)]
        [Column("Description")]
        public string Description { get; set; }
        //*********************Estefade Dar Versione Badi ****************
        //[AllowNull]
        //public string Image { get; set; }
        //
        //*******************End Comment****************
    
    }
}
