using System;
using System.Threading;
namespace SumOf_even_num
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Вітаю Вас в програмі \"Сума парних чисел в певному діапазоні\" " + "\n" + new string('=', 60));
                Console.Write("Введіть початкове число діапазону(від 0): ");
                if (!long.TryParse(Console.ReadLine(), out long start) || start < 0)
                {
                    ShowError("Помилка! Введіть, будь ласка, будь-яке число від 0.");
                    continue;
                }
                Console.Write("Введіть кінець діапазону: ");
                if (!long.TryParse(Console.ReadLine(), out long end) || end < start)
                {
                    ShowError("Помилка! Кінець діапазону має бути не меншим за початок.");
                    continue;
                }
                Console.WriteLine(new string('=',60));
                long sum = 0;
                for(long i = start; i <= end; i++)
                {
                    if(i % 2 == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine($"Сума парних чисел в діапазоні [{start}, {end}]: {sum}");
                Console.WriteLine(new string('=',60) + "\n" + "Натисніть будь-яку клавішу для повторного запуску програми або ESC для виходу.");
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