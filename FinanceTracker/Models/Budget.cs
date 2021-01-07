using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.Models
{
    public class Budget
    {
        public Guid Id { get; set; }


        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public float ProjectedAmount { get; set; }
        public DateTime Period { get; set; }
    }
}
