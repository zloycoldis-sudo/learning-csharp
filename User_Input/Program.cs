using System;
using System.Globalization;
namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo nfi = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };
            Console.WriteLine("---Реєстрація на навчання---");
            Console.Write("Введіть своє ім'я: "); string name = Console.ReadLine();
            Console.Write("Введіть свій рік народження: "); int age = int.Parse(Console.ReadLine());
            Console.Write("Вкажіть бюджет на місяць: "); double budget = double.Parse(Console.ReadLine(), nfi);
            double dailyBudget = budget / 30;
            Console.WriteLine($"""
            ----Ваш чек на навчання----
            Ім'я студента: {name}
            Вік: {2026-age} років
            Бюджет на день: {dailyBudget.ToString("F2", nfi)} грн.
            """);
        }
    }
}