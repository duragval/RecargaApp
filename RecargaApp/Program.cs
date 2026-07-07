// fazer um projeto parecido com a val assistente
// esse porjeto consiste em treinr e praticar poo
// o projeto consiste em um programa de credito de transporte
// vamos ter as funções: observar saldo do usuario e add saldo do usuario
// e tambem informar o nome do usuario

using RecargaApp;
using System.Globalization;

System.Console.WriteLine("Bem vindo ao sistema do SergipeCard\nDigite seu nome para iniciar: ");
var usuario = Console.ReadLine();

Console.WriteLine("\nAgora digite o numero do cartão de transporte que será gerenciado:");
var serialUsuario = int.Parse(Console.ReadLine());

Conta contaTransporte = new Conta(usuario, 0, serialUsuario);

contaTransporte.Apresentar();

while (true)
{
    System.Console.WriteLine("\nDigite uma opção:");
    System.Console.WriteLine("1.Mostrar Saldo");
    System.Console.WriteLine("2.Adicionar Saldo");
    System.Console.WriteLine("3.Informações Pessoais");
    System.Console.WriteLine("4.Sair\n");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            contaTransporte.MostraSaldo();

            break;
        case "2":
            System.Console.WriteLine("\nDigite o quanto voce quer adicionar:");
            decimal quantia = decimal.Parse(Console.ReadLine().Replace('.',','));
            contaTransporte.AddSaldo(quantia);
            break;
        case "3":
            contaTransporte.Info();
            break;
        case "4":
            System.Console.WriteLine("Voce esta saindo do programa...");
            return;
        default:
            System.Console.WriteLine("Opção invalida, tente novamente!");
            break;
    }
}



