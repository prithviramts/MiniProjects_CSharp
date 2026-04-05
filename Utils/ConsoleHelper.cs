using System.Text.RegularExpressions;

namespace ExpenseTracker.Utils
{
    public class ConsoleHelper
    {
        public int InputGetterInt(string inputMsg)
        {
            Console.Write(inputMsg);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }

            Console.WriteLine("Invalid input. Please enter a number to proceed");
            return 0;
        }

        public decimal InputGetterDec(string inputMsg)
        {
            Console.Write(inputMsg);
            if (decimal.TryParse(Console.ReadLine(), out decimal result))
            {
                return result;
            }

            Console.WriteLine("Invalid input. Please enter a number to proceed");
            return 0;
        }

        public string InputGetterStr(string inputMsg)
        {
            string? userName;
            do
            {
                Console.Write(inputMsg);
                userName = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(userName) || !userName.All(char.IsLetterOrDigit));

            return userName;
        }
    }
}
