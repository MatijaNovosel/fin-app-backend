using fin_app_backend.Entities;
using fin_app_backend.Repositories.Base;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace fin_app_backend.Repositories.Interfaces
{
  public interface IHistoryRepository : IRepository<History>
  {
    Task<IEnumerable<DateTime>> GetGroupedByCreatedAt(int userId, DateTime from, DateTime to);
  }
}