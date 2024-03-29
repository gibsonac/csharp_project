using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace csharp_project.Models
{
    public class Gallery
    {
        [Key]
        [Column("id")]
        public int Galleryid { get; set; }
        // public blog Image {get;set;}
        [Column("title")]
        [Required]
        public string Title { get; set; }
        public string Image_URL { get; set; }
        [Column("description")]
        [Required]
        public string Description { get; set; }
        [Column("created_at")]
        public DateTime Created_At { get; set; } = DateTime.Now;
        [Column("updated_at")]
        public DateTime Updated_At { get; set; } = DateTime.Now;
        public int Categoryid { get; set; }
        public Category Category { get; set; }
    }
}