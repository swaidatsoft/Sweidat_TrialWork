using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialRepository.Core.Interfaces;
using TrialRepository.Core.Models;
using TrialRepository.Core.Repository;

namespace Repository.EF.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        //prepared

        private readonly ApplicationDBContext _dbContext;

        public IBaseRepository<Users> Users { get;private set; }

        public IBaseRepository<Company> Company { get; private set; }

        public IBaseRepository<Company> Companys => throw new NotImplementedException();

        public UnitOfWork(ApplicationDBContext dbContext)
        {

        }

       public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
             _dbContext.Dispose();
        }
    }
}
