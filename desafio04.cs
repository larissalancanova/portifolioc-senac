using System;

class Program
{
    static void Main(string[] args)
    {
        int[] X = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite o valor para X[{i}]:");
            if (!int.TryParse(Console.ReadLine(), out X[i]))
            {
                Console.WriteLine("Valor inválido. Insira um número inteiro.");
                i--; 
            }
        }

        for (int i = 0; i < 10; i++)
        {
            if (X[i] <= 0)
            {
                X[i] = 1;
            }
        }
        for (int i = 0; i < 10; i++)
