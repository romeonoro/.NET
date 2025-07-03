# Relacionamento Um-para-Muitos (1)

## 1. Criar Projeto

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
    "DefaultConnection": "Data source=produtos.db"
  }
}
```

📄 Program.cs (configurando o EF Core com SQLite)
```bash
using Microsoft.EntityFrameworkCore;
using PrimeiroWEBEFCore.DAL;

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
└── Entidades/
    ├── Projeto.cs             # Entidade Projeto (dados persistidos)
    └── Tarefa.cs              # Entidade Tarefa (dados persistidos)

Models/
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
