using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace csharp_project.Models
{
    public class Item
    {
        [Key]
        [Required]
        [Column("id")]
        public int Itemid {get;set;}
        [Column("product_id")]
        [Required]
        public int Productid {get;set;}
        [Column("order_id")]
        [Required]
        public int Orderid {get;set;}
        public int Galleryid {get;set;}
        [Column("quantity")]
        [Required]
        public int Quantity {get;set;} = 1;
        public Order Order {get;set;}
        public Product Product {get;set;}
        public Gallery ChosenImage {get;set;}
       
        [Column("created_at")]
        public DateTime Created_At { get; set; } = DateTime.Now;
        [Column("updated_at")]
        public DateTime Updated_At { get; set; } = DateTime.Now;
    }
}