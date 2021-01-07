using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Models
{
    public class Saving
    {
        public Guid Id { get; set; }

        public Guid SavingsGoalId { get; set; }
        public SavingsGoal SavingsGoal { get; set; }

        public float Amount { get; set; }
        public DateTime Date { get; set; }

    }
}
