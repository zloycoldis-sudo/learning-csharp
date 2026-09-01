using System;
using System.Threading;
namespace Input_array
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write(new string('-',50) + "\nВведіть к-сть чисел для створення массиву: "); 
                if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
                {
                    ShowError("Помилка! Введіть число більше нуля.");
                    continue;
                }
                Console.WriteLine(new string('-', 50));
                int[] numbers = new int[count];
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Введіть число під номером {i+1}: ");
                    if (!int.TryParse(Console.ReadLine(), out int number))
                    {
                        ShowError("Помилка! Введіть число.");
                        i--;
                        continue;
                    }
                    numbers[i] = number;
                }
                Console.WriteLine(new string('-', 50) + "\nВиведення масиву навпаки: ");
                for (int j = count-1; j >= 0; j--)
                {
                    Console.WriteLine($"Число під номером {j+1}: {numbers[j]}");
                }
                Console.WriteLine(new string('-', 50) + "\nНатисніть будь-яку клавішу, щоб продовжити або Esc, щоб вийти...");
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
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}