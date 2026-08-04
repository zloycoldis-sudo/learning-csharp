using System;
using System.Threading;
namespace Financial_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 0, interest = 0, limitMoney = 0;
            while (true)
            {
                Console.WriteLine("===Вітаємо в програмі \"Фінансовий калькулятор складених відсотків\"===" + "\n" + new string('=',69));
                try
                {
                    Console.Write("Вкажіть початкову суму(грн.): "); money = double.Parse(Console.ReadLine());
                    Console.Write("Вкажіть відсоток за кожний рік(Тільки числом): "); interest = double.Parse(Console.ReadLine());
                    Console.Write("Вкажіть ліміт суми: "); limitMoney = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    ShowError("Помилка! Введіть, будь ласка, будь-яке число.");
                    continue;
                }
                if (money <= 0)
                {
                    ShowError("Помилка! Сума не може бути від'ємною.");
                    continue;
                }
                if (interest <= 0)
                {
                    ShowError("Помилка! Відсоток не може бути від'ємним.");
                    continue;
                }
                if (limitMoney <= money)
                {
                    ShowError("Помилка! Ліміт суми не може бути меншим за початкову суму.");
                    continue;
                }
                int years = 0;
                double currentMoney = money;
                while (currentMoney < limitMoney)
                {
                    currentMoney += currentMoney * interest / 100;
                    years++;
                }
                Console.WriteLine(new string('=',69));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Через {years} років, з річної відсоткової ставки {interest}%, початкова сума {money} грн. досягне ліміту {currentMoney:F2} грн.");
                Console.ResetColor();
                Console.WriteLine(new string('=',69));
                Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити або ESC для виходу.");
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                Thread.Sleep(2000);
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