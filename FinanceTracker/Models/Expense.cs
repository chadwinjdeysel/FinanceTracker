using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Models
{
    public class Expense
    {
        public Guid Id { get; set; }

        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public float Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
