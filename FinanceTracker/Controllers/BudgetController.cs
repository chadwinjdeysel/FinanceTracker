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

        public async Task<IActionResult> Edit(Guid id)
        {
            var budget = await _repo.GetBudget();
            var categories = await _repo.GetList<Category>();

            Dictionary<Category, float> totalsAndCategories = new Dictionary<Category, float>();

            foreach(var item in categories)
            {
                float totalForCategory = budget.Where(x => x.CategoryId == item.Id)
                    .Select(x => x.Amount)
                    .FirstOrDefault();

                totalsAndCategories.Add(item, totalForCategory > 0 ? totalForCategory : 0);
            }

            var viewModel = new EditBudgetViewModel()
            {
                TotalsForTheMonth = totalsAndCategories,
                BudgetId = id
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(IFormCollection model)
        {
            foreach(var item in model.Keys)
            {
                if(item != "__RequestVerificationToken" && item != "BudgetId")
                {
                    var mapper = new BudgetCategoryMapper();

                    mapper.BudgetId = Guid.Parse(model["BudgetId"].ToString());
                    mapper.CategoryId = Guid.Parse(item.ToString());
                    mapper.Amount = float.Parse(model[item].ToString());

                    if(await _repo.BudgetMapExists(mapper.BudgetId, mapper.CategoryId))
                        _repo.Edit<BudgetCategoryMapper>(mapper);
                    else
                        _repo.Add<BudgetCategoryMapper>(mapper);
                }
            }

            if (await _repo.SaveAll())
                return RedirectToAction("Index");

            return View();
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var budget = await _repo.Find<Budget>(id);

            if (budget == null)
                return NotFound();

            _repo.Delete<Budget>(budget);

            if (await _repo.SaveAll())
                return RedirectToAction("Index");

            throw new Exception("Something went wrong trying to delete this budget");
        }
    }
}
