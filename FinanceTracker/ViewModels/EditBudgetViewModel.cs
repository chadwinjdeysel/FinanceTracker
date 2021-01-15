using FinanceTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.ViewModels
{
    public class EditBudgetViewModel
    {
        public Guid BudgetId { get; set; }
        public Dictionary<Category, float> TotalsForTheMonth { get; set; }

    }
}
