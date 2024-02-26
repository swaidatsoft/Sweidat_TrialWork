using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.EF;
using Repository.EF.DTOs;
using TrialRepository.Core.Models;
using TrialRepository.Core.Repository;

namespace TrialRepository.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        // private readonly IBaseRepository<Users> _usersRepository;

        private readonly ApplicationDBContext _context;

        private readonly IMapper _mapper;
        public UsersController(ApplicationDBContext context , IMapper _mapper)
        {
            _context = context;
        }



        //[HttpGet("CompanyWithUsers")]
        //public async Task<ActionResult<IEnumerable<Users>>> GetAllUser()
        //{
        //    try
        //    {
        //        if (_context.Users == null)
        //        {
        //            return NotFound();
        //        }
        //        return await _context.Users.Include(_ => _.CompanyId).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Internal server error: {ex.Message}");
        //    }
        //}



    }
}
