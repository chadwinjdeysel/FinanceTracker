using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceTracker.Data;
using FinanceTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IFinanceRepo _repo;

        public CategoryController(IFinanceRepo repo)
        {
            this._repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _repo.GetList<Category>();

            return View(categories);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Category model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                _repo.Add<Category>(model);

                if (await _repo.SaveAll())
                    return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null || id == Guid.Empty)
                return NotFound();

            var category = await _repo.Find<Category>(id);

            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                _repo.Edit<Category>(model);

                if (await _repo.SaveAll())
                    return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == null || id == Guid.Empty)
                return NotFound();

            var category = await _repo.Find<Category>(id);

            _repo.Delete<Category>(category);

            if (await _repo.SaveAll())
                return RedirectToAction("Index");

            throw new Exception("Something went wrong while trying to delete the category");

        }
    }
}
