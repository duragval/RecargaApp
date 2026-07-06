public class Gerenciador
{
    public Gerenciador() {}

    public Gerenciador(string usuario, decimal saldo)
    {
        this.Usuario = usuario;
        this.Saldo = saldo;
    }

    public string Usuario {get;set;}
    public decimal Saldo {get;set;}

    public void ReceberUSuario()
    {
        System.Console.WriteLine($"Ola {Usuario}, bem vindo!");
    }

    public void MostrarSaldo()
    {
        System.Console.WriteLine($"Seu saldo é de: {Saldo} Reais");
    }

    public void AddSaldo(decimal valor)
    {
        Saldo += valor;
        System.Console.WriteLine($"Voce adicionou: {valor}\nSaldo atual: {Saldo}");
    }
}