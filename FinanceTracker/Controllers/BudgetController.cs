using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceTracker.Data;
using FinanceTracker.Models;
using FinanceTracker.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.Controllers
{
    public class BudgetController : Controller
    {
        private readonly IFinanceRepo _repo;

        public BudgetController(IFinanceRepo repo)
        {
            this._repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new BudgetIndexViewModel()
            {
                Budget = await _repo.GetBudget(),
                TotalForTheMonth = await _repo.GetTotalsForBudget(),
                Categories = await _repo.GetList<Category>()
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Add()
        {
            var categories = await _repo.GetList<Category>();

            return View(categories);
        }

        [HttpPost]
        public async Task<IActionResult> Add(IFormCollection model)
        {
            var budget = new Budget { 
                Period = DateTime.Now
            };

            _repo.Add<Budget>(budget);

            foreach(var item in model.Keys)
            {
                if(item != "__RequestVerificationToken")
                {
                    var mapper = new BudgetCategoryMapper() 
                    { 
                        BudgetId = budget.Id,
                        CategoryId = Guid.Parse(item.ToString()),
                        Amount = float.Parse(model[item].ToString())
                    };

                    _repo.Add<BudgetCategoryMapper>(mapper);
                }
            }

            if (await _repo.SaveAll())
                return RedirectToAction("Index");

            return View();
        }
    }
}
