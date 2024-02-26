using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialRepository.Core.Models;

namespace Repository.EF.DTOs
{
      public  class CompanyDTOs
    {

        public int CompanyId { get; set; }

        [Required, MaxLength(150)]
        public string CompanyName { get; set; }

        [Required]
        public string CompanyBranch { get; set; }


        public List<Users> user { get; set; }

    }
}
