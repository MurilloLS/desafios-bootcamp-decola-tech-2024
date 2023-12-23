using System;

class Pessoa
{
  public string Nome { get; set; }
  public int Idade { get; set; }
 
    public Pessoa(string n, int i)
    {
        Nome = n;
        Idade = i;
    }

    public string GetNome()
    {
        return Nome;
    }

    public int GetIdade()
    {
        return Idade;
    }
}

class Program
{
    static void Main()
    {
       string nome = Console.ReadLine();
       int idade = int.Parse(Console.ReadLine());
       Pessoa p1 = new Pessoa(nome, idade);
       Console.WriteLine($"Nome: {p1.GetNome()}, Idade: {p1.GetIdade()}");

    }
}
