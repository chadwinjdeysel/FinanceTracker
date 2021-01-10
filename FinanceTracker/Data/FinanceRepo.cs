using FinanceTracker.Helpers;
using FinanceTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Data
{
    public class FinanceRepo : IFinanceRepo
    {
        private readonly AppDbContext _context;

        public FinanceRepo(AppDbContext context)
        {
            this._context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            if (entity != null)
                _context.Remove(entity);
        }

        public void Edit<T>(T entity) where T : class
        {
            _context.Set<T>().Update(entity);
        }

        public async Task<T> Find<T>(Guid id) where T : class
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetList<T>() where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<PaginatedList<Expense>> GetPagedExpenses(ExpenseParams @params)
        {
            var expenses = _context.Expenses
                .Include(x => x.Category)
                .AsQueryable();

            if (@params.CategoryId != null)
                expenses = expenses.Where(c => c.CategoryId == @params.CategoryId).AsQueryable();

            switch (@params.OrderBy)
            {
                case "dateacsending":
                    expenses = expenses.OrderBy(d => d.Date);
                    break;
                case "amountacsending":
                    expenses = expenses.OrderBy(a => a.Amount);
                    break;
                case "amountdescending":
                    expenses = expenses.OrderByDescending(a => a.Amount);
                    break;
                default:
                    expenses = expenses.OrderByDescending(d => d.Date);
                    break;
            }

            return await PaginatedList<Expense>.CreateAsync(expenses.AsNoTracking(), @params.PageNumber, @params.PageSize);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
