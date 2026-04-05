using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Core.Models
{
    public class Expense
    {
        public int id { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime DateAdded { get; set; }


        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
