using System;
using System.Threading;
namespace guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("=== Гра \"Вгадай число від 1 до 30\" ===" + "\n" + new string('=', 38));
                Random random = new Random();
                int secretNumber = random.Next(1, 31);
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("""
                ===========================
                =  Оберіть складність     =
                = 1 - легко(7 спроб)      =
                = 2 - нормально(5 спроб)  =
                = 3 - складно(3 спроби)   =
                ===========================
                """);
                if (!int.TryParse(Console.ReadLine(), out int mode) || mode < 1 || mode > 3)
                {
                    ShowError("Помилка. Введіть число від 1 до 3.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                int guess = 0;
                int maxAttempts = mode switch
                {
                    1 => 7,
                    2 => 5,
                    3 => 3,
                    _ => 0
                };
                int usedAttempts = 0;
                bool isCorrect = false;
                int j = 0;
                for (int i = maxAttempts; i > 0; i--)
                {
                    Console.Clear();
                    Console.Write($"Вкажіть число від 1 до 30(залишилося {i} спроб): ");
                    if (!int.TryParse(Console.ReadLine(), out guess) || guess < 1 || guess > 30)
                    {
                        ShowError("Помилка. Введіть число від 1 до 30.");
                        i++;
                        continue;
                    }
                    usedAttempts++;
                    if (guess == secretNumber)
                    {
                        isCorrect = true;
                        j = i;
                        break;
                    }
                    if (i > 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (guess > secretNumber)
                            Console.WriteLine($"Не вгадав! Загадане число менше. Спробуй ще.");
                        else
                            Console.WriteLine($"Не вгадав! Загадане число більше. Спробуй ще.");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                    }
                }
                if (isCorrect)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Ви вгадали число {secretNumber}! Кількість витрачених спроб: {usedAttempts}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ви не вгадали число {secretNumber}! Кількість витрачених спроб: {usedAttempts}");
                    Console.ResetColor();
                }
                Console.WriteLine(new string('=', 50) + "\n" + "Натисніть будь-яку клавішу для повернення до головного екрану або ESC для виходу.");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            while (true);
        }
        static void ShowError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
            Thread.Sleep(1500);
        }
    }
}