using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Core.Models
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; } = string.Empty;


        public List<Expense> Expenses { get; set; } = new();
    }
}
