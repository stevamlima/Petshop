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
        public Clientes(string Nome, string Idade, string Genero, string Cpf, string Logradouro, string Num, string Bairro, string Cidade, string Estado, string Cep, string ID)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Genero = Genero;
            this.End.Logradouro = Logradouro;
            this.End.Numero = Num;
            this.End.Bairro = Bairro;
            this.End.Cidade = Cidade;
            this.End.Estado = Estado;
            this.End.Cep = Cep;
            this.Cpf = Cpf;
            this.ID = ID;
        }
        
    }   
}