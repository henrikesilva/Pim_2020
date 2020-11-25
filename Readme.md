# INTRODUCAO
PROJETO DESENVOLVIDO PARA O PROJETO INTEGRADO MULTIDISCIPLINAR DA UNIVERSIDADE PAULISTA UNIP PARA A TURMA DE 4º SEMESTRE DE 2020 

# DEESCRICAO DO PROJETO
1 - O Projeto consiste em uma API desenvolvida em .NET CORE baseada na arquitetura Domain-Driven-Design (DDD) consumindo AutoMapper
    e Dapper para conexao com banco de Dados SQL Server versão 2019, cujo script pode ser encontrado nesse documento;

2 - A segunda parte do projeto consiste em uma aplicação desenvolvida em Angular 10 afim de consumir a API desenvolvida e 
    disponibilizada nesse repositorio;

3 - O projeto tem como objetivo habilitar o controle e gerenciamento de ativos de clientes de uma empresa de blockchain permitindo:
    * O Lancamento de ativos na carteira de usuario;
    * O débito de ativos e valores na carteira;
    * Cadastros de clientes através de perfis determinados;
    * Acompanhamento da cotação em tempo real através de uma aplicacao parceira anexada na paágina Home da aplicacao em Angular


# Dependecias Necessarias
Para a correta utilização do projeto é indicado:
    * Efetuar a execução do SCRIPT em SQL disponibilizado no repositorio para que o Banco de Dados seja criado corretamente;
    * Efetuar a criação de ao menos 1 usuario no banco de dados com permissão de funcionario ou administrador;
    * Efetuar a Execução da API em .NET Core - Utilizado o Framework 3.1;
    * Efetuar o download de todas as dependencias do projeto angular com o comando "npm install" dentro da pasta raiz do projeto;
    * Apontar a URL da API no arquivo "environament":
        - src > assets > environament
    * Efetuar a execução do projeto em Angular;

# Tecnologias:
LINGUAGENS UTILIZADAS NO PROJETO:
    * C# - .NET CORE;
    * SQL Server;
    * Angular 10;