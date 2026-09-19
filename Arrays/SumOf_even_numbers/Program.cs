using System;
using System.Threading;
namespace SumOf_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Вітаю Вас у програмі підрахунку суми парних чисел!" + "\n" + new string('=',50));
                Console.Write("Введіть числа через пробіл: ");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 0)
                {
                    ShowError("Помилка! Введіть хоча б одне число.");
                    continue;
                }
                int[] numbers = new int[parts.Length];
                bool isValidInput = true;
                for (int i = 0; i < parts.Length; i++)
                {
                    if (!int.TryParse(parts[i], out numbers[i]))
                    {
                        isValidInput = false;
                        break;
                    }
                }
                if (!isValidInput)
                {
                    ShowError("Помилка! Введіть лише числа через пробіл.");
                    continue;
                }
                int numbersSum = 0;
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        numbersSum += number;
                    }
                }
                Console.WriteLine(new string('=',50) + "\n" + $"Сума парних чисел: {numbersSum}\n" + new string('=',50));
                Console.Write("Натисніть будь-яку клавішу, щоб продовжити або Esc, щоб вийти...");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Thread.Sleep(2000);
            Console.ResetColor();
            Console.Clear();
        }
    }
}