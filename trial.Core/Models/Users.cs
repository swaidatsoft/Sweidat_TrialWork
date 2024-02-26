using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialRepository.Core.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z'-]+$", ErrorMessage = "Please enter a valid name.")]
        [StringLength(maximumLength: 25, MinimumLength = 3)]
        [Display(Name = "Name")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z'-]+$", ErrorMessage = "Please enter a valid First Name.")]
        [StringLength(maximumLength: 25, MinimumLength = 3)]
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z'-]+$", ErrorMessage = "Please enter a valid User Name.")]
        [StringLength(maximumLength: 25, MinimumLength = 3)]
        [Display(Name = "Name")]
        public string UserName { get; set; }
        
        [Required]
        [StringLength(maximumLength: 25, MinimumLength = 3)]
        [Display(Name = "Password")]
       // [RegularExpression(@"^[a-zA-Z'-]+$", ErrorMessage = "Please enter a valid Password.")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [StringLength(maximumLength: 25, MinimumLength = 3)]
       // [RegularExpression(@"^[a-zA-Z'-]+$", ErrorMessage = "Please enter a valid Confirm Password.")]
        [Display(Name = "Confirm Password")]
        public string Confirm_Password { get; set; }
        
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string? Email { get; set; }
        
        public Boolean? Is_AgreeToTerms { get; set; }
        
        public Boolean? Is_AgreeToPrivacy { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
       // public Company Company { get; set; }









    }
}
