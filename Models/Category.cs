using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace csharp_project.Models
{
    public class Category
    {
        [Key]
        [Column("id")]
        public int Categoryid { get; set; }
        [Required]
        public string Name { get; set; }
        [Column("created_at")]
        public DateTime Created_At { get; set; } = DateTime.Now;
        [Column("updated_at")]
        public DateTime Updated_At { get; set; } = DateTime.Now;
        public List<Gallery> allImages { get; set; }
    }
}