using System;
using System.Threading;
namespace Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("===Вітаємо Вас в програмі \"Таблиця множення\"===" + "\n" + new string('=',47));
                Console.Write("Введіть множник від 1 до 12: ");
                if (!int.TryParse(Console.ReadLine(), out int multiplier) || multiplier < 1 || multiplier > 12)
                {
                    ShowError("Помилка! Введіть, будь ласка, будь-яке число від 1 до 12.");
                    continue;
                }
                Console.Clear();
                Console.WriteLine($"Таблиця множення на {multiplier}" + "\n" + new string('=',65));
                for (int multiplicand = 1; multiplicand <= 12; multiplicand++)
                {
                    Console.WriteLine($"{multiplier} x {multiplicand} = {multiplier * multiplicand}");
                }
                Console.WriteLine(new string('=',65) + "\n" + "Натисніть будь-яку клавішу для повторного запуску програми або ESC для виходу.");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
                Console.Clear();
            }
        }
        static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
