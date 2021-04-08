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
        [Range(0.01, int.MaxValue, ErrorMessage = "Amount must be greater or equal to 0.01")]
        public decimal SpendAmount { get; set; }
        [Required]
        [Display(Name = "Category")]
        public string Category { get; set; }

        public string Date { get; set; }

    }
}
