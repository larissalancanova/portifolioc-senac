using System;

class Program
{
    public static void Main(string[] args)
    {
        int[,] m = new int[12, 12];
        int valor = 0;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                m[i, j] = valor;
                valor++;
            }
        }

        Console.WriteLine("Digite um número de 0 a 11");
        int i = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite S para somar ou M para média");
        char s = char.Parse(Console.ReadLine());

        float total = 0f;

        if (s == 'S')
        {
            for (int j = 0; j < 12; j++)
            {
                total = total + m[i, j];
            }
        }
        else if (s == 'M')
        {
            for (int j = 0; j < 12; j++)
            {
                total = total + m[i, j];
            }
            total = total / 12;
        }

        Console.WriteLine(total);
    }
}
