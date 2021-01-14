using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Models
{
    public class BudgetCategoryMapper
    {
        public Guid BudgetId { get; set; }
        public Budget Budget { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public float Amount { get; set; }
    }
}
