using FinanceTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.ViewModels
{
    public class ExpenseViewModel
    {

        public Guid Id { get; set; }

        public float Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Guid CategoryId { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
