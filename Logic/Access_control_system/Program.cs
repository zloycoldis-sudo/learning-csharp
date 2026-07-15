using System;
namespace Access_control_system
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine($"""
            =====Вітаю Вас в тестовій програмі "Система контролю доступу"=====
            ==Вкажіть потрібні дані для перевірки доступу на закриту вечірку==
            {new string('=', 66)}
            """);
            Console.Write("Важіть свій повний вік: "); string ageInput = Console.ReadLine();
            bool isAgeValid = int.TryParse(ageInput, out int age);
            if (!isAgeValid || 130 < age || age < 0 )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ВВедіть, будь ласка, коректний вік від 0 до 130 років!");
                Console.ResetColor();
                return;
            }
            Console.Write("У вас є запрошення на вечірку? (+/-)"); string ticketInput = Console.ReadLine();
            bool hasTicket = ticketInput == "+";
            if (age >= 16 && hasTicket)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ви можете відвідати вечірку! Гарного відпочинку!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (age < 16 && !hasTicket)
                {
                    Console.WriteLine("Ви не можете відвідати вечірку! Ваш вік менший за 16 років і у вас немає запрошення!");
                }
                else if (age >= 16 && !hasTicket)
                {
                    Console.WriteLine("Ви не можете відвідати вечірку! У вас немає квитку!");
                }
                else if (age < 16 && hasTicket)
                {
                    Console.WriteLine("Ви не можете відвідати вечірку! Ваш вік менший за 16 років!");
                }
            }
            Console.ResetColor();
        }
    }
}