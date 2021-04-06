using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budget_Tracker_App.Models
{
    public class User:IdentityUser
    {
        public decimal Salary { get; set; }
    }
}
