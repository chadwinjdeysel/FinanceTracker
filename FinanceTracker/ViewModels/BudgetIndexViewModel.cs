using FinanceTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.ViewModels
{
    public class BudgetIndexViewModel
    {
        public IEnumerable<BudgetCategoryMapper> Budget { get; set; }

        public Dictionary<Guid, float> TotalForTheMonth { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
