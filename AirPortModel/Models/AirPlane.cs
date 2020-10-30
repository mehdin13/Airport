using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        //foriegn Key
        [ForeignKey("Gallery")]
        [Required]
        [Column("AirPlaneGalleryId")]
        public int GalleryId { get; set; }
        public Gallery Gallery { get; set; }

        [Column("AirlineId")]
        public int AirlineId { get; set; }
        //foriegen Key
        [ForeignKey("Detail")]
        [Required]
        [Column("DetailId")]
        public int DetailId { get; set; }
        public Detail Detail { get; set; }

        public virtual ICollection<Flight> Flights { set; get; } // many-to-many

    }


}
