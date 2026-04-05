using ExpenseTracker.Application.Controllers;
using ExpenseTracker.Application.Session;
using ExpenseTracker.Utils;

namespace ExpenseTracker.UI.Screens
{
    public class AddExpenseScreen
    {
        private readonly ExpenseController _controller;
        private readonly ConsoleHelper _consoleHelper;

        public AddExpenseScreen(ExpenseController controller, ConsoleHelper consoleHelper)
        {
            _controller = controller;
            _consoleHelper = consoleHelper;
        }

        public void AddExpense(int userId)
        {
            Console.WriteLine("Please enter the below details to add the expense:");
            Console.Write("Description : ");
            var desc = Console.ReadLine() ?? string.Empty;
            var amt = _consoleHelper.InputGetterDec("Amount (in decimal too) : ");

            _controller.AddExpense(desc, amt, userId);

            Console.WriteLine("Value added successfully.");
            Thread.Sleep(1000);
        }
    }
}
