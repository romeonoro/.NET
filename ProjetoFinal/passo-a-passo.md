# Relacionamento Um-para-Muitos (1)

## 1. Criar Projeto
- IDE: Visual Studio 2022
- Tipo: Aplicativo Web do ASP.NET Core (Model-View-Controller)

## 2. Gerenciar Pacotes NuGet

Acesse: `Ferramentas -> Gerenciar de Pacotes do NuGet -> Gerenciar Pacotes do NuGet para solução`  
Instale os seguintes pacotes **na MESMA versão do seu projeto .NET (9.0.0)**:

- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.Design`
- `Microsoft.EntityFrameworkCore.Sqlite`
- `Microsoft.EntityFrameworkCore.Sqlite.Core`
- `Microsoft.EntityFrameworkCore.Tools`

## 3. Instalar DB Browser for SQLite

- Site oficial: [sqlitebrowser.org](https://sqlitebrowser.org)

## 4. Configurações Iniciais

1. Criar as classes `Contexto`, `Projeto` e `Tarefa`
   
✅ Classe Contexto
```cs
using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Projeto> Projetos { get; set; }
    public DbSet<Tarefa>  Tarefas  { get; set; }

    public Contexto(DbContextOptions<Contexto> options)
        : base(options)
    {
    }
    // Configura o relacionamento 1:N entre Projeto e Tarefa.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Uma Tarefa TEM UM Projeto
        // Um Projeto TEM MUITAS Tarefas
        modelBuilder.Entity<Tarefa>()
            .HasOne(t => t.Projeto)
            .WithMany(p => p.Tarefas)
            .HasForeignKey(t => t.ProjetoId)
            .OnDelete(DeleteBehavior.Cascade); // Exclui as Tarefas ao excluir o Projeto

        base.OnModelCreating(modelBuilder);
    }
}
```

✅ Classe Projeto
```cs
public class Projeto
{
    public int ProjetoId { get; set; }
    public string Nome { get; set; }
    public string Cliente { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime? DataFim { get; set; } //(opcional)

    // Relacionamento 1:N → Um projeto possui várias tarefas (Lista)
    public ICollection<Tarefa>? Tarefas { get; set; }
}
```

✅ Classe Tarefa
```cs
public class Tarefa
{
    public int TarefaId { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string Status { get; set; }

    // Chave estrangeira
    public int ProjetoId { get; set; }

    // Navegação reversa
    public Projeto? Projeto { get; set; }
}
```

2. Configurar o banco de dados em `appsettings.json` e `Program.cs`
   
📄 appsettings.json
```bash
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",

  "ConnectionStrings": {
    "DefaultConnection": "Data source=projetos.db"
  }
}
```

📄 Program.cs (configurando o EF Core com SQLite)
```cs
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurar o DbContext (Contexto) para usar o SQLite
builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
```
    
3. Executar comandos no terminal:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 5. Adicionar Controladores com Scaffold

- Caminho: Adicionar > Controlador > Controlador MVC com exibições, usando Entity Framework

## 6. 📁 Estrutura do Projeto


```text
Controllers/
├── HomeController.cs
├── ProjetosController.cs
└── TarefasController.cs

DAL/
├── Contexto.cs                # DbContext com configuração EF Core

Models/
├── Projeto.cs             # Entidade Projeto (dados persistidos)
└── Tarefa.cs              # Entidade Tarefa (dados persistidos)
├── ProjetoViewModel.cs        # ViewModel para exibir Projeto em tela 
└── TarefaViewModel.cs         # ViewModel para exibir Tarefa em tela 

Migrations/
└── ...                        # Arquivos de migração gerados pelo EF Core

Views/
├── Home/
│   └── Index.cshtml           # Página inicial
├── Projetos/
│   ├── Create.cshtml
│   ├── Edit.cshtml
│   ├── Delete.cshtml
│   ├── Details.cshtml
│   └── Index.cshtml
└── Tarefas/
    ├── Create.cshtml
    ├── Edit.cshtml
    ├── Delete.cshtml
    ├── Details.cshtml
    └── Index.cshtml

appsettings.json
Program.cs
