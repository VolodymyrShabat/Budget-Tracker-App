using Budget_Tracker_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budget_Tracker_App.ViewModels
{
    public class UserNameSpendingViewModel
    {
        public decimal Salary { get; set; }
        public IEnumerable<Spending> spendings { get; set; }
    }

}
