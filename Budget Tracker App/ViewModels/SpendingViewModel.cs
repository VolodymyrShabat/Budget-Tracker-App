using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Budget_Tracker_App.ViewModels
{
    public class SpendingViewModel
    {
        [Required]
        [Display(Name = "Spend Amount ($)")]
        public decimal SpendAmount { get; set; }
        [Required]
        [Display(Name = "Category")]
        public string Category { get; set; }

        public string Date { get; set; }

    }
}
