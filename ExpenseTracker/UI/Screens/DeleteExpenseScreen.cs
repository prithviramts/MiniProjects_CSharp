using ExpenseTracker.Application.Controllers;
using ExpenseTracker.Application.Session;
using ExpenseTracker.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.UI.Screens
{
    public class DeleteExpenseScreen
    {
        private readonly ExpenseController _controller;
        private readonly ViewExpenseScreen _viewExpScreen;
        private readonly ConsoleHelper _validator;

        public DeleteExpenseScreen(ExpenseController controller, ViewExpenseScreen viewExp, ConsoleHelper validator)
        {
            _controller = controller;
            _viewExpScreen = viewExp;
            _validator = validator;
        }

        public void DeleteExpense()
        {
            Console.WriteLine("Type the correct description to delete it from expense");
            _viewExpScreen.DisplayExpense();

            string desc = _validator.InputGetterStr("Valid description: ");

            _controller.DeleteExpense(desc);

            Console.WriteLine("Value deleted successfully");
            Console.Clear();
            _viewExpScreen.DisplayExpense();

        }
    }
}
