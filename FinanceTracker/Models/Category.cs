using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Display(Name = "Color")]
        public string ColorCode { get; set; }
        public string Description { get; set; }

        public virtual IEnumerable<Expense> Expenses { get; set; }

        public virtual IEnumerable<BudgetCategoryMapper> Mapper { get; set; }

    }
}
