using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Utilities
{
    public class SavingsGoalDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime date = Convert.ToDateTime(value);
            return date > DateTime.Now;
        }
    }
}
