using System;
using System.Collections.Generic;

public class Produto : IComparable<Produto>
{
    public string Nome;
    public double Preco;

    public Produto(string nome, double preco)
    {
        this.Nome = nome;
        this.Preco = preco;
    }

    public int CompareTo(Produto outro)
    {
        return this.Nome.CompareTo(outro.Nome);
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Preço: {Preco:C}";
    }

}

public class Mostrar
{
    public static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto("Clips", 3.92),
            new Produto("Caneta", 1.20),
            new Produto("Lápis", 4.15),
            new Produto("Estojo", 6.99),
            new Produto("Caderno", 15.50)
        };

        Console.WriteLine("Lista de produtos:");
        Relacao(produtos);

        produtos.Add(new Produto("Mochila", 22.44));

        Console.WriteLine("\nLista de produtos:");
        Relacao(produtos);

        produtos.Sort();

        Console.WriteLine("\nprodutos ordenados:");
        foreach (Produto produto in produtos)
        {
            Console.WriteLine(produto);
        }

        Console.WriteLine("\nProdutos com preço inferior a 5:");
        precoInferior(produtos, 5.00);

        Console.WriteLine("\nProcurar por Estojo:");
        Produto encontrado = produtos.Find(produto => produto.Nome == "Estojo");

        if (encontrado != null)
        {
            Console.WriteLine("Produto encontrado: " + encontrado);
        }
        else
        {
            Console.WriteLine("Estojo não encontrado");
        }
    }

    public static void Relacao(List<Produto> produtos)
    {
        double soma = 0;

        Console.WriteLine("Produtos:");
        foreach (Produto produto in produtos)
        {
            Console.WriteLine(produto);
            soma += produto.Preco;
        }

        double media = produtos.Count > 0 ? soma / produtos.Count : 0;

        Console.WriteLine($"\nTotal de produtos: {produtos.Count}");
        Console.WriteLine($"Soma dos preços: {soma:C}");
        Console.WriteLine($"Média dos preços: {media:C}");
    }

    public static void precoInferior(List<Produto> produtos, double limitePreco)
    {
        foreach (Produto produto in produtos)
        {
            if (produto.Preco < limitePreco)
            {
                Console.WriteLine(produto);
            }
        }
    }
}