using FinanceTracker.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.ViewModels
{
    public class ExpenseSavingsViewModel
    {
        public float TotalExpenses { get; set; }
        public float TotalSaved { get; set; }
        public ChartJs Chart { get; set; }
    }
}
