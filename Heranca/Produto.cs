using System;

abstract class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public abstract decimal CalcularDesconto();
}

class Livro : Produto
{
    public Livro(string nome, decimal preco) : base(nome, preco) { }

    public override decimal CalcularDesconto()
    {
        return Preco * 0.05m; // 5% de desconto
    }
}

class Eletronico : Produto
{
    public Eletronico(string nome, decimal preco) : base(nome, preco) { }

    public override decimal CalcularDesconto()
    {
        return Preco * 0.125m; // 12.5% de desconto
    }
}

class Program
{
    static void Main()
    {
        Produto livro = new Livro("C# para Iniciantes", 50);
        Produto eletronico = new Eletronico("Smartphone", 1200);

        Console.WriteLine($"Desconto no livro: {livro.CalcularDesconto()}");
        Console.WriteLine($"Desconto no eletrônico: {eletronico.CalcularDesconto()}");
    }
}
