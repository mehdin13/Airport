using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AirPortModel.Models
{
    [Table("Tbl_Raiting")]
    public class Raiting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        //***********************foreignkey******************************
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Detail")]
        public int detailid { get; set; }
        public Detail Detail { get; set; }
        //*******************end foreignKey*******************************

        public string Value { get; set; }
        [StringLength(255)]
        public string CommentText { get; set; }
        [Required]
        [Column("Isactive")]
        public bool Isactive { get; set; }
        [Required]
        [Column("Isdelete")]
        public bool IsDelete { get; set; }
        [Required]
        [Column("DateCreate")]
        public DateTime DateCreate { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
