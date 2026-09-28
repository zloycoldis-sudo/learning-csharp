// це перший калькУлятор. Не бийте мене, будь ласка. Я ще вчуся програмувати.
using System;
using System.Globalization;
using System.Threading;
namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo customCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;
            while (true)
            {
                double firstNumber,secondNumber;
                try
                {
                    Console.Write("Введіть перше число: "); firstNumber = double.Parse(Console.ReadLine());
                    Console.Write("Введіть друге число: "); secondNumber = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помилка! Введіть, будь ласка, будь-яке число.");
                    Console.ResetColor();
                    continue;
                }
                Console.Write("Вкажіть бажану операцію над числами('+','-','*','/'): "); char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine(new string('=',60));
                Console.ForegroundColor = ConsoleColor.Green;
                switch (operation)
                {
                    case '+':
                        Console.WriteLine($" Результат: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                        break;
                    case '-':
                        Console.WriteLine($" Результат: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                        break;
                    case '*':
                        Console.WriteLine($" Результат: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                        break;
                    case '/':
                        string result = (secondNumber == 0) ? "Помилка! На 0 ділити не можна." : $" Результат: {firstNumber} / {secondNumber} = {firstNumber / secondNumber}" ;
                        if (secondNumber == 0) Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(result);
                        break;
                }
                Console.ResetColor();
                Console.WriteLine($"{new string('=',60)} \nНатисніть Enter, щоб продовжити");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}