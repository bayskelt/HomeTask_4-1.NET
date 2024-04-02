using System;
namespace HomeTask_4_1.NET
{
    internal class Program
    {
        static void Main()
        {
            Console.Write($"Введiть кiлькiсть рядкiв: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Введiть кiлькiсть стовпцiв: ");
            int m = int.Parse(Console.ReadLine());

            int[,] mas = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Введiть елемент [{i + 1},{j + 1}]: ");
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int min = mas[0, 0];
            int max = mas[0, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > mas[i, j])
                    {
                        min = mas[i, j];
                    }
                    if (max < mas[i, j])
                    {
                        max = mas[i, j];
                    }
                }
            }

            Console.WriteLine($"Сума максимального та мiнiмального елементiв дорiвнює {min + max}");
        }
    }
}
