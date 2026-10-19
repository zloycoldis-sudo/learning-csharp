using System;
using System.Threading;
namespace Dynamic_add_elem_byUser
{
    class Program
    {
        static void Main(string[] atgs)
        {
            do
            {
                Console.Clear();
                int[] numbers = new int[0];
                do
                {
                    Console.Clear();
                    Console.Write($"Введіть {numbers.Length + 1}-е ціле число для додавання в масив(або натисніть Enter, щоб завершити ввід): ");
                    string input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input)) break;
                    if (!int.TryParse(input, out int number))
                    {
                        ShowError("Помилка! Введіть ціле число.");
                        continue;
                    }
                    Array.Resize(ref numbers, numbers.Length + 1);
                    numbers[numbers.Length - 1] = number;
                }
                while (true);
                Console.Clear();
                if (numbers.Length > 0) Console.WriteLine($"Ви створили масив з {numbers.Length} елементами.\n {string.Join(", ", numbers) }" );
                else Console.WriteLine("Ви не створили масив.");
                Console.WriteLine("Натисніть будь-яку клавішу, щоб почати запис нових чисел...\nНатисніть Esc, щоб вийти з програми...");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    break;
                }
            }
            while (true);
        }
        static void ShowError(string messageError)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(messageError);
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}