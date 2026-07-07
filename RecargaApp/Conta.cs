using System;
using System.Collections.Generic;
using System.Text;

namespace RecargaApp
{
    public class Conta : Pessoa
    {
        public Conta(string nome,decimal saldo, int serial) : base (nome)
        {
            this.Saldo = saldo;
            this.Serial = serial;
        }

        public int Serial {  get; private set; }
        public decimal Saldo { get; private set; }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"\nNumero de serie do cartão: {Serial}");
        }

        public void MostraSaldo()
        {
            System.Console.WriteLine($"\nSeu saldo é de: {Saldo} Reais");
        }

        public void AddSaldo(decimal valor)
        {
            Saldo += valor;
            System.Console.WriteLine($"Voce adicionou: {valor}\nSaldo atual: {Saldo}");
        }

        public void Apresentar()
        {
            ApresentarPrivado();
        }
    }
}
