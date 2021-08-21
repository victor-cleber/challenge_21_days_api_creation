# API em C# | Desafio 21 dias [DIA 05 - Entendendo o desacoplamento de funcoes]

#### CRIANDO O PROJETO
> cd  challenge _21_days_api_creation

> dotnet new console --name Dia05

#### PLANO
Vamos criar a classe Student com os metodos de acesso ao banco de dados.
Apos exectar a aplicacao, vamos separar os metodos de acesso ao banco de dados numa partial class a fim de mostrar a importancia da separacao de responsabilidades.

Passo 1 - criar classe Student com os metodos ListarTodos, ListarPorId, Atualizar, Excluir e Criar, a tabela Student e executar a aplicacao varias vezes para entender o fluxo.

- executenoquery - executa sem retorno
- reader         - liga tabela dobd com meu codito
- escalar        - para retornar um id
        
Lembrar de instalar SQL Server no Docker, Azure Data Studio ou DBViewr no Linux ou SQL Management Studio

```
create database challenge21Days;

CREATE TABLE Students(
    id INT ITENTITY(1,1) PRIMARY KEY,
    name VARCHAR(150) NOT NULL,
    studentId VARCHAR(150) NOT NULL,
    grades varchar(255)
);
```

Para configurar o Sql Connector podemos dar uma olhada no exemplo em (
http://www.macoratti.net/08/11/c_sql_m1.htm)

Alem disso vamos adicionar nugget (gerenciador de dependencias C#) a biblioteca SqlClient:

> dotnet add package System.Data.SqlClient  

Passo 2 - mover os metodos de acesso ao banco de dados para uma classe partial. Este conceito se aplica em outras linguagens. Ao final teremos duas classes: Student com os atributos e metodos de negocio e StudentDB com os metodos estaticos de acesso ao banco de dados

A partir deste conceito podemos criar outras partial classes com outras responsabilidades, como por exemplo: StudentSMS que tem a responsabilidade de enviar mensagens SMS ou StudentEmail que tem a responsabilidade de enviar mensagens de e-mail.

Obs.:
Neste caso o conceito de heranca nao pode e nem deve ser aplicado.
As partial classes do C# podem tambem ser conhecidas atraves do conceito de classes de servico em outras linguagens. Por exemplo, StudentService ou StudentDB ou StudentRepository que serao classes responsaveis por persistir os dados no banco de dados. No Java teremos as classes DTO.


#### Formas de persistencia de dados:

- Entity Framework
- ADO .net
- Dapper

conectar manualmente para mostrar classes e servicos

cat git/config



Obs.: 
- estudar migrations e scaffold
- Se voce chegou ate aqui e acha que esta dificl assista a live onde algumas pessoas mostram como elas estao superando seus limites na programacao (https://www.youtube.com/watch?v=NqE-hMH2vIo)

- rodar a execucao e estudar o codigo refatorando


comece o codigo resolvendo o problema entao a classe Aluno e AlunoService podem estar juntas e depois vai melhorando
usar using para sql connection para q o dispose ocorrar automagicamente

sqlCommand e Sql Connection nao e regra do dominio entao o ideal e passar uma interface generica independente do tipo de bd - Domain Driven Designer


separar string de conexao num arquivo json 