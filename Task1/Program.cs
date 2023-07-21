// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        if (N < 1)
        {
            Console.WriteLine("Введено некорректное значение. Пожалуйста, введите другое число.");
            return;
        }

        Console.Write($"N = {N} -> \"");
        PrintNaturalNumbersInReverse(N);
        Console.WriteLine("\"");
    }

    static void PrintNaturalNumbersInReverse(int N)
    {
        if (N < 1)
        {
            return;
        }

        Console.Write(N);

        if (N > 1)
        {
            Console.Write(", ");
            PrintNaturalNumbersInReverse(N - 1);
        }
    }
}

