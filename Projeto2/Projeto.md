# Sistema de Cadastro de Veículos com ASP.NET Core e Razor Pages

## Objetivo

Desenvolver uma aplicação web utilizando **ASP.NET Core com Razor Pages**, com foco em:

- Manipulação de arquivos texto
- Estruturação de dados
- Organização visual da interface
- Navegação entre páginas

---

## Descrição do Projeto

A aplicação consiste em um sistema para **Cadastro de Veículos**, com as seguintes funcionalidades:

- ✅ Cadastrar novos veículos  
- ✅ Listar todos os veículos cadastrados  
- ✅ Visualizar os detalhes de um veículo específico  
- ✅ Editar os dados de um veículo existente  

Os dados devem ser armazenados em **arquivo texto (.txt)** com formato estruturado, usando separação por ponto e vírgula (`;`).

---

## Informações Obrigatórias de Cada Veículo

- Nome do veículo  
- Modelo  
- Marca  
- Renavam  
- Ano de fabricação  
- Ano do modelo  
- Foto do veículo *(opcional)*  

📌 **Nota:**  
Se fornecida, a **foto** deve ser salva na pasta `wwwroot/uploads` e exibida na **página de detalhes** do veículo.

---

## Requisitos da Aplicação

A aplicação deve ser desenvolvida com **ASP.NET Core Razor Pages** e atender aos seguintes critérios:

- [x] Formulário de cadastro de veículos  
- [x] Página de listagem dos veículos cadastrados  
- [x] Página de detalhes do veículo  
- [x] Página de edição de dados  
- [x] Todos os dados devem ser salvos e lidos de um **arquivo texto (.txt)**  
- [x] A imagem, se presente, deve ser exibida corretamente  
- [x] Páginas organizadas e visualmente agradáveis, com uso de formulários, tabelas e exibição de dados  
- [x] Navegação entre páginas, permitindo retornar para listagem, cadastro ou página inicial a partir de qualquer tela  

---

## Estrutura 

```
/wwwroot
  /uploads            --> Armazenamento de imagens dos veículos
/Pages
  Index.cshtml          → Página inicial
  Create.cshtml         → Formulário de cadastro
  Create.cshtml.cs      ← Lógica do cadastro
  Edit.cshtml           → Formulário de edição
  Edit.cshtml.cs        ← Lógica da edição
  Details.cshtml        → Visualização de detalhes
  Details.cshtml.cs     ← Lógica de detalhes
  List.cshtml           → Lista de veículos
  List.cshtml.cs        ← Lógica da lista
/Models
  Veiculo.cs            ← Classe que representa os veículos
/Data
  VeiculoUtils.cs       ← Funções para manipular o arquivo
  veiculos.txt          ← Armazenamento dos dados

```

---

## Tecnologias Utilizadas

- ASP.NET Core
- Razor Pages
- HTML/CSS, Bootstrap
- Manipulação de arquivos em C#

## Melhorias Futuras

- 🔍 **Filtro de pesquisa** na listagem de veículos, permitindo buscar por nome, marca, modelo ou ano.  
- 🚫 **Validação de Renavam duplicado**, impedindo o cadastro de dois veículos com o mesmo número de Renavam.  
- 🧹 **Melhoria na usabilidade**, como ordenação da tabela, paginação e mensagens de confirmação.  
- 📱 **Design responsivo**, para melhor visualização em dispositivos móveis.  
- 💾 **Exportação dos dados** em formatos como CSV ou PDF.  
- 🔐 **Autenticação e autorização**, para controle de acesso às funcionalidades.  
