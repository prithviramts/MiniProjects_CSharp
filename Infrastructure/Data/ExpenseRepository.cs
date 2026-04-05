using ExpenseTracker.Core.Interface;
using ExpenseTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Infrastructure.Data
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly AppDbContext _context;
        public ExpenseRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Expense expense)
        {
            _context.Expenses.Add(expense);
            _context.SaveChanges();
        }

        public List<Expense> GetAll(int userId)
        {
            return _context.Expenses
                .Where(e => e.UserId == userId)
                .ToList();
        }

        public Expense? GetById(int id)
        {
            return _context.Expenses.Find(id);
        }

        public void Delete(int id)
        {
            var expense = _context.Expenses.Find(id);
            if (expense != null)
            {
                _context.Expenses.Remove(expense);
                _context.SaveChanges();
            }
        }

        public void Update(Expense expense)
        {
            _context.Expenses.Update(expense);
            _context.SaveChanges();
        }

    }
}
