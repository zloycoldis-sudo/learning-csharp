using System;
namespace Day2_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вкажіть своє ім'я: "); string name = Console.ReadLine();
            Console.Write("Вкажіть свій вік: "); int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вкажіть свій зріст (м): "); double height = Convert.ToDouble(Console.ReadLine());
            //Result
            Console.WriteLine($"Вітаю, {name}! \nВаш вік: {age} років \nВаш зріст: {height} метрів");
        }
    }
}