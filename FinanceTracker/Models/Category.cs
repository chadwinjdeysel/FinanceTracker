using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string ColorCode { get; set; }
        public string Description { get; set; }

        public IEnumerable<Expense> Expenses { get; set; }
        public IEnumerable<Budget> Budgets { get; set; }

    }
}
