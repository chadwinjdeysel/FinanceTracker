using FinanceTracker.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Models
{
    public class SavingsGoal
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0.1, 9999999999, ErrorMessage = "Must be atleast ten cents")]
        public float Amount { get; set; }
        public string Description { get; set; }

        [Display(Name = "This goal has a deadline")]
        public bool HasDeadline { get; set; }

        [Display]
        public bool IsPinned { get; set; }

        [SavingsGoalDate(ErrorMessage = "The date must be a later date than today")]
        public DateTime Deadline { get; set; }
        public string ImagePath { get; set; }

        public IEnumerable<Saving> Savings { get; set; }
    }
}
