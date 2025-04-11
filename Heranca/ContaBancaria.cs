using System;

abstract class ContaBancaria
{
    public decimal Saldo { get; protected set; }

    public ContaBancaria(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public abstract void Depositar(decimal valor);
    public abstract void Sacar(decimal valor);
}

class ContaCorrente : ContaBancaria
{
    public ContaCorrente(decimal saldoInicial) : base(saldoInicial) { }

    public override void Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito de {valor} realizado. Saldo: {Saldo}");
    }

    public override void Sacar(decimal valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado. Saldo: {Saldo}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}

class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(decimal saldoInicial) : base(saldoInicial) { }

    public override void Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito de {valor} realizado. Saldo: {Saldo}");
    }

    public override void Sacar(decimal valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado. Saldo: {Saldo}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}

class Program
{
    static void Main()
    {
        ContaCorrente cc = new ContaCorrente(1000);
        ContaPoupanca cp = new ContaPoupanca(2000);

        cc.Depositar(500);
        cp.Sacar(300);
    }
}
