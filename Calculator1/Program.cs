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
            ConsoleKey consoleKey = Console.ReadKey().Key;
            Console.WriteLine("Введіть перше число: "); string firstNumber = Console.ReadLine();
            bool isFirstNumberValid = double.TryParse(firstNumber, )
        }
    }
}
