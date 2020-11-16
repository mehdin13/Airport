using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_type")]
    public class Type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TypeId")]
        public int Id { get; set; }
        
        [Required]
        [Column("TypeName")]
        public string Name { get; set; }
        
        [Required]
        [Column("TypeIcon")]
        public string Icon { get; set; }
        //****************foreigne Key ***************
        [ForeignKey("RequestId")]
        [Column("RequestId")]
        public int Request { get; set; }
        public Request request { get; set; }
        //**************End Foreign Key**************
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
        public List<Request> requests { get; set; }
    }
}
