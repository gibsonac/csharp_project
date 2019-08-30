using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace csharp_project.Models
{
    public class User
    {
        [Key]
        [Column("id")]
        public int Userid { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "First name must be more than 2 characters!")]
        [Column("first_name", TypeName = "VARCHAR(255)")]
        [Display(Name = "First Name")]
        public string First_Name { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Last name must be more than 2 characters!")]
        [Column("last_name", TypeName = "VARCHAR(255)")]
        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }
        [Required]
        [EmailAddress]
        [Column("email", TypeName = "VARCHAR(255)")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [SafePassword]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        [Column("password", TypeName = "VARCHAR(255)")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password_confirm { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Street Address must be more than 2 characters!")]
        [Column("street", TypeName = "VARCHAR(255)")]
        [Display(Name = "street")]
        public string Street { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "City Address must be more than 2 characters!")]
        [Column("city", TypeName = "VARCHAR(255)")]
        [Display(Name = "city")]
        public string City { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "State must be more than 2 characters!")]
        [Column("state", TypeName = "VARCHAR(255)")]
        [Display(Name = "state")]
        public string State { get; set; }
        [Required]
        [Range(0,99999)]
        [Column("zipcode", TypeName = "INT")]
        [Display(Name = "zipcode")]
        public int Zipcode { get; set; }

        [Column("created_at")]
        public DateTime Created_At { get; set; } = DateTime.Now;
        [Column("updated_at")]
        public DateTime Updated_At { get; set; } = DateTime.Now;
        public List<Order> Orders {get;set;}
    }



    public class SafePasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            var input = (string)value;

            ErrorMessage = string.Empty;
            var hasNumber = new Regex(@"[0-9]+");
            var hasChar = new Regex(@"[a-zA-Z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasChar.IsMatch(input))
            {
                return new ValidationResult("Password should at least have one letter, one number, and one character");
            }
            if (!hasNumber.IsMatch(input))
            {
                return new ValidationResult("Password should at least have one letter, one number, and one character");
            }

            if (!hasSymbols.IsMatch(input))
            {
                return new ValidationResult("Password should at least have one letter, one number, and one character");
            }
            else
            {
                return ValidationResult.Success;

            }
        }
    }
}
