using fin_app_backend.Entities;
using fin_app_backend.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fin_app_backend.Repositories.Interfaces
{
  public interface IAccountRepository : IRepository<Account>
  {
    Task<double> GetCurrentAmount(int accountId);
  }
}