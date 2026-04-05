using ExpenseTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Core.Interface
{
    public interface IExpenseRepository
    {
        void Add(Expense expense);
        List<Expense> GetAll(int userId);
        Expense? GetById(int id);
        void Delete(int id);
        void Update(Expense expense);
    }
}
