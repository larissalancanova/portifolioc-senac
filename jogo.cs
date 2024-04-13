using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Bem-vindo ao jogo de azar!");

        Random random = new Random();
        int numSort = random.Next(0, 101);

        Console.WriteLine("Digite um número entre 0 e 100:");
        int numeroJogador;

        while (!int.TryParse(Console.ReadLine(), out numeroJogador) || numeroJogador < 0 || numeroJogador > 100)
        {
            Console.WriteLine("Número inválido. Digite um número entre 0 e 100:");
        }

        Console.WriteLine($"Número sorteado: {numSort}");


        if (numeroJogador == numSort)
        {
            Console.WriteLine("Parabéns! Você acertou!");
        }
        else
        {
            Console.WriteLine("Não foi dessa vez. Tente novamente!");
        }
    }
}
