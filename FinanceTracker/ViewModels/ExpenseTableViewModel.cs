using FinanceTracker.Helpers;
using FinanceTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.ViewModels
{
    public class ExpenseTableViewModel
    {
        public PaginatedList<Expense> Expenses { get; set; }

        public Guid CategorySelected { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public int? PageSize { get; set; }
    }
}
