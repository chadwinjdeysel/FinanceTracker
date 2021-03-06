﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceTracker.Data;
using FinanceTracker.Models;
using FinanceTracker.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.Controllers
{
    public class SavingsGoalController : Controller
    {
        private readonly IFinanceRepo _repo;

        public SavingsGoalController(IFinanceRepo repo)
        {
            this._repo = repo;
        }

        [Route("~/Savings")]
        public async Task<IActionResult> Goals()
        {
            var goals = await _repo.GetList<SavingsGoal>();

            List<SavingsGoalProgressViewModel> model = new List<SavingsGoalProgressViewModel>();

            foreach (var goal in goals)
            {
                var item = new SavingsGoalProgressViewModel();

                item.SavingsGoal = goal;
                item.Progress = await _repo.CalculateProgress(goal);

                model.Add(item);
            }

            return View(model);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var goal = await _repo.GetGoal(id);

            if (goal == null)
                return NotFound();

            var model = new SavingsGoalProgressViewModel();
            model.SavingsGoal = goal;
            model.Progress = await _repo.CalculateProgress(goal);

            return View(model);
        }

        public IActionResult Add()
        {
            var model = new SavingsGoal()
            {
                HasDeadline = false,
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SavingsGoal model)
        {
            if (ModelState.IsValid)
            {
                var goals = await _repo.GetList<SavingsGoal>();
                if (!goals.Any())
                    model.IsPinned = true;

                _repo.Add<SavingsGoal>(model);

                if (await _repo.SaveAll())
                    return RedirectToAction("Goals");

                throw new Exception("Something went wrong, trying to add new Savings Goal");
            }

            return View(model);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var goal = await _repo.Find<SavingsGoal>(id);

            if (goal == null)
                return NotFound();

            return View(goal);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SavingsGoal goal)
        {
            if (ModelState.IsValid)
            {
                _repo.Edit<SavingsGoal>(goal);

                if (await _repo.SaveAll())
                    return RedirectToAction("Goals");
            }

            return View(goal);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var goal = await _repo.Find<SavingsGoal>(id);

            if (goal == null)
                return NotFound();

            _repo.Delete<SavingsGoal>(goal);

            if(await _repo.SaveAll())
                return RedirectToAction("Goals");

            return RedirectToAction("Goals");
        }

        [HttpGet]
        public async Task<IActionResult> SetAsPinned(Guid id)
        {
            var goals = await _repo.GetList<SavingsGoal>();

            foreach(var item in goals)
            {
                if (item.Id != id)
                    item.IsPinned = false;
                else
                    item.IsPinned = true;

                _repo.Edit<SavingsGoal>(item);
            }

            if (await _repo.SaveAll())
                return RedirectToAction("Goals");

            throw new Exception("Something went wrong trying to pin this item");
        }
    }
}
