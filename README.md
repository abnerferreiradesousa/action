<h1 align="center">🚀 Bem vindo ao projeto CRM Action! 🚀</h1>

<h2>🥱 Introdução...</h2>

<p>Este repositório contém uma aplicação fullstack, de um sistema de cursos e candidatos, desenvolvidos usando C#, .NET.</p>

![alt text](https://raw.githubusercontent.com/abnerferreiradesousa/app-transferDIN/main/images/app.png)

<details>
<summary><strong> 🛠️ Tecnologias utilizadas 🧰 </strong></summary>

* <p>👉 C#</p>

* <p>👉 Entity Framework</p>

* <p>👉 Session</p>

* <p>👉 MVC</p>

* <p>👉 ASP.NET</p>

</details>

<details>
<summary><strong> Critérios do projeto </strong></summary>

- ☑️ Cadastrar lead (candidato) com validação de CPF
- ☑️ Cadastrar novos cursos
- ❌ Cadastrar uma nova inscrição, a inscrição é comporta por um candidato e um curso, um candidato pode ter mais de uma inscrição.
</details>


<h2>👨‍💻 Rodando o projeto👨‍💻</h2>

<details>
  
<summary><strong>Como rodar?</strong></summary>
  
1. Clone o repositório com o comando:
  - `git clone https://github.com/abnerferreiradesousa/action`;
    - Entre na pasta do repositório:
      - `cd action`
2. Inicie o banco usando Docker:
 - `sudo docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Password12" \
   -p 1433:1433 --name sql1 --hostname sql1 \
   -d \
   mcr.microsoft.com/mssql/server:2022-latest`

  
</details>

<i><strong>Dica:</strong> Os usuários Phineas, Ferb, Perry e Abner já estão cadastrados caso queira mandar uma grana pra eles ou pra mim 😊.</i>

<h2>💥 Defafios que enfrentei... 🗡️</h2> 

* 🗡️ Trabalhar com datas foi difícil, embora tenha me esforçado para entender os problemas que estavam ocorrendo com relação a filtragem por data, não consegui concluir tal requisito, continuo estudando afim de concluí-lo e entender melhor sobre manipulação de datas. 
* 🛡️ Dockerizar a aplicação.
* 🥊 Aprender o TypeORM do zero.
* ⚔️ Configuração do PostgreSQL.
* 💥 Como desenvolver o projeto.

<h2>Considerações finais... ✍️</h2>

<p>
 📚 Aprendi a analisar melhor os bugs, erros e problemas em geral e assim pude buscar soluções mais assertivas, de forma mais rápida e até mais concisas.
  Entendi também que devo me planejar melhor quanto ao que o frontend precisa para funcionar de forma integrada e eficiente, porque por vezes precisei alterar algo no backend que já estava construído para se adequar ao frontend.
</p>

<h2>🥷 Próximos passos...</h2>

* <p>👉 Deploy de toda a aplicação.</p>

* <p>👉 Desenvolver testes unitários, de integração e End-2-End.</p>

* <p>👉 Converage Tests</p>
