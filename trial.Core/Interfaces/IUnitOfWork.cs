using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrialRepository.Core.Models;
using TrialRepository.Core.Repository;

namespace TrialRepository.Core.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {

        IBaseRepository<Company> Companys { get; }
        IBaseRepository<Users> Users { get; }

        int Complete();

    }
}
