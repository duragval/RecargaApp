using System;
using System.Collections.Generic;
using System.Text;

namespace RecargaApp
{
    public  abstract class Pessoa
    {
        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        protected string Nome {  get; set; }

        protected void ApresentarPrivado()
        {
            Console.WriteLine($"\nSeja bem vindo {Nome}");
        }

        public virtual void Info()
        {
            Console.WriteLine($"\nNome do proprietario do cartão: {Nome}");
        }
    }

}