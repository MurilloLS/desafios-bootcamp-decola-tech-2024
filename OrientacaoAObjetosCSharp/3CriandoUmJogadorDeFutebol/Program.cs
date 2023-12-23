using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador()
    {
    }
}

class Program
{
    static void Main()
    {
      Jogador j1 = new Jogador();
      j1.Nome = Console.ReadLine();
      j1.Nacionalidade = Console.ReadLine();
      j1.Idade = int.Parse(Console.ReadLine());
      j1.Posicao = Console.ReadLine();
      
      Console.WriteLine($"Jogador criado! \n {j1.Nome} \n {j1.Nacionalidade} \n {j1.Idade} \n Posição: {j1.Posicao}");
      
    }
}
