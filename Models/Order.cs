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
        public int Orderid { get; set; }
        public int Userid { get; set; }
        public bool PurchaseMade {get;set;} = false;
        public List<Item> ItemsOrdered { get; set; }

        [Column("created_at")]
        public DateTime Created_At { get; set; } = DateTime.Now;
        [Column("updated_at")]
        public DateTime Updated_At { get; set; } = DateTime.Now;
        public User User {get;set;}
    }
}