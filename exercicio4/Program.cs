using System.Collections;

public class Pessoa
{
    public string? nome;
    public int idade;

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public static void exibir(ArrayList pessoas)
    {
        foreach (Pessoa pessoa in pessoas)
        {
            Console.WriteLine($"Nome: {pessoa.nome}, Idade: {pessoa.idade}");
        }
    }
}

public class Mostrar
{
    public static void Main(string[] args)
    {
        int tamanho = 3;

        ArrayList pessoas = new ArrayList(tamanho);

        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"Digite o nome da pessoa {i + 1}:");
            string nome = Console.ReadLine();

            Console.WriteLine($"Digite a idade da pessoa {i + 1}:");
            int idade = int.Parse(Console.ReadLine());

            pessoas.Add(new Pessoa(nome, idade));
        }

        pessoas.Add(new Pessoa("Jaime", 20));
        pessoas.Add(new Pessoa("Tânia", 18));

        Pessoa.exibir(pessoas);

        if (pessoas.Count > 0)
        {
            pessoas.RemoveAt(pessoas.Count - 1);
        }

        Console.WriteLine("\nApós remover a ultima pessoa:");
        Pessoa.exibir(pessoas);
    }
}
