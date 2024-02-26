using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.EF.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TrialRepository.Core.Models;
using TrialRepository.Core.Repository;
using System.Linq;
namespace Repository.EF.Repository
{
    public class CompanyRepository
    {

        private readonly ApplicationDBContext _context;

        private readonly IMapper _mapper;
        public CompanyRepository(ApplicationDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        public static Company CombinedData(CompanyDTOs companyDTOs)
        {
            var result = new Company();
            result.CompanyName = companyDTOs.CompanyName;
            result.CompanyBranch = companyDTOs.CompanyBranch;
            result.user = new List<Users>();
            companyDTOs.user.ForEach(_ =>
            {
                var Newuser = new Users();
                Newuser.LastName = _.LastName;
                Newuser.FirstName = _.FirstName;
                Newuser.UserName = _.UserName;

                Newuser.Password = _.Password;
                Newuser.Confirm_Password = _.Confirm_Password;

                Newuser.Is_AgreeToTerms = _.Is_AgreeToTerms;
                Newuser.Is_AgreeToPrivacy = _.Is_AgreeToPrivacy;

                Newuser.Email = _.Email;

                result.user.Add(Newuser);
            });
            return result;

        }

































    }


}

       
    

