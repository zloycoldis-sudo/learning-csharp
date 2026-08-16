using System;
using System.Threading;
namespace inverted_triangle2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введіть довжину основи трикутника: ");
                if (!int.TryParse(Console.ReadLine(), out int baseLength) || baseLength <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помилка! Вкажіть, будь ласка, додатне ціле число.");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                Console.Clear();
                Console.WriteLine($"Трикутник з довжиною основи {baseLength}: " + "\n" + new string('=', 80));
                for (int i = 0; i < baseLength; i++)
                {
                    for (int j = 0; j<= i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = baseLength; k > i; k--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('=', 80) + "\n" + "Для продовження натисніть будь-яку клавішу або ESC для завершення програми.");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                Console.Clear();
            }
        }
    }
}