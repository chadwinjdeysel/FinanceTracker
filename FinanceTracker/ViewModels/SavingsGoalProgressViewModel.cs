using FinanceTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.ViewModels
{
    public class SavingsGoalProgressViewModel
    {
        public SavingsGoal SavingsGoal { get; set; }
        public float Progress { get; set; }
    }
}
