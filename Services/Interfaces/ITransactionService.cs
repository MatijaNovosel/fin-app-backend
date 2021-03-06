using System.Threading.Tasks;
using fin_app_backend.Models;
using System.Collections.Generic;
using fin_app_backend.Utils;

namespace fin_app_backend.Services.Interfaces
{
  public interface ITransactionService
  {
    Task AddTransaction(AddTransactionDto transaction, string userId);
    Task AddTransfer(AddTransferDto transfer, string userId);
    Task DeleteTransaction(string userId, long tId);
    Task<IEnumerable<TransactionModel>> GetAll(
      string userId,
      int? skip,
      int? take,
      string description,
      string transactionType,
      int? categoryType
    );
    Task<IEnumerable<TransactionActivityHeatmapModel>> GetTransactionActivityHeatmap(string userId);
    Task<long> GetCount(
      string userId,
      string description,
      string transactionType,
      int? categoryType
    );
  }
}