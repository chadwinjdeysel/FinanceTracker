using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceTracker.Data;
using FinanceTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.Controllers
{
    public class SavingsController : Controller
    {
        private readonly IFinanceRepo _repo;

        public SavingsController(IFinanceRepo repo)
        {
            this._repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Add(Guid savingsGoalId, int type)
        {

            // TODO: Add way to prevent any addition contributions to be made when the goal has been met
            var model = new Saving();
            model.SavingsGoalId = savingsGoalId;
            model.Type = (Models.Type)(type);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Saving model)
        {
            if (ModelState.IsValid)
            {
                _repo.Add<Saving>(model);

                if (await _repo.SaveAll())
                    return RedirectToAction("Details", "SavingsGoal", new { id = model.SavingsGoalId });

                throw new Exception("Something went wrong trying to add saving");
            }

            return View();
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var saving = await _repo.Find<Saving>(id);

            if (saving == null)
                return NotFound();

            return View(saving);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Saving model)
        {
            if (ModelState.IsValid)
            {
                _repo.Edit<Saving>(model);

                if(await _repo.SaveAll())
                    return RedirectToAction("Details", "SavingsGoal", new { id = model.SavingsGoalId });

                throw new Exception("Something went wrong trying to edit saving record");
            }

            return View();
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var saving = await _repo.Find<Saving>(id);

            if (saving == null)
                return NotFound();

            _repo.Delete<Saving>(saving);

            if(await _repo.SaveAll())
                return RedirectToAction("Details", "SavingsGoal", new { id = saving.SavingsGoalId });

            return RedirectToAction("Details", "SavingsGoal", new { id = saving.SavingsGoalId });
        }
    }
}
