using FinanceTracker.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.ViewModels
{
    public class BudgetUsedViewModel
    {
        public ChartJs Chart { get; set; }
        public double PercentageUsed { get; set; }
        public int CategoriesInBudget { get; set; }
        public int CategoriesOverBudget { get; set; }
    }
}
