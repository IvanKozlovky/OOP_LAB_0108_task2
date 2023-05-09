using System;
using System.IO;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть натуральне число n: ");
            int n = int.Parse(Console.ReadLine());

            string filePath = "g.txt";

            using (StreamWriter sw = File.CreateText(filePath))
            {
                for (int i = 1; i <= n; i++)
                {
                    double bi = i * CalculateSum(i);
                    sw.WriteLine(bi);
                }
            }

            Console.WriteLine($"Числа b1, ..., bn були записані у файл {filePath}.");
        }

        static double CalculateSum(int i)
        {
            double sum = 0;
            double factorial = 1;

            for (int k = 1; k <= i; k++)
            {
                factorial *= k;
                sum += 1 / factorial;
            }

            return sum;
        }
    }
}
