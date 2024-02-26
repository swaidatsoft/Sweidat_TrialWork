using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialRepository.Core.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z'-]+$", ErrorMessage = "Please enter a valid name.")]
        [StringLength(maximumLength: 25, MinimumLength = 3)]
        [Display(Name = "Name")]
         public string CompanyName { get; set; }

        
        public string CompanyBranch { get; set; }


        public List<Users> user { get; set; }

    }
}
