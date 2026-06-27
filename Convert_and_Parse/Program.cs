using System;
namespace Convert_and_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вітаю в тестовій програмі \"Калькулятор віку\"!" + "\n" + new String('=',45));
            Console.Write("Вкажіть свій вік: "); string age = Console.ReadLine();
            bool isAgeValid = int.TryParse(age, out int Age);
            if (isAgeValid && Age > 0 && Age <= 130)
            {
                Console.Write("Введіть кількість років, на яку хочете збільшити вік: "); string yearsToAdd = Console.ReadLine();
                bool isYearsToAddValid = int.TryParse(yearsToAdd, out int YearsToAdd);
                if (isYearsToAddValid && YearsToAdd > 0)
                {
                    if (YearsToAdd == 1)
                    {
                        Console.WriteLine($"Через {YearsToAdd} рік Вам буде {Age+YearsToAdd} років.");
                    }
                    else if (YearsToAdd >= 2 && YearsToAdd <= 4)
                    {
                        Console.WriteLine($"Через {YearsToAdd} роки Вам буде {Age+YearsToAdd} років.");
                    }
                    else
                    {
                        Console.WriteLine($"Через {YearsToAdd} років Вам буде {Age+YearsToAdd} років.");
                    }
                }
                else
                {
                    Console.WriteLine("Помилка! Введіть коректну кількість років (Ціле число більше 0).");
                }
            }
            else
            {
                Console.WriteLine("Помилка! Введіть коректний вік (Ціле число від 1 до 130).");
            }
        }
    }
}