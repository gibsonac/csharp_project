using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace csharp_project.Models
{
    public class Product
    {
        [Key]
        [Column("id")]
        [Required]
        public int Productid {get;set;}
        [Column("price")]
        [Required]
        public double Price {get;set;}
        [Column("title")]
        [Required]
        public string Title {get;set;}
        [Column("description")]
        [Required]
        public string Description {get;set;}
        [Column("size")]
        [Required]
        public string Size {get;set;}
        [Column("created_at")]
        public DateTime Created_At { get; set; } = DateTime.Now;
        [Column("updated_at")]
        public DateTime Updated_At { get; set; } = DateTime.Now;
        public int Galleryid {get;set;}
        public Gallery ChosenImage {get;set;}
        public List<Order> Orders_In {get;set;}
    }
}