using System;
using System.Threading;
namespace Unblock_console
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "Bohdan01";
            string password = "CSharp69";
            string inputLogin = ""; string inputPassword = "";
            while (inputLogin != login || inputPassword != password)
            {
                Console.WriteLine($"""
                =====Авторизація в системі=====
                {new string('=', 31 )}
                """);
                Console.Write("Введіть логін(до 8 символів): "); inputLogin = Console.ReadLine();
                if (inputLogin.Length > 8)
                {
                    ShowError("Помилка! Логін має містити не більше 8 символів.");
                    continue;
                }
                Console.Write("Введіть пароль(до 8 символів): "); inputPassword = Console.ReadLine();
                if (inputPassword.Length > 8)
                {
                    ShowError("Помилка! Пароль має містити не більше 8 символів.");
                    continue;
                }
                if (inputLogin == login && inputPassword == password)
                {
                    break;
                }
                if (inputLogin != login && inputPassword != password)
                {
                    ShowError("Помилка! Невірний логін і пароль.");
                    continue;
                }
                else if (inputLogin != login)
                {
                    ShowError("Помилка! Невірний логін.");
                    continue;
                }
                else
                {
                    ShowError("Помилка! Невірний пароль.");
                    continue;
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("""
            ==========================
            ===Успішна авторизація!===
            ==========================
            """);
            Console.ResetColor();
        }
        static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Thread.Sleep(3500);
            Console.Clear();
        }
    }
}