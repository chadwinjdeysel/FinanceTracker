using FinanceTracker.Data;
using FinanceTracker.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.ViewComponents
{
    public class SavingsGoalCardViewComponent : ViewComponent
    {
        private readonly IFinanceRepo _repo;

        public SavingsGoalCardViewComponent(IFinanceRepo repo)
        {
            this._repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var goal = await _repo.GetPinnedGoal();

            var model = new SavingsGoalProgressViewModel()
            {
                SavingsGoal = goal,
                Progress = await _repo.CalculateProgress(goal)
            };

            return View(model);
        }
    }
}
