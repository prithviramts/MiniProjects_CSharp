using ExpenseTracker.Application.Session;
using ExpenseTracker.Core.Interface;
using ExpenseTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Core.Service
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _repository;
        private readonly UserSession _user;
        public ExpenseService(IExpenseRepository repository, UserSession user)
        {
            _repository = repository;
            _user = user;
        }

        public void AddExpenseAction(Expense expense)
        {
            if (expense.Amount <= 0)
                throw new Exception("Amount must be greater than 0");
            _repository.Add(expense);
        }

        public List<Expense> GetExpenseAction()
        {
            return _repository.GetAll(_user.UserId);
        }

        public void DeleteExpenseAction(int id)
        {
            _repository.Delete(id);
        }
    }
}
