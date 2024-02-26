using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Repository.EF;
using Repository.EF.DTOs;
using Repository.EF.Repository;
using TrialRepository.Core.Models;
using TrialRepository.Core.Repository;

namespace TrialRepository.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {

       

       // private readonly IBaseRepository<Company> _companyRepository;



        private readonly ApplicationDBContext _context;

        private readonly IMapper _mapper;

        //private readonly UnitOfWork _Uwork;
        public CompanyController(ApplicationDBContext applicationDbContext, IMapper mapper)
        {
            _context = applicationDbContext;
            _mapper = mapper;
        }


        [HttpGet("CompanyNames")]
        public async Task<IActionResult> GetCompanyNames()
        {
            try
            {
                var companies = await _context.Companys
                    .Select(c => new { companyName = c.CompanyName, companyBranch = c.CompanyBranch })
                    .Distinct()
                    .ToListAsync();

                return Ok(companies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [HttpGet("CompanyWithUsers")]
        public async Task<ActionResult<IEnumerable<Company>>> GetAllComp()
        {
            try
            {
                if (_context.Companys == null)
                {
                    return NotFound();
                }
                return await _context.Companys.Include(_ => _.user).ToListAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

       


        [HttpPost("RegistrationDataForm")]
        public async Task<IActionResult> Post(CompanyDTOs _companyDTOs)

        {
            try
            {
                var user = new Users();
                if (_context.Users.Any(c => c.UserName == user.UserName) || _context.Users.Any(c=>c.Email == user.Email))
                {
                    return BadRequest("Company name is already taken.");
                }

                Company company = new Company();    

                company.CompanyId +=1; 
                var newCompany =CompanyRepository.CombinedData(_companyDTOs); ;//MapcompanyObject(_companyDTOs);
                _context.Companys.Add(newCompany);
                await _context.SaveChangesAsync();
                return Created($"/company/{newCompany.CompanyId}", newCompany);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }




        //[HttpPut("Update_Data")]
        //public async Task<IActionResult> Put([FromBody] CompanyDTOs _companyDTOs)
        //{
        //    try
        //    {
        //        var UdateCompany = CompanyRepository.CombinedData(_companyDTOs);   //_mapper.Map<Company>(_companyDTOs);//MapcompanyObject(_companyDTOs);
        //        _context.Companys.Update(UdateCompany);
        //        await _context.SaveChangesAsync();
        //        return Ok(Created($"/Company/{UdateCompany.CompanyId}", UdateCompany));
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Internal server error: {ex.Message}");
        //    }
        //}

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete( int id)
        {
            try
            {
                var CompanyToDelete = await _context.Companys.Include(_ => _.user).Where(_ => _.CompanyId == id).FirstOrDefaultAsync();
                if (CompanyToDelete == null)
                {
                    return NotFound();
                }
                _context.Companys.Remove(CompanyToDelete);
                _context.SaveChanges();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("branches")]
        public async Task<IActionResult> GetCompanyBranches()
        {
            try
            {
                var branches = await _context.Companys
                    .Select(c => c.CompanyBranch)
                    .Distinct()
                    .ToListAsync();

                return Ok(branches);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


    }




















































































































}

