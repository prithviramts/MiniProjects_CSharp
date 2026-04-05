using ExpenseTracker.Application.Session;
using ExpenseTracker.UI.Screens;
using ExpenseTracker.Utils;

namespace ExpenseTracker.UI.Menu
{
    public class MenuManager
    {
        private readonly ConsoleHelper _consoleHelper;
        private readonly AddExpenseScreen _addExpenseScreen;
        private readonly ViewExpenseScreen _viewExpenseScreen;
        private readonly DeleteExpenseScreen _deleteExpense;
        private readonly UserSession _user;

        public MenuManager(
            ConsoleHelper consoleHelper,
            AddExpenseScreen addExpenseScreen,
            ViewExpenseScreen viewExpenseScreen,
            DeleteExpenseScreen deleteExpense,
            UserSession user)
        {
            _consoleHelper = consoleHelper;
            _addExpenseScreen = addExpenseScreen;
            _viewExpenseScreen = viewExpenseScreen;
            _deleteExpense = deleteExpense;
            _user = user;
        }

        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("Select from below option:");
                Console.WriteLine("1. Add Expense \n2. View Expenses \n3. Delete Expense \n4. Quit");

                int option = _consoleHelper.InputGetterInt("Enter a valid option to proceed: ");

                switch (option)
                {
                    case 1:
                        _addExpenseScreen.AddExpense(_user.UserId);
                        break;
                    case 2:
                        _viewExpenseScreen.DisplayExpense();
                        break;
                    case 3:
                        _deleteExpense.DeleteExpense();
                        break;
                    case 4:
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Select a valid option.");
                        Thread.Sleep(1500);
                        break;
                }
            }
        }
    }
}
