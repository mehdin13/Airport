using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace AirPortModel.Models
{
    [Table("Tbl_Place")]
    public class Place
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PlaceId")]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Place Name Must Be Less than 50 character")]
        [Column("PlaceName")]
        public string Name { get; set; }

        [ForeignKey("address")]
        [Column("PlaceAddress")]
        public int AdressId { get; set; }
        public Address address { get; set; }
        //*****************foreignKey******************
        [ForeignKey("Category")]
        [Required]
        [Column("PlaceCategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        //*********************end******************
        //******************foreign key******************
        [ForeignKey("Gallery")]
        [Required]
        [Column("PlaceGalleryId")]
        public int GalleryId { get; set; }
        public Gallery Gallery { get; set; }
        //**********************End******************
        //******************foreign Key******************
        [ForeignKey("Detail")]
        [Required]
        [Column("PlaceDetailId")]
        public int DetailId { get; set; }
        public Detail Detail { get; set; }
        //*********************End ******************
        //***********foreign Key********************
        [AllowNull]
        [ForeignKey("Customers")]
        [Column("CustomerId")]
        public int? CustomerId { get; set; }
        public Customer Customers { get; set; }
        [AllowNull] 
        [ForeignKey("airPorts")]
        [Column("Airportid")]
        public int? AirportId { get; set; }
        public AirPort airPorts { get; set; }
        //******************End Foregn key******************
        [AllowNull]
        public int Cost { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [NotNull]
        [Column("PlaceIsactive")]
        public bool active { get; set; }
        //**************************************check shavad dobare ***************************
        [DataType(DataType.DateTime)]
        [Required]
        [Column("DateCreate")]
        public DateTime DateCreate { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        [Column("LastUpdateDate")]
        public DateTime LastUpdate { get; set; }
        [Required]
        [Column("IsDelete")]
        public bool IsDelete { get; set; }
    }
}
