using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("===Вітаю Вас в тестовому додатку \"Калькулятор валют\"=== " + "\n" + new string('=', 55));
        Console.Write("Введіть суму в грн.: "); string amountInput = Console.ReadLine();
        bool isAmountValid = double.TryParse(amountInput, out double amount);
        if (!isAmountValid || amount <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неправильно введена сума! Будь ласка, введіть суму більше нуля.");
            Console.ResetColor();
            return;
        }
        Console.Write("Чи бажаєте врахувати комісію банку? (+/-): "); string commision = Console.ReadLine();
        if (commision != "+" && commision != "-")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неправильно введено значення! Будь ласка, введіть '+' або '-'.");
            Console.ResetColor();
            return;
        }
        Console.Write("Введіть поточний курс валюти, яку бажаєте купити: "); string rateInput = Console.ReadLine();
        bool isRateValid = double.TryParse(rateInput, out double rate);
        if (!isRateValid || rate <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неправильно введено курс валюти! Будь ласка, введіть число більше 0");
            Console.ResetColor();
            return;
        }
        Console.Write("Вкажіть назву валюти, яку бажаєте купити(Наприклад: USD, EUR, RUB): "); string currencyName = Console.ReadLine();
        if (commision == "+")
        {
            Console.Write("Введіть відсоток комісії банку(Наприклад: 1.5): "); string commisionInput = Console.ReadLine();
            bool isCommisValid = double.TryParse(commisionInput, out double commisionPercent);
            if (!isCommisValid || commisionPercent <= 0 || commisionPercent >= 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильно введено відсоток комісії! Будь ласка, введіть число більше 0 та менше 100.");
                Console.ResetColor();
                return;
            }
            Console.WriteLine($"""
            {new string('=', 55)}
            Ви отримаєте {amount * (1 - commisionPercent / 100) / rate:F2} {currencyName}
            Комісія (в грн.): {amount * (commisionPercent / 100):F2}
            {new string('=', 55)}
            """);
        }
        else if (commision == "-")
        {
            Console.WriteLine($"""
            {new string('=', 55)}
            Ви отримаєте {amount / rate:F2} {currencyName}
            Комісія (в грн.): 0.00
            {new string('=', 55)}
            """);
        }
    }
}
