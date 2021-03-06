using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Budget_Tracker_App.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirm { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Salary must be greater or equal to 0")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }
    }
}
