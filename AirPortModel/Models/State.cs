﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_State")]
    public class State
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("StateId")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Column("StateName")]
        public string Name { get; set; }
    }
}
