using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Budget_Tracker_App.ViewModels
{
    public class EditViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Salary must be greater or equal to 0")]
        public decimal Salary { get; set; }
    }
}
