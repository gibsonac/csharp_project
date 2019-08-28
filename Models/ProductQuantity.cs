using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace csharp_project.Models
{
    public class ProductQuantity
    {
        
        public int Productid {get;set;}
        [Required]
        public double Price {get;set;}
        [Required]
        public string Style {get;set;}
        [Required]
        public string Description {get;set;}
        [Required]
        public string Size {get;set;}
        [Required]
        public int Quantity {get;set;}
    }
}