using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Models
{
    public class Budget
    {
        public Guid Id { get; set; }
        public DateTime Period { get; set; }

        public virtual IEnumerable<BudgetCategoryMapper> Mapper { get; set; }
    }
}
