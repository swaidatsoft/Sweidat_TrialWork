using AutoMapper;
using Repository.EF.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialRepository.Core.Models;

namespace Repository.EF.Repository
{
    public class Mapper :Profile
    {
        public Mapper()
        {
            CreateMap<CompanyDTOs, Company>();//Companies

            CreateMap<UserDTOs, Users>();//Users
        }



    }
}
