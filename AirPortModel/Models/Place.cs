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
        [StringLength(50,ErrorMessage ="Place Name Must Be Less than 50 character")]
        [Column("PlaceName")]
        public string Name { get; set; }

        [ForeignKey("address")]
        [Column("PlaceAddress")]
        public int Adress { get; set; }
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
        [ForeignKey("Customers")]
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
        //******************end Foregn key******************
        [NotNull]
        [Column("PlaceIsactive")]
        public bool active { get; set; }
        //**************************************check shavad dobare ***************************
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
    }
}
