RecargaApp — SergipeCard

Aplicação desenvolvida em C# como projeto de estudos para praticar e consolidar conceitos fundamentais de Programação Orientada a Objetos (POO).

O projeto simula um sistema simples de gerenciamento de crédito de um cartão de transporte, permitindo consultar saldo, adicionar créditos e visualizar informações do usuário.

Este projeto foi desenvolvido com foco no aprendizado e na prática dos fundamentos de POO em C#.

## Objetivo

O principal objetivo do projeto é aplicar conceitos de Programação Orientada a Objetos utilizando um cenário simples.

A aplicação permite:

* Informar o nome do usuário;
* Informar o número do cartão de transporte;
* Consultar o saldo disponível;
* Adicionar saldo ao cartão;
* Visualizar informações do usuário e do cartão;
* Encerrar a aplicação.

## Tecnologias utilizadas

* C#
* .NET
* Console Application
* Programação Orientada a Objetos (POO)

## Conceitos de POO praticados

### Abstração

Utilização da classe abstrata `Pessoa` como base para representar características comuns.

### Herança

A classe `Conta` herda características e comportamentos da classe `Pessoa`.

### Encapsulamento

Uso de `private set` para controlar a alteração das propriedades, como `Saldo` e `Serial`.

### Polimorfismo

Sobrescrita do método `Info()` na classe `Conta` utilizando `override`.

### Construtores

Utilização de construtores para inicializar os objetos com seus respectivos dados.

## Estrutura do projeto

```text
RecargaApp/
│
├── Program.cs
├── Pessoa.cs
└── Conta.cs
```

### Program.cs

Responsável pela interação com o usuário, menu e execução das operações do sistema.

### Pessoa.cs

Contém a classe abstrata `Pessoa`, responsável pelas características e comportamentos comuns.

### Conta.cs

Contém a classe `Conta`, que herda de `Pessoa` e gerencia o saldo e o número do cartão.

## Funcionamento

Ao iniciar a aplicação, o usuário informa seu nome e o número do cartão de transporte.

Em seguida, o sistema apresenta o menu:

```text
1. Mostrar Saldo
2. Adicionar Saldo
3. Informações Pessoais
4. Sair
```

O usuário pode consultar o saldo, adicionar créditos, visualizar suas informações ou encerrar o programa.

## Como executar

### Pré-requisitos

É necessário ter o **.NET SDK** instalado.

### Executando o projeto

Clone o repositório:

```bash
git clone URL_DO_REPOSITORIO
```

Entre na pasta do projeto:

```bash
cd RecargaApp
```

Execute a aplicação:

```bash
dotnet run
```

## Sobre o projeto

O RecargaApp foi desenvolvido como parte dos meus estudos em C# e Programação Orientada a Objetos, utilizando uma aplicação simples para colocar em prática conceitos fundamentais da linguagem.

O projeto contribuiu para meu aprendizado sobre criação de classes e objetos, abstração, herança, encapsulamento, polimorfismo e construtores.

## Autor

Varlei Oliveira

Estudante de Análise e Desenvolvimento de Sistemas, com foco em desenvolvimento utilizando C# e .NET.
