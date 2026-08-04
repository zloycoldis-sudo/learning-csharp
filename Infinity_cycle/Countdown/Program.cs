using System;
using System.Threading;
namespace Countdown
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введіть кількість секунд до старту: ");
                if (int.TryParse(Console.ReadLine(), out int seconds) && seconds > 0)
                {
                    while (seconds > 0)
                    {
                        Console.WriteLine($"{seconds}....");
                        Thread.Sleep(1000);
                        seconds--;
                    }
                    Console.WriteLine("Старт!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введіть, будь ласка, число від 0");
                    Console.ResetColor();
                    Thread.Sleep(5000);
                    Console.Clear();
                    continue;
                }
                Console.WriteLine($"""
                {new string('-', Console.WindowHeight - 1)}
                Натисніть Enter для повторення коду
                """);
                Console.ReadLine();
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
    }
}
