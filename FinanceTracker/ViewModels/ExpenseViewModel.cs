using FinanceTracker.Models;
using FinanceTracker.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.ViewModels
{
    public class ExpenseViewModel
    {

        public Guid Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(0.10, 999999999, ErrorMessage = "Must be atleast more than 10 cents")]
        public float Amount { get; set; }

        [Required]
        [ExpenseDate(ErrorMessage = "The date can't be a later date than today.")]
        public DateTime Date { get; set; }

        public string Description { get; set; }

        [Display(Name = "Category")]
        public Guid CategoryId { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
