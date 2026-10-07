using System;
using System.Threading;
namespace Student_grades_bySemester
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write(new string('-', 50) + "\nВведіть к-сть студентів, або Q, щоб вийти: ");
                string input = Console.ReadLine();
                if (input?.ToLower() == "q") break;
                if (!int.TryParse(input, out int countStudents) || countStudents <= 0)
                {
                    ShowError("Помилка! Введіть коректну к-сть студентів.");
                    continue;
                }
                Console.WriteLine(new string('-', 50));
                int[][] grades = new int[countStudents][];
                for (int i = 0; i < countStudents; i++)
                {
                    Console.Write($"Введіть оцінки {i + 1}-го студента через пробіл: ");
                    string inputGradesStrline = Console.ReadLine();
                    string[] inputGradesStr = inputGradesStrline?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
                    if (inputGradesStr.Length == 0)
                    {
                        ShowError("Помилка! Введіть хоча б одну оцінку.");
                        i--;
                        continue;
                    }
                    int[] inputGrades = new int[inputGradesStr.Length];
                    bool isValidInput = true;
                    for (int j = 0; j < inputGradesStr.Length; j++)
                    {
                        if (!int.TryParse(inputGradesStr[j], out inputGrades[j]) || inputGrades[j] < 0 || inputGrades[j] > 100)
                        {
                            isValidInput = false;
                            break;
                        }
                    }
                    if (!isValidInput)
                    {
                        ShowError("Помилка! Введіть лише числа від 0 до 100 через пробіл.");
                        i--;
                        continue;
                    }
                    grades[i] = inputGrades;
                }
                Console.WriteLine(new string('-', 50) + "\nСередній бал кожного студента:");
                for (int i = 0; i < countStudents; i++)
                {
                    double sumGrades = 0;
                    for (int j = 0; j < grades[i].Length; j++)
                    {
                        sumGrades += grades[i][j];
                    }
                    double avgGrade = sumGrades / grades[i].Length;
                    Console.WriteLine($"{i + 1}-й студент: {avgGrade:F1} б.");
                }
                Console.WriteLine(new string('-', 50) + "\nНатисніть будь-яку клавішу, щоб продовжити або Esc, щоб вийти...");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}