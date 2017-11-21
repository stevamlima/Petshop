using System;
using System.IO;
using System.Text;

namespace Dominio
{
    public class Clientes
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Genero { get; set; }
        public Endereco End { get; set; }
        public string Cpf { get; set; }
        public string ID { get; set; }

        public Clientes()
        {

        }
        public Clientes(string Nome, string Idade, string Genero, string Cpf, Endereco End, string ID)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Genero = Genero;
            this.End = End;
            this.Cpf = Cpf;
            this.ID = ID;
        }
        
    }   
}