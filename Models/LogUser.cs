using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_project.Models
{
    public class LoginUser
    {
        [Required]
        [EmailAddress]
        [Column("email", TypeName="VARCHAR(255)")]
        [Display(Name="Email")]
        public string LogEmail { get; set; }
        [Required]
        [Column("password", TypeName="VARCHAR(255)")]
        [Display(Name="Password")]
        public string LogPassword { get; set; }
    }
}
