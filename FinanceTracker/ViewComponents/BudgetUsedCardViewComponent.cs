using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceTracker.Helpers;
using FinanceTracker.Data;
using FinanceTracker.ViewModels;

namespace FinanceTracker.ViewComponents
{
    public class BudgetUsedCardViewComponent : ViewComponent
    {
        private readonly IFinanceRepo _repo;

        public BudgetUsedCardViewComponent(IFinanceRepo repo)
        {
            this._repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var budget = await _repo.GetBudget();

            var totalsForBudget = await _repo.GetTotalsForBudget();

            double percentage = Math.Round(totalsForBudget.Select(x => x.Value).Sum() / budget.Select(x => x.Amount).Sum() * 100);

            if (percentage > 100)
                percentage = 100;

            int categroriesOverBudget = 0;

            foreach(var item in budget)
            {
                float totalForBudget = totalsForBudget.Where(x => x.Key == item.CategoryId)
                    .Select(x => x.Value)
                    .FirstOrDefault();

                if (totalForBudget > item.Amount)
                    categroriesOverBudget++;
            }

            var model = new BudgetUsedViewModel()
            {
                PercentageUsed = percentage,
                Chart = GenerateChart(percentage),
                CategoriesInBudget = budget.Where(x => x.Amount > 0).Count(),
                CategoriesOverBudget = categroriesOverBudget
            };

            return View(model);
        }

        public ChartJs GenerateChart(double percentage)
        {
            var chart = new ChartJs()
            {
                type = "doughnut",
                data = new Helpers.Data
                {
                    datasets = new Dataset[]
                    {
                        new Dataset
                        {
                            label = "BudgetUsed",
                            data = new float[] { float.Parse(percentage.ToString()), float.Parse((100 - percentage).ToString()) },
                            backgroundColor = new string[] { "#ff004c", "#e6e6e6"},
                            borderColor = "#fff",
                        }
                    },
                    labels = new string[] { "Used", "Left" },
                },
                options = new Options
                {
                    responsive = true,
                    maintainAspectRatio = true,
                    legend = new Legend
                    {
                        display = false
                    },
                    title = new Title
                    {
                        display = false
                    },
                    cutoutPercentage = 80
                }
            };

            return chart;

        }
    }
}
