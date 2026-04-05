using ExpenseTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Core.Interface
{
    public interface IExpenseService
    {
        void AddExpenseAction(Expense expense);
        List<Expense> GetExpenseAction();
        void DeleteExpenseAction(string desc);
        
    }
}
