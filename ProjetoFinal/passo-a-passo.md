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

1. Criar as classes `Projeto` e `Contexto`
2. Configurar o banco de dados em `appsettings.json` e `Program.cs`
3. Executar comandos no terminal:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 5. Adicionar Controladores com Scaffold

- Caminho: Adicionar > Controlador > Controlador MVC com exibições, usando Entity Framework

## 6. Estrutura do Projeto

Controllers/
├── HomeController.cs
├── ProjetosController.cs
├── TarefasController.cs

DAL/
└── Contexto.cs  (DbContext)

Migrations/

Models/
├── Projeto.cs
└── Tarefa.cs

Views/
├── Home/
│   └── Index.cshtml
└── Projetos/
    └── CRUD.cshtml
