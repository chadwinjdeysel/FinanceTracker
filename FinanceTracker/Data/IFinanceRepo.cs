using FinanceTracker.Helpers;
using FinanceTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Data
{
    public interface IFinanceRepo
    {
        // generic entities
        void Add<T>(T entity) where T : class;
        void Edit<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<T> Find<T>(Guid id) where T : class;
        Task<IEnumerable<T>> GetList<T>() where T : class;

        Task<bool> SaveAll();

        // expenses
        Task<PaginatedList<Expense>> GetPagedExpenses(ExpenseParams @params);
    }
}
