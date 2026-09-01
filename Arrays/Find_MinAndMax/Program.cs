using System;
using System.Linq;
using System.Threading;
namespace Find_minAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===Вітаю Вас у програмі пошуку мінімального та максимального значення!===" + "\n" + new string('=',73));
                Console.Write("Введіть числа через пробіл: ");
                int[] numbers;
                try
                {
                    string input = Console.ReadLine();
                    numbers = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
                }
                catch (Exception)
                {
                    ShowError("Помилка! Введіть лише числа через пробіл.");
                    continue;
                }
                if (numbers.Length == 0)
                {
                    ShowError("Помилка! Введіть хоча б одне число.");
                    continue;
                }
                int min = numbers[0], max = numbers[0];
                foreach (int number in numbers)
                {
                    if (number < min)
                        min = number;
                    if (number > max)
                        max = number;
                }
                Console.WriteLine(new string('=',73) + "\n" + $"Мінімальне значення: {min}\nМаксимальне значення: {max}\n {new string('=',73)}");
                Console.Write("Натисніть будь-яку клавішу, щоб продовжити або Esc, щоб вийти...");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    break;
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