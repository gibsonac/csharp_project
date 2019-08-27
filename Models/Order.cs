using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace csharp_project.Models
{
    public class Order
    {
        [Key]
        [Required]
        [Column("id")]
        public int Orderid {get;set;}
        [Column("product_id")]
        [Required]
        public int Productid {get;set;}
        [Column("user_id")]
        [Required]
        public int Userid {get;set;}
        [Column("quantity")]
        [Required]
        public int Quantity {get;set;}
        public User User {get;set;}
        public Product Product {get;set;}
       
        [Column("created_at")]
        public DateTime Created_At { get; set; } = DateTime.Now;
        [Column("updated_at")]
        public DateTime Updated_At { get; set; } = DateTime.Now;
    }
}