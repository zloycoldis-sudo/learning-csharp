using System;
using System.Threading;
namespace Find_first_divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Вітаю Вас в програмі \"Пошук першого дільника числа\"" + "\n" + new string('=',50));
                Console.Write("Введіть ціле число більше 0: ");
                if (!long.TryParse(Console.ReadLine(), out long number) || number <= 0)
                {
                    ShowError("Помилка! Введіть, будь ласка, будь-яке ціле число більше 0.");
                    continue;
                }
                Console.WriteLine(new string('=',50));
                if (number == 1)
                {
                    Console.WriteLine("Число 1 не має дільників, крім самого себе.");
                }
                else
                {
                    bool found = false;
                    for (long divisor = 2; divisor * divisor <= number; divisor++)
                    {
                        if (number % divisor == 0)
                        {
                            Console.WriteLine($"Перший дільник числа {number} - {divisor}");
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine($"Число {number} є простим.");
                    }
                }
                ShowSuccess("Програма виконана успішно!");
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
        static void ShowSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine(new string('=',50) + "\n" + "Натисніть будь-яку клавішу для повторного запуску програми або ESC для виходу.");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            Console.Clear();
        }
    }
}