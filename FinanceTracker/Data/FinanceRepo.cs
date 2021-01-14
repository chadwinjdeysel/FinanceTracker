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

        public async Task<float> CalculateProgress(SavingsGoal goal)
        {
            var savings = await _context.Savings
                .Where(x => x.SavingsGoalId == goal.Id)
                .ToListAsync();

            float totalAdditions = savings.Where(x => x.Type == Models.Type.Addition)
                .Select(x => x.Amount)
                .Sum();

            float totalSubtractions = savings.Where(x => x.Type == Models.Type.Subtraction)
                .Select(x => x.Amount)
                .Sum();

            return (totalAdditions - totalSubtractions) / goal.Amount * 100;
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

        public async Task<IEnumerable<BudgetCategoryMapper>> GetBudget()
        {
            var budget = await _context.BudgetCategoryMappers
                .Where(x => x.Budget.Period.Month == DateTime.Now.Month)
                .Include(x => x.Budget)
                .Include(x => x.Category)
                .ToListAsync();

            return budget;
        }

        public async Task<SavingsGoal> GetGoal(Guid id)
        {
            return await _context.SavingsGoals
                .Where(x => x.Id == id)
                .Include(x => x.Savings) 
                .FirstOrDefaultAsync();
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

            if (@params.CategoryId != Guid.Empty)
                expenses = expenses.Where(c => c.CategoryId == @params.CategoryId).AsQueryable();

            switch (@params.OrderBy)
            {
                case "date-ascending":
                    expenses = expenses.OrderBy(d => d.Date);
                    break;
                case "amount-ascending":
                    expenses = expenses.OrderBy(a => a.Amount);
                    break;
                case "amount-descending":
                    expenses = expenses.OrderByDescending(a => a.Amount);
                    break;
                case "date-descending":
                    expenses = expenses.OrderByDescending(d => d.Date);
                    break;
                default:
                    expenses = expenses.OrderByDescending(d => d.Date);
                    break;
            }

            return await PaginatedList<Expense>.CreateAsync(expenses.AsNoTracking(), @params.PageNumber, @params.PageSize);
        }

        public  async Task<Dictionary<Guid, float>> GetTotalsForBudget()
        {
            var expenses = await _context.Expenses
                .Where(x => x.Date.Month == DateTime.Now.Month)
                .ToListAsync();

            var categories = await _context.Categories
                .ToListAsync();

            var totalsForBudget = new Dictionary<Guid, float>();

            foreach(var item in categories)
            {
                float totals = expenses.Where(x => x.CategoryId == item.Id)
                    .Select(x => x.Amount)
                    .Sum();

                totalsForBudget.Add(item.Id, totals > 0 ? totals : 0);
            }

            return totalsForBudget;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
