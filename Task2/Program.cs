// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M:");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N:");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Сумма чисел от M до N равна: " + SumRange(M, N));
    }

    static int SumRange(int M, int N)
    {
        if (M > N)
        {
            return 0;
        }
        else
        {
            return M + SumRange(M + 1, N);
        }
    }
}
