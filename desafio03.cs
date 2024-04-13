using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 0, b = 1, N = 10;

        for (int i = 0; i < N; i++)
        {
            Console.Write($"{a} ");
            b = a + (a = b);
        }

        Console.WriteLine();
    }
}
