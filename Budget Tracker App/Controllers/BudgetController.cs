using Budget_Tracker_App.Models;
using Budget_Tracker_App.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Budget_Tracker_App.Controllers
{
    [Authorize]
    public class BudgetController : Controller
    {
        private ApplicationDbContext _db;
        private readonly UserManager<User> _UserManager;
        private string IdOfCurrentUser;
        public BudgetController(ApplicationDbContext db, UserManager<User> userManager)
        {
           
            _db = db;
            _UserManager = userManager;
            
        }

        [HttpGet]
        public IActionResult GetStat(string date)
        {
        
            IdOfCurrentUser = _UserManager.GetUserId(HttpContext.User);
            string k = IdOfCurrentUser;
            var datex = (int)Month.Parse(typeof(Month), date.Split(" ")[0], true);
            var s = _db.Spendings.Select(x => x.Date.Month).First().ToString();
            var spendings = _db.Spendings.Where(x => x.Date.Month == datex && x.UserId == IdOfCurrentUser).ToList();
            UserNameSpendingViewModel result = new UserNameSpendingViewModel { spendings = spendings, Salary = _db.Users.Where(x => x.Id == IdOfCurrentUser).First().Salary };
            var fd = result.Salary;
            return PartialView("_SpendingMonthPartial",result);
        }


        [HttpGet]
        public IActionResult GetSpendings(string date)
        {
            IdOfCurrentUser = _UserManager.GetUserId(HttpContext.User);
            var spendings = _db.Spendings.Where(x => x.Date == DateTime.Parse(date)&&x.UserId==IdOfCurrentUser).ToList();
            return PartialView("_SpendingPartial", spendings);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Statistic()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index (SpendingViewModel spendingViewModel)
        {
            if(ModelState.IsValid)
            {
                var s = spendingViewModel;
                bool CategoryInDayExists = _db.Spendings.Where(x => x.Date == DateTime.Parse(spendingViewModel.Date)).Select(x=>x.Category).Any(x=>x==spendingViewModel.Category);
                if (CategoryInDayExists)
                {
                    var result = _db.Spendings.Where(x => x.Date == DateTime.Parse(spendingViewModel.Date) && x.Category == spendingViewModel.Category).FirstOrDefault();
                    result.SpendAmount += spendingViewModel.SpendAmount;
                    await _db.SaveChangesAsync();
                    return View();
                }
                else
                {
                    _db.Spendings.Add(new Spending { Date = DateTime.Parse(spendingViewModel.Date), Category = spendingViewModel.Category.ToLower(), SpendAmount = spendingViewModel.SpendAmount, UserId = _UserManager.GetUserId(HttpContext.User)
                });
                    await _db.SaveChangesAsync();
                    return View();
                }
                
            }
            return View(spendingViewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Spending s = await _db.Spendings.FirstOrDefaultAsync(p => p.Id == id);
                if (s != null)
                    return View(s);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Spending spending)
        {
            _db.Spendings.Update(spending);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Spending s = await _db.Spendings.FirstOrDefaultAsync(p => p.Id == id);
                _db.Spendings.Remove(s);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }


    }
}
