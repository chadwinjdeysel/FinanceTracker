using FinanceTracker.Helpers;
using FinanceTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.ViewModels
{
    public class CategoryExpensesViewModel
    {
        public List<Expense> Expenses { get; set; }
        public ChartJs Chart { get; set; }
    }
}
