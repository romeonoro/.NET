# Sistema de Controle de Projetos e Tarefas

## 📌 Descrição

Este projeto é uma aplicação web desenvolvida em **ASP.NET Core MVC** com **Entity Framework Core**, como trabalho final da disciplina de Programação .NET. O principal objetivo é demonstrar a aplicação prática dos conceitos estudados ao longo do semestre, por meio da criação de aplicação web completa para controle de **Projetos** e suas respectivas **Tarefas**.

---

## 🎯 Funcionalidades

- **CRUD de Projetos**  
  - Cadastrar novo projeto  
  - Listar projetos cadastrados  
  - Editar informações de um projeto  
  - Excluir projetos  

- **CRUD de Tarefas**  
  - Cadastrar tarefa vinculada a um projeto  
  - Listar tarefas de um projeto  
  - Editar tarefa  
  - Excluir tarefa  

- **Detalhes do Projeto**  
  - Visualizar as informações do projeto  
  - Exibir todas as tarefas associadas a ele

---

## 🧱 Estrutura da Aplicação

A aplicação segue o padrão **MVC (Model-View-Controller)** com as seguintes camadas:

- **`Models`**: definição das entidades `Projeto` e `Tarefa`, e suas relações
- **`Controllers`**: responsáveis pelo fluxo da aplicação e regras de negócio
- **`Views`**: telas que interagem com o usuário

---

## 🗃️ Modelagem

### Projeto

- `Id`: Identificador único  
- `Nome`: Nome do projeto  
- `Cliente`: Nome do cliente  
- `DataInicio`: Data de início do projeto  
- `DataFim`: Data de término do projeto (opcional)  

### Tarefa

- `Id`: Identificador único  
- `Titulo`: Título da tarefa  
- `Descricao`: Descrição da tarefa  
- `Status`: Status atual da tarefa (por exemplo: Pendente, Em Andamento, Concluída)  
- `ProjetoId`: Chave estrangeira vinculando à entidade `Projeto`

---

## 🔗 Relacionamento entre Entidades

- **Projeto (1) ↔ (N) Tarefa**  
  Cada projeto pode ter várias tarefas associadas.  
  Cada tarefa pertence a um único projeto.

---

## ✅ Requisitos Atendidos

- ✅ Aplicação estruturada no padrão MVC  
- ✅ Persistência de dados com Entity Framework Core  
- ✅ Relacionamento 1:N (Projeto → Tarefas) corretamente implementado  
- ✅ CRUD completo para as entidades Projeto e Tarefa  
- ✅ Navegação clara e funcional entre telas   

---

## 📎 Tecnologias Utilizadas

- ASP.NET Core MVC (.NET 6 ou superior)  
- Entity Framework Core  
- SQLite
- Razor 

---

## 👨‍💻 Autor

- [Romeo Noro Guterres]  
- Curso de Ciência da Computação — Universidade Franciscana (UFN)  
- Disciplina: Programção .NET  
