using ExpenseTracker.Application.Controllers;
using ExpenseTracker.Application.Session;
using ExpenseTracker.Utils;

namespace ExpenseTracker.UI.Screens
{
    public class AddExpenseScreen
    {
        private readonly ExpenseController _controller;
        private readonly ConsoleHelper _consoleHelper;
        private readonly UserSession _user;

        public AddExpenseScreen(ExpenseController controller, ConsoleHelper consoleHelper, UserSession user)
        {
            _controller = controller;
            _consoleHelper = consoleHelper;
            _user = user;
        }

        public void AddExpense()
        {
            Console.WriteLine("Please enter the below details to add the expense:");
            Console.Write("Description : ");
            var desc = Console.ReadLine() ?? string.Empty;
            Console.Write("Amount (in decimal) : ");
            var amt = _consoleHelper.InputGetter();

            _controller.AddExpense(desc, amt, _user.UserId);

            Console.WriteLine("Value added successfully.");
            Thread.Sleep(1000);
        }
    }
}
