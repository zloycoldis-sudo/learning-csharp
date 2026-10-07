﻿using System;
namespace Sum_elements_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int [ , ] matrix = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    matrix[i,j] = random.Next(1, 100);
                }
            }

            Console.WriteLine("Matrix: " + "\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine($"\nThe sum of the elements of the main diagonal of the matrix: {sum}");
        }
    }
}