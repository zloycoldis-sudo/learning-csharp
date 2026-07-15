using System;
namespace Check_num_for_parity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"""
            ===Вітаю Вас в тестовій програмі "Перевірка числа на парність"===
            {new string('=', 65)}
            """);
            Console.Write("Введіть число для перевірки на парність: ");
            string numberInput = Console.ReadLine();
            bool isNumberValid = long.TryParse(numberInput, out long number);
            if (!isNumberValid)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введіть, будь ласка, коректне число!");
                Console.ResetColor();
                return;
            }
            string result = (number % 2 == 0) ? $"Число {number} є парним." : $"Число {number} є непарним.";
            Console.WriteLine(result);
        }
    }
}

