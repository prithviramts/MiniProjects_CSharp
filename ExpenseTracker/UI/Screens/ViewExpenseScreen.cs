using ExpenseTracker.Application.Controllers;

namespace ExpenseTracker.UI.Screens
{
    public class ViewExpenseScreen
    {
        private readonly ExpenseController _controller;

        public ViewExpenseScreen(ExpenseController controller)
        {
            _controller = controller;
        }

        public void DisplayExpense()
        {
            Console.Clear();
            Console.WriteLine("View your expense below:");

            var expenses = _controller.GetAllExpenses();
            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses found.");
            }
            else
            {
                foreach (var expense in expenses)
                {
                    Console.WriteLine($"{expense.Description} | {expense.Amount:C}");
                }
            }
            Console.ReadKey();
        }
    }
}
