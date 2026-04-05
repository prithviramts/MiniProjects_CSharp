using ExpenseTracker.Core.Interface;
using ExpenseTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Application.Controllers
{
    public class ExpenseController
    {
        private readonly IExpenseService _service;
        public ExpenseController(IExpenseService service)
        {
            _service = service;
        }

        public void AddExpense(string desc, decimal amount, int userId)
        {
            var expense = new Expense
            {
                Description = desc,
                Amount = amount,
                UserId = userId
            };

            _service.AddExpenseAction(expense);
        }

        public List<Expense> GetAllExpenses()
        {
            return _service.GetExpenseAction();
        }

        public void DeleteExpense(string desc)
        {
            _service.DeleteExpenseAction(desc);
        }
    }
}
