// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

class Program
{
    static void Main()
    {
        int m;
        do
        {
            Console.WriteLine("Введите значение m (не больше 3):");
        } while (!int.TryParse(Console.ReadLine(), out m) || m < 0 || m > 3);

        int n;
        do
        {
            Console.Write("Введите значение n (не больше 3):");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 3);

        int result = Ackermann(m, n);

        Console.Write("Результат функции Аккермана A(" + m + "," + n + ") = " + result);
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}
