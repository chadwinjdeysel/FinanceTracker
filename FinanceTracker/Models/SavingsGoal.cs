using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Models
{
    public class SavingsGoal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool HasDeadline { get; set; }
        public DateTime Deadline { get; set; }
        public string ImagePath { get; set; }

        public IEnumerable<Saving> Savings { get; set; }
    }
}
