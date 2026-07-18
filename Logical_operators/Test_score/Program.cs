using System;
namespace Test_score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Авторизація студента***");
            Console.Write("Введіть свій логін: "); string login = Console.ReadLine();
            Console.Write("Введіть свій бал за екзамен(0-100): "); string scoreInput = Console.ReadLine();
            bool isScoreValid = int.TryParse(scoreInput, out int score);
            if (!isScoreValid || score < 0 || score > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Помилка! Введіть ,будь ласка , свій бал від 0 до 100.");
                Console.ResetColor();
                return;
            }
            string result = (score >= 60) ? $"Вітаємо, {login}! Ви склали екзамен." : $"На жаль, {login}, Ви не склали екзамен!" ;
            Console.ForegroundColor = (score >= 60) ? ConsoleColor.Green : ConsoleColor.Red ;
            Console.WriteLine(result);
            Console.ResetColor();
        }
    }
}