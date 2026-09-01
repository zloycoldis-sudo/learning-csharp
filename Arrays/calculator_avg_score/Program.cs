using System;
using System.Linq;
using System.Threading;
namespace calculator_avg_score
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===Вітаю Вас у калькуляторі середнього балу!===" + "\n" + new string('=',47));
                Console.Write("Введіть бали через пробіл (1-100): ");
                int[] scores;
                try
                {
                    string input = Console.ReadLine();
                    scores = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
                }
                catch (Exception)
                {
                    ShowError("Помилка! Введіть лише числа від 1 до 100, через пробіл.");
                    continue;
                }
                if (scores.Length == 0 || scores.Any(x => x < 1 || x > 100))
                {
                    ShowError("Помилка! Введіть лише числа від 1 до 100, через пробіл.");
                    continue;
                }
                double sumScores = 0;
                foreach (int score in scores)
                {
                    sumScores += score;
                }
                Console.WriteLine(new string('=',47) + "\n" + $"Середній бал: {sumScores / scores.Length:F2}");
                Console.Write("Натисніть будь-яку клавішу, щоб продовжити або Esc, щоб вийти...");
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