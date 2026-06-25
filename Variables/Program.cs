using System;
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вкажіть своє ім'я: "); string name = Console.ReadLine();
            Console.Write("Вкажіть свій вік(ціле число): "); int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вкажіть свій зріст (м): "); double height = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Ви студент? (true/false): "); bool status = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"""
Вітаю, {name}! Ваша анкета готова
{new string('=', 40)}
Ваше ім'я: {name}
Ваш вік: {age} років
Ваш зріст: {height} метрів
Статус студента: {status}
""");

        }
    }
}