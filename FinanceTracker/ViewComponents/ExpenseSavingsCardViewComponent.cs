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
    public class ExpenseSavingsCardViewComponent : ViewComponent
    {
        private readonly IFinanceRepo _repo;

        public ExpenseSavingsCardViewComponent(IFinanceRepo repo)
        {
            this._repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var expenses = await _repo.GetList<Expense>();

            var savings = await _repo.GetList<Saving>();

            savings = savings.Where(x => x.Date.ToString("yyyy/MM") == DateTime.Now.ToString("yyy/MM"))
                .AsQueryable();

            var model = new ExpenseSavingsViewModel()
            {
                TotalExpenses = expenses.Where(x => x.Date.ToString("yyyy/MM") == DateTime.Now.ToString("yyyy/MM"))
                    .Select(x => x.Amount)
                    .Sum(),
                TotalSaved = (savings.Where(x => x.Type == Models.Type.Addition).Select(x => x.Amount).Sum()) - (savings.Where(x => x.Type == Models.Type.Subtraction).Select(x => x.Amount).Sum()),
                Chart = await GenerateSavingsChart()
            };

            return View(model);
        }

        public async Task<ChartJs> GenerateSavingsChart()
        {
            var chart = new ChartJs();

            var savings = await _repo.GetList<Saving>();

            DateTime[] months = Enumerable.Range(1, 3)
                                        .Select(i => DateTime.Now.AddMonths(i - 3))
                                        .ToArray();

            List<float> totalSavedForMonth = new List<float>();

            foreach(var item in months)
            {
                float additions = savings.Where(x => x.Date.ToString("yyyy/MM") == item.ToString("yyyy/MM") && x.Type == Models.Type.Addition)
                    .Select(x => x.Amount)
                    .Sum();

                float subtractions = savings.Where(x => x.Date.ToString("yyyy/MM") == item.ToString("yyyy/MM") && x.Type == Models.Type.Subtraction)
                    .Select(x => x.Amount)
                    .Sum();

                totalSavedForMonth.Add(additions - subtractions);
            };


            chart.type = "line";

            chart.data = new Helpers.Data
            {
                datasets = new Dataset[]
                {
                    new Dataset()
                    {
                        label = "saved",
                        backgroundColor = new string[]{ "rgba(0, 242, 255, 0.2)" },
                        borderColor = "rgb(0, 242, 255)",
                        data = totalSavedForMonth.ToArray()
                    }   
                },
                labels = months.Select(date => date.ToShortDateString()).ToArray()
            };

            chart.options = new Options
            {
                responsive = true,
                maintainAspectRatio = false,
                legend = new Legend
                {
                    display = false
                },
                title = new Title
                {
                    display = true,
                    text = "savings for past 3 months",
                    fontStyle = "regular",
                },
                scales = new Scales
                {
                    yAxes = new YAxes[]
                    {
                        new YAxes
                        {
                            display = false,
                            ticks = new Ticks
                            {
                                beginAtZero = true
                            }
                        }

                    },
                    xAxes = new XAxes[]
                    {
                        new XAxes
                        {
                            display = false
                        }
                    }
                }
            };


            return chart;
        }
    }
}
