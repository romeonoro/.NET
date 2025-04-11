using System;

abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Veiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public abstract void Dirigir();
}

class Carro : Veiculo
{
    public int Portas { get; set; }

    public Carro(string marca, string modelo, int portas) : base(marca, modelo)
    {
        Portas = portas;
    }

    public override void Dirigir()
    {
        Console.WriteLine($"Dirigindo o {Marca} {Modelo} com {Portas} portas.");
    }
}

class Moto : Veiculo
{
    public int Cilindrada { get; set; }

    public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
    {
        Cilindrada = cilindrada;
    }

    public override void Dirigir()
    {
        Console.WriteLine($"Dirigindo a {Marca} {Modelo} com {Cilindrada} cilindradas.");
    }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro("Ford", "Fusca", 4);
        Moto moto = new Moto("Honda", "CB500", 500);

        carro.Dirigir();
        moto.Dirigir();
    }
}
