<h1 align="center">🚀 Bem vindo ao projeto CRM Action! 🚀</h1>

<h2>🥱 Introdução...</h2>

<p>Este repositório contém uma aplicação fullstack, de um sistema de cursos e candidatos, desenvolvidos usando C#, .NET.</p>

<details>
<summary><strong>Resultado final da aplicação</strong></summary>
<img src="https://raw.githubusercontent.com/abnerferreiradesousa/action/main/img/Captura de tela de 2022-12-12 20-35-32.png">
<img src="https://raw.githubusercontent.com/abnerferreiradesousa/action/main/img/Captura de tela de 2022-12-12 20-35-43.png">
<img src="https://raw.githubusercontent.com/abnerferreiradesousa/action/main/img/Captura de tela de 2022-12-12 20-35-54.png">
<img src="https://raw.githubusercontent.com/abnerferreiradesousa/action/main/img/Captura de tela de 2022-12-12 20-36-13.png">
<img src="https://raw.githubusercontent.com/abnerferreiradesousa/action/main/img/Captura de tela de 2022-12-12 20-36-08.png">
</details>

<details>
<summary><strong> 🛠️ Tecnologias utilizadas 🧰 </strong></summary>

* <p>👉 C#</p>

* <p>👉 Entity Framework</p>

* <p>👉 Session</p>

* <p>👉 MVC</p>

* <p>👉 ASP.NET</p>

</details>

<h2>👨‍💻 Rodando o projeto👨‍💻</h2>

<details>
  
<summary><strong>Como rodar?</strong></summary>
  
1. Clone o repositório com o comando:
  - `git clone https://github.com/abnerferreiradesousa/action`;
    - Entre na pasta do repositório:
      - `cd action`
2. Inicie o banco usando Docker:
  ```
  sudo docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Password12" \
  -p 1433:1433 --name sql1 --hostname sql1 \
  -d \
  mcr.microsoft.com/mssql/server:2022-latest
  ```
3. Rodando o banco de dados:
  - `dotnet ef database update`
4. Iniciando a aplicação:
  - `dotnet watch run`

  
</details>


<details>
<summary><strong> Critérios do projeto </strong></summary>

- ☑️ Cadastrar lead (candidato) com validação de CPF
- ☑️ Cadastrar novos cursos
- ❌ Cadastrar uma nova inscrição, a inscrição é comporta por um candidato e um curso, um candidato pode ter mais de uma inscrição.
</details>


<h2>💥 Defafios que enfrentei... 🗡️</h2> 

* 🗡️ O principal desafio foi inserir no banco de dados a inscrição em um curso, que no caso precisa do id do curso e do usuário, a meu ver "estava no papo" esse requsito, mas com o andar da carruagem, a aplicação insistia em não encontrar a rota para realizar tal ação, isso quando não interferia nas outras rotas. Enfim, sigo em busca de resolver esse problema.
