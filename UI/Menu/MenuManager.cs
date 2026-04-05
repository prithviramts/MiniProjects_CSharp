using ExpenseTracker.UI.Screens;
using ExpenseTracker.Utils;

namespace ExpenseTracker.UI.Menu
{
    public class MenuManager
    {
        private readonly ConsoleHelper _consoleHelper;
        private readonly AddExpenseScreen _addExpenseScreen;
        private readonly ViewExpenseScreen _viewExpenseScreen;

        public MenuManager(
            ConsoleHelper consoleHelper,
            AddExpenseScreen addExpenseScreen,
            ViewExpenseScreen viewExpenseScreen)
        {
            _consoleHelper = consoleHelper;
            _addExpenseScreen = addExpenseScreen;
            _viewExpenseScreen = viewExpenseScreen;
        }

        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("Select from below option:");
                Console.WriteLine("1. Add Expense \n2. View Expenses \n3. Delete Expense \n4. Quit");

                int option = _consoleHelper.InputGetter("Enter a valid option to proceed: ");

                switch (option)
                {
                    case 1:
                        _addExpenseScreen.AddExpense();
                        break;
                    case 2:
                        _viewExpenseScreen.DisplayExpense();
                        break;
                    case 3:
                        Console.WriteLine("Delete expense is not implemented yet.");
                        Thread.Sleep(1500);
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
