using FinanceTracker.Data;
using FinanceTracker.Helpers;
using FinanceTracker.Models;
using FinanceTracker.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceTracker.ViewComponents
{
    public class CategoryExpensesCardViewComponent : ViewComponent
    {
        private readonly IFinanceRepo _repo;

        public CategoryExpensesCardViewComponent(IFinanceRepo repo)
        {
            this._repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var model = new CategoryExpensesViewModel()
            {
                Expenses = await _repo.GetRecentExpenses(),
                Chart = await GenerateChart()
            };

            return View(model);
        }

        public async Task<ChartJs> GenerateChart()
        {
            var expensesForThisMonth = await _repo.GetList<Expense>();
            expensesForThisMonth = expensesForThisMonth.Where(x => x.Date.Month == DateTime.Now.Month).ToList();

            var categories = await _repo.GetList<Category>();

            var expenses = new List<float>();
            var colors = new List<string>();
            var categoryNames = new List<string>();

            foreach(var item in categories)
            {
                if(expensesForThisMonth.Where(x => x.CategoryId == item.Id).Any())
                {
                    expenses.Add(expensesForThisMonth.Where(x => x.CategoryId == item.Id).Select(x => x.Amount).Sum());
                    colors.Add(item.ColorCode);
                    categoryNames.Add(item.Name);
                }
            }

            var chart = new ChartJs()
            {
                type = "doughnut",
                data = new Helpers.Data
                {
                    labels = categoryNames.ToArray(),
                    datasets = new Dataset[]
                    {
                        new Dataset
                        {
                            label = "Category Breakdown",
                            data = expenses.ToArray(),
                            backgroundColor = colors.ToArray(),
                            borderColor = "#fff"
                        }
                    }
                },
                options = new Options
                {
                    responsive = true,
                    maintainAspectRatio = true,
                    legend = new Legend
                    {
                        display = false
                    },
                    cutoutPercentage = 50
                }
            };

            return chart;
        }
    }
}
