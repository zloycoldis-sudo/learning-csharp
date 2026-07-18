using System;
namespace Weekday_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Вітаю Вас в тестовій програмі \"Калькулятор днів тижня\"===" + "\n" + new string('=',60));
            Console.Write("Введіть день тижня(1-7): "); string dayInput = Console.ReadLine();
            bool isDayValid = int.TryParse(dayInput,out int day);
            if (!isDayValid || day < 1 || day > 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Помилка! Введіть ,будь ласка, число від 1 до 7.");
                Console.ResetColor();
                return;
            }
            switch (day)
            {
                case 1:
                    Console.Write($"{day} -й день тижня - Понеділок. ");
                    break;
                case 2:
                    Console.Write($"{day} -й день тижня - Вівторок. ");
                    break;
                case 3:
                    Console.Write($"{day} -й день тижня - Середа. ");
                    break;
                case 4:
                    Console.Write($"{day} -й день тижня - Четвер. ");
                    break;
                case 5:
                    Console.Write($"{day} -й день тижня - П'ятниця. ");
                    break;
                case 6:
                    Console.Write($"{day} -й день тижня - Субота. ");
                    break;
                case 7:
                    Console.Write($"{day} -й день тижня - Неділя. ");
                    break;
            }

            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Це робочий день.");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Це вихідний день.");
                    break;
            }
        }
    }
}