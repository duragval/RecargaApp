// fazer um projeto parecido com a val assistente
// esse porjeto consiste em treinr e praticar poo
// o projeto consiste em um programa de credito de transporte
// vamos ter as funções: observar saldo do usuario e add saldo do usuario
// e tambem informar o nome do usuario

System.Console.WriteLine("Bem vindo ao sistema do SergipeCard");
var gerenciador = new Gerenciador();
string nome = System.Console.WriteLine("Digit");


while (true)
{
    gerenciador.ReceberUSuario();
    System.Console.WriteLine("Digite uma opção:");
    System.Console.WriteLine("1.Mostrar Saldo");
    System.Console.WriteLine("2.Adicionar Saldo");
    System.Console.WriteLine("3.Sair");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            gerenciador.MostrarSaldo();
            break;
        case "2":
            System.Console.WriteLine("Digite o quanto voce que adicionar:");
            decimal quantia = decimal.Parse(Console.ReadLine());
           gerenciador.AddSaldo(quantia);
            break;
        case "3":
            System.Console.WriteLine("Voce esta saindo do programa");
            return;
        default:
            System.Console.WriteLine("Opção invalida, tente novamente");
            break;
    }
}



