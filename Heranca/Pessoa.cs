using System;

abstract class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public abstract void Apresentar();
}

class Aluno : Pessoa
{
    public string Matricula { get; set; }

    public Aluno(string nome, int idade, string matricula) : base(nome, idade)
    {
        Matricula = matricula;
    }

    public override void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Matrícula: {Matricula}");
    }
}

class Professor : Pessoa
{
    public string Disciplina { get; set; }

    public Professor(string nome, int idade, string disciplina) : base(nome, idade)
    {
        Disciplina = disciplina;
    }

    public override void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Disciplina: {Disciplina}");
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno("João", 20, "A123");
        Professor professor = new Professor("Maria", 45, "Matemática");

        aluno.Apresentar();
        professor.Apresentar();
    }
}
