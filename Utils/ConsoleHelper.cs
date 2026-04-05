namespace ExpenseTracker.Utils
{
    public class ConsoleHelper
    {
        public int InputGetter(string inputMsg)
        {
            Console.Write(inputMsg);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }

            Console.WriteLine("Invalid input. Please enter a number to proceed");
            return 0;
        }

        public decimal InputGetter()
        {
            if (decimal.TryParse(Console.ReadLine(), out decimal result))
            {
                return result;
            }

            Console.WriteLine("Invalid input. Please enter a number to proceed");
            return 0;
        }
    }
}
