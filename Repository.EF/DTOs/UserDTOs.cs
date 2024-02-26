using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialRepository.Core.Models;

namespace Repository.EF.DTOs
{
    public class UserDTOs
    {

        public int UserId { get; set; }
        
        [Required]
        [RegularExpression(@"^[a-zA-Z'-]+$", ErrorMessage = "Please enter a valid name.")]
        [StringLength(maximumLength:25,MinimumLength =3)]
        [Display(Name ="Name")]
        public string LastName { get; set; }
        
        [Required]
        [RegularExpression(@"^[a-zA-Z'-]+$", ErrorMessage = "Please enter a valid First Name.")]
        [StringLength(maximumLength: 25, MinimumLength = 3)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Required]
        [RegularExpression(@"^[a-zA-Z'-]+$", ErrorMessage = "Please enter a valid Username.")]
        [StringLength(maximumLength: 25, MinimumLength = 3)]
        [Display(Name = "Username")]
        public string UserName { get; set; }
       
        [Required]
        public string Password { get; set; }
        
        [Required]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? Confirm_Password { get; set; }
        
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        public Boolean? Is_AgreeToTerms { get; set; }

        public Boolean? Is_AgreeToPrivacy { get; set; }

        public Company company { get; set; }
        




    }
}
