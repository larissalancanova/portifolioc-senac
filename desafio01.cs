using System;

class Program {
  public static void Main () {
    Console.WriteLine ("Qual foi o tempo gasto na viagem (em horas)?");
    float tempo = float.Parse(Console.ReadLine());
    Console.WriteLine ("Qual foi a velocidade média durante a viagem (em km/h)?");
    float velocidade = float.Parse(Console.ReadLine());

    float distancia = tempo * velocidade;
    double litros = distancia / 12;
    litros = Math.Round(litros, 3);
    Console.WriteLine("A quantidade de litros gastos na viagem foi de " + litros + " litros.");
    
    
  }
}
