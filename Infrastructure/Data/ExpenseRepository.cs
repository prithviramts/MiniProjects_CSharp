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

        public void Delete(int id, string desc)
        {
            var expenses = _context.Expenses.Where(x => x.UserId == id && x.Description == desc).ToList();
            foreach (var expense in expenses)
            {
                _context.Expenses.Remove(expense);
            }
            _context.SaveChanges();
        }

        public void Update(Expense expense)
        {
            _context.Expenses.Update(expense);
            _context.SaveChanges();
        }

    }
}
