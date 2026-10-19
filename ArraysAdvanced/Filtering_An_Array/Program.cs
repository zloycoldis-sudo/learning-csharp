using System;
using System.Threading;
namespace Filtering_An_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Вкажіть кількість елементів масиву(або q для виходу): ");
                string input = Console.ReadLine();
                if (input?.ToLower() == "q") break;
                if (!int.TryParse(input, out int countElements) || countElements <= 0)
                {
                    ShowError("Помилка! Вкажіть кількість елементів масиву цілим числом.");
                    continue;
                }
                int[] originalArray = new int[countElements];
                int evenCount = 0;
                for (int i = 0; i < countElements; i++)
                {
                    Console.Clear();
                    Console.Write($"Вкажіть елемент №{i + 1}: ");
                    string? inputElement = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(inputElement))
                    {
                        ShowError("Помилка! Вкажіть елемент цілим числом.");
                        i--;
                        continue;
                    }
                    if (!int.TryParse(inputElement, out int element))
                    {
                        ShowError("Помилка! Вкажіть елемент цілим числом.");
                        i--;
                        continue;
                    }
                    if (element % 2 == 0) evenCount++;
                    originalArray[i] = element;
                }
                int[] copyArray = new int[evenCount];
                int indexCopyArrayEl = 0;
                for (int i = 0; i < originalArray.Length; i++)
                {
                    if (originalArray[i] % 2 == 0)
                    {
                        copyArray[indexCopyArrayEl] = originalArray[i];
                        indexCopyArrayEl++;
                    }
                }
                Console.Clear();
                Console.WriteLine($"Оригінальний масив: {string.Join(", ", originalArray )}" + "\n" + $"Масив з парними елеменатми: {string.Join(", ", copyArray)}");
                Console.Write("Натисніть будь-яку клавішу, щоб повернутися до меню..." + "\n" + "або ESC для виходу...");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        static void ShowError(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}