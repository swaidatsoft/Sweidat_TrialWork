using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialRepository.Core.Models;
using TrialRepository.Core.Repository;

namespace Repository.EF.Repository
{
    public class UsersRepository 
    {
        protected ApplicationDBContext _context;

        private readonly IMapper _mapper;
        public UsersRepository(ApplicationDBContext context , IMapper mapper)
        {
            _context = context;
        }

        //


       
    }
}
