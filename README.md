<table> 
    <td align="left">
        <img src="https://github.com/AlianeAmaral/Test/blob/main/icon-arbooks.gif" width="90">
    </td>
    <td width="750">
        <h1>Arbooks API - Catálogo de Livros</h1>
    </td>
</table>

<h2>📝 Sobre o Projeto </h2>

Projeto com **back-end e front-end** desenvolvido com API RESTful para um **desafio técnico**, com intuito de criar um **serviço de catálogo de livros** a partir de um arquivo JSON estático, que não podia ser modificado. <br><br> Foi construído com **C#, ASP .NET Core (Versão 8.0), HTML, CSS e Javascript, com arquitetura em camadas.** Este projeto fornece funcionalidades de **busca flexível, ordenação por preço, cálculo de frete e exibição de detalhes** utilizando rotas. Foi iniciado primeiro como monólito no dia 09/01/26 mas depois alterado para microsserviços para entrega em 12/01/26.

<h2>👩🏻‍💻 Desenvolvimentos Realizados</h2>

* 📄 Apresentação da lista JSON.
* 🔍 Busca flexível por nome, autor ou outros dados (indiferente de maiúsculas/minúsculas, acentos ou palavra incompleta).
* 📊 Ordenação por preço de forma ascedente ou decrescente (tanto na lista completa quanto em resultados da busca).
* 📘 Exibição dos detalhes de cada livro em outra página.
* 💰 Cálculo do frete baseado em 20% do valor do livro.
* 🎨 *Front-end interativo* desenvolvido como bônus, além da possibilidade de teste via Swagger.
* 🧪 Testes unitários que testam a exibição, busca, ordenação e cálculo de frete.

<h2>❤️ Apresentação do Projeto</h2>

<img src="https://github.com/AlianeAmaral/arbooks-livraria/blob/main/Arbooks.Web/wwwroot/images/apresentacao-teste-back-e-front.gif" width="850">

<h2>👾 Tecnologias Utilizadas</h2>

* .NET Core 8 (Framework principal de desenvolvimento)
* ASP .NET Core Web MVC (Arquitetura de API e MVC)
* Visual Studio Community 17.12.1 (IDE de desenvolvimento)

**✨ O projeto também segue boas práticas de:**

* Conventional Commits
* SOLID
* Clean Code
* Clean Architecture

<h2>📦 Requisitos para Execução</h2>

* Microsoft Visual Studio 17.12.1 ou Superior (Em caso de visualização por IDE)
* .NET Core 8 ou Superior
* Git (Clonagem do Repositório)

<h2>🔎 Como Executar o Projeto via Swagger (Visualização do Back-end)</h2>

1. Clone o repositório no seu Visual Studio e acesse a solução:

```directory
git clone https://github.com/AlianeAmaral/arbooks-livraria.git
cd arbooks-livraria
```
2. Clique com botão direito no projeto **"Arbooks.API"**, depois clique em **"Depurar"** e depois em **"Iniciar Nova Instância"**.
3. Uma página vai abrir automaticamente no seu navegador permitindo realizar os seguintes testes:

* **Link do Swagger:** http://localhost:5013/swagger/index.html

<img src="https://github.com/AlianeAmaral/arbooks-livraria/blob/main/Arbooks.Web/wwwroot/images/apresentacao-swagger.png" width="850">

```directory
GET book/search
```
* Permite testar a busca com letras maiúsculas, minúsculas, acentos, palavras incompletas ou especificações que estão nos detalhes, assim como a ordem de preço crescente ou decrescente, tanto para a lista total quanto para os resultados de uma busca.
```directory
GET book/details
```
* Permite testar a exibição dos detalhes por ID.
```directory
GET book/calculateshipping
```
* Permite testar o cálculo de frete por ID.

<h2>🚀 Releases</h2>

Este projeto também conta com **"Release"**, que mostra duas imagens de cada fase do desenvolvimento:

* **Version1-BackendOnly:** Mostra como ficou a interface somente com o back-end.
* **Version2 - Backend-Frontend:** Mostra como ficou a interface com back-end e front-end.

* **Link dos Releases**: https://github.com/AlianeAmaral/arbooks-livraria/releases

<h2>🖼️ Como Executar o Projeto (Visualização com Front-end)</h2>

1. É necessário configurar para que o back-end inicie junto com o front-end.
2. Clique com o botão direito no projeto **"Arbooks.API"** e depois em **"Configurar Projetos de Inicialização"**.
3. Deixe **"Arbooks.API"** e **"Arbooks.Web"**, com a ação de **"Iniciar"**, nesta sequência, primeiro API e segundo Web.
4. Clique em **"Ok"** e inicie o projeto na interface da IDE.
5. Uma página do navegador deve abrir o site com back-end e front-end funcionando para você interagir.
   
<h2>🧪 Como Executar os Testes</h2>

1. Conferir se o projeto está parado.
2. Clique com botão direito no projeto **"Arbooks.Test"** e depois em **"Executar Testes"**.

<h2>🗂️ Estrutura do Projeto </h2>

```directory
arbooks-livraria/
│
├─ Arbooks.API
│     ├── Properties
│     ├── Controllers
│     ├── appsettings.json
│     ├── Arbooks.API.http
│     └── Program.cs
├─ Arbooks.Business
│     ├── DTOs
│     ├── Models
│     ├── Repository
│     ├── Services
│     └── books.json
├─ Arbooks.Test   
│     └── Business
├─ Arbooks.Web
│     ├── Properties
│     ├── wwwroot
│     ├── Controllers
│     ├── DTOs
│     ├── Views
│     ├── appsettings.json 
│     └── Program.cs
└──.gitignore
└── arbooks-livraria.sln
└── README
```

<h2>💾 Proposta Inicial do Teste</h2>

Um cliente tem necessidade de buscar livros em um catálogo. Esse cliente quer ler e buscar esse catálogo de um arquivo JSON, e esse arquivo não pode ser modificado. Então com essa informação, é preciso desenvolver:

    Criar uma API para buscar produtos no arquivo JSON disponibilizado.
    Que seja possível buscar livros por suas especificações(autor, nome do livro ou outro atributo)
    É preciso que o resultado possa ser ordenado pelo preço.(asc e desc)
    Disponibilizar um método que calcule o valor do frete em 20% o valor do livro.

Será avaliado no desafio:

    Organização de código;
    Manutenibilidade;
    Princípios de orientação à objetos;
    Padrões de projeto;
    Teste unitário

Para nos enviar o código, crie um fork desse repositório e quando finalizar, mande um pull-request para nós.

O projeto deve ser desenvolvido em C#, utilizando o .NET Core 3.1 ou superior.

Gostaríamos que fosse evitado a utilização de frameworks, e que tivesse uma explicação do que é necessário para funcionar o projeto e os testes.




