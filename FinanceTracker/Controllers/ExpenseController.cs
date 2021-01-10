using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceTracker.Data;
using FinanceTracker.Models;
using FinanceTracker.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IFinanceRepo _repo;

        public ExpenseController(IFinanceRepo repo)
        {
            this._repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _repo.GetList<Expense>();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ExpenseViewModel();
            model.Categories = await _repo.GetList<Category>();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ExpenseViewModel model) 
        {
            if (ModelState.IsValid)
            {
                var expense = new Expense();

                expense.Amount = model.Amount;
                expense.CategoryId = model.CategoryId;  
                expense.Date = model.Date;
                expense.Description = model.Description;

                _repo.Add(expense);

                if (await _repo.SaveAll())
                    return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var expense = await _repo.Find<Expense>(id);

            if (expense == null)
                return NotFound();

            var viewModel = new ExpenseViewModel();
            viewModel.Id = expense.Id;
            viewModel.Amount = expense.Amount;
            viewModel.Date = expense.Date;
            viewModel.Description = expense.Description;
            viewModel.CategoryId = expense.CategoryId;
            viewModel.Categories = await _repo.GetList<Category>();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ExpenseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var expense = new Expense();
                expense.Id = model.Id;
                expense.Amount = model.Amount;
                expense.Description = model.Description;
                expense.Date = model.Date;
                expense.CategoryId = model.CategoryId;

                _repo.Edit<Expense>(expense);

                if (await _repo.SaveAll())
                    return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            if(id != Guid.Empty)
            {
                var expense = await _repo.Find<Expense>(id);

                _repo.Delete<Expense>(expense);

                if (await _repo.SaveAll())
                    return RedirectToAction("Index");
            }

            // TO:DO Give user feedback on error.
            return RedirectToAction("Index");
        }
    }
}
