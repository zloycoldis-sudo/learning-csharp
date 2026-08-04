using System;
using System.Threading;
namespace Range_Sum_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                uint oddNumbersCount = 0, evenNumbersCount = 0, firstNumber = 0, lastNumber = 0;
                Console.WriteLine("Вітаємо Вас у програмі для розрахунку к-сті парних та непарних чисел у певному діапазоні" + "\n" + new string('=', 88));
                try
                {
                    Console.Write("Введіть перше число для діапазону: "); firstNumber = uint.Parse(Console.ReadLine());
                    Console.Write("Введіть кінець діапазону: "); lastNumber = uint.Parse(Console.ReadLine());
                    Console.WriteLine(new string('=',88));
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помилка! Введіть, будь ласка, будь-яке число.");
                    Console.ResetColor();
                    Console.WriteLine(new string('=',88));
                    Thread.Sleep(5000);
                    Console.Clear();
                    continue;
                }
                if (!(firstNumber < lastNumber))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помилка! Перше число не може бути більше кінця діапазону.");
                    Console.ResetColor();
                    Console.WriteLine(new string('=',88));
                    Thread.Sleep(5000);
                    Console.Clear();
                    continue;
                }
                uint currentNumber = firstNumber;
                while (currentNumber <= lastNumber)
                {
                    if (currentNumber % 2 == 0)
                    {
                        evenNumbersCount++;
                    }
                    else
                    {
                        oddNumbersCount++;
                    }
                    currentNumber++;
                }
                Console.WriteLine($"""
                Кількість парних та непарних чисел у діапазоні від {firstNumber} до {lastNumber}: 
                Парні: {evenNumbersCount};
                Непарні: {oddNumbersCount}.
                {new string('=',88)}
                """);
                Console.Write($"Натисніть Enter, щоб продовжити "); Console.ReadLine();
                Thread.Sleep(1000);
                try
                {
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("Помилка! Неможливо очистити екран.");
                }
            }
        }
    }
}
