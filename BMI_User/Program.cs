using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("=Вітаю Вас в тестовому додатку для розрахунку індексу маси тіла(ІМТ)!=" + "\n" + new string('=', 70));
        Console.Write("Введіть свою вагу(кг): "); string weightInput = Console.ReadLine();
        bool isWeightValid = double.TryParse(weightInput, out double weight);
        if (!isWeightValid || weight <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неправильно введена вага! Будь ласка, введіть додатне число.");
            return;
        }
        Console.Write("Введіть свій зріст(м): "); string heightInput = Console.ReadLine();
        bool isHeightValid = double.TryParse(heightInput, out double height);
        if (!isHeightValid || height <= 0 || height > 2.5)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неправильно введений зріст! Будь ласка, введіть додатне число в межах 0-2.5.");
            return;
        }
        double bmi = weight / (height * height);
        Console.WriteLine(new string('=', 70));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Ваш ІМТ: {bmi:F2} ");
        Console.ResetColor();
        Console.WriteLine($"""
        Нормальний ІМТ для дорослих становить від 18.5 до 24.9.
        {new string('=', 70)}
        """);
    }
}