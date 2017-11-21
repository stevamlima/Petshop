using System;
using System.IO;
using System.Text;
using Dominio;
using Repositorio;

namespace ProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimaisRep PesAnimal = new AnimaisRep();
            ClientesRep PesClientes = new ClientesRep();
            string op1 = "";
            string op2 = "";
            string op3 = "";
            do
            {
            Console.WriteLine("\nBem-vindo ao nosso sistema de cadastro");
            Console.WriteLine("1- Cadastrar/pesquisar cliente");
            Console.WriteLine("2- Cadastrar/pesquisar animal");
            Console.WriteLine("3- Cadastrar/pesquisar Produto");
            Console.WriteLine("4- Cadastrar/pesquisar Serviço");
            Console.WriteLine("5- Emitir extrato de compras");
            Console.WriteLine("9- Sair");
            Console.Write("\nEscolha uma das opções acima: ");
            op1 = Console.ReadLine();

            switch(op1)
            {
                case "1":
                Console.Clear();
                Console.WriteLine("Cadastro do cliente");
                Console.WriteLine("\n1- Cadastrar cliente");
                Console.WriteLine("2- Pesquisar cliente");
                Console.WriteLine("9- Voltar");
                Console.Write("\nEscolha uma das opções acima:  ");
                op2 = Console.ReadLine();

                switch(op2)
                {
                    case "1":
                    CadastraClientes();
                    break;

                    case "2":
                    Console.Write("Pesquisar ID do cliente:  ");
                    string pesquisa = Console.ReadLine();
                    Console.WriteLine("Resultado da pesquisa: "+PesClientes.Consultar(pesquisa));
                    break;

                    case "9":
                    break;
                }
                break;

                case "2":
                Console.Clear();
                Console.WriteLine("Cadastro do animal");
                Console.WriteLine("\n1- Cadastrar animal");
                Console.WriteLine("2- Pesquisar animal");
                Console.WriteLine("9- Voltar");
                Console.Write("\nEscolha uma das opções acima:  ");
                op3 = Console.ReadLine();

                switch(op3)
                {
                    case "1":
                    CadastraAnimais();
                    break;

                    case "2":
                    Console.Write("Pesquisar ID do animal:  ");
                    string pesquisa = Console.ReadLine();
                    Console.WriteLine("Resultado da pesquisa: "+PesAnimal.Consultar(pesquisa));
                    break;

                    case "9":
                    break;
                }
                break;

            }
            }while(op1 != "9");

        }

        static void CadastraAnimais()
        {
            //============================================LÓGICA DO CADASTRO DE ANIMAIS=============================================================
            AnimaisRep PesAnimal = new AnimaisRep();

            Console.WriteLine("Cadastro de animais");
            Console.Write("\nDigite qual animal você deseja cadastrar: "); string tipo = Console.ReadLine();
            Console.Write("Digite a raça do seu animal: "); string raca = Console.ReadLine();
            Console.Write("Digite a cor do seu animal: "); string cor = Console.ReadLine();
            Console.Write("Digite o nome do seu animal: "); string nome = Console.ReadLine();
            Console.Write("Digite a data de nascimento do seu animal: "); DateTime nascimento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite o porte do seu animal: "); string porte = Console.ReadLine();

            //============LÓGICA QUE VERIFICA A REPETIÇÃO DO ID============
            string id = string.Empty;
            Random num = new Random();
            do
            {
                id = num.Next(0,100).ToString();
            }while(PesAnimal.VerificarRepID(id) == id);
            //=============================================================

            //======================================LÓGICA QUE CADASTRA O ANIMAL APÓS A VERIFICAÇÃO DO ID===========================================
            Animais animais = new Animais(tipo,raca,cor,nome,nascimento,porte,id);
            bool cadastrosucesso = PesAnimal.Cadastrar(animais);

            if(cadastrosucesso) Console.WriteLine("\nAnimal cadastrado com sucesso. Seu ID para consultas futuras é: " + id);
            else Console.WriteLine("\nOcorreu um erro no processo de cadastramento, contacte o ADM.");
            //=======================================================================================================================================

        }

        static void CadastraClientes()
        {
            //============================================LÓGICA DO CADASTRO DE CLIENTES==============================================================
            ClientesRep CadClientes = new ClientesRep();
            Endereco end = new Endereco();

            Console.WriteLine("Cadastro de clientes");
            Console.Write("\nDigite seu nome: "); string nome = Console.ReadLine();
            Console.Write("Digite sua idade: "); string idade = Console.ReadLine();
            Console.Write("Digite seu gênero: "); string genero = Console.ReadLine();
            Console.Write("Digite seu CPF: "); string cpf = Console.ReadLine();
            Console.WriteLine("\nEndereço");
            Console.Write("Digite o logradouro: "); end.Logradouro = Console.ReadLine();
            Console.Write("Digite o número: "); end.Numero = Console.ReadLine();
            Console.Write("Digite o bairro: "); end.Bairro = Console.ReadLine();
            Console.Write("Digite a cidade: "); end.Cidade = Console.ReadLine();
            Console.Write("Digite o estado: "); end.Estado = Console.ReadLine();
            Console.Write("Digite o CEP: "); end.Cep = Console.ReadLine();

            //======================================LÓGICA QUE CADASTRA O CLIENTE===========================================
            string idinit = "1";
            if(!File.Exists("CadastroClientes.csv"))
            {  
            Clientes clientes = new Clientes(nome, idade, genero, cpf, end , idinit);  
            bool cadastrosucesso = CadClientes.Cadastrar(clientes);

            if(cadastrosucesso) Console.WriteLine("\nCliente cadastrado com sucesso. Seu ID para consultas futuras é: " + idinit);
            else Console.WriteLine("\nOcorreu um erro no processo de cadastramento, contacte o ADM.");
            }
            else
            {
            //============LÓGICA QUE VERIFICA A REPETIÇÃO DO ID============
            string id = string.Empty;
            Random num = new Random();
            do
            {
                id = num.Next(0,100).ToString();
            }while(CadClientes.VerificarRepID(id) == id);
            //=============================================================

            Clientes clientes = new Clientes(nome, idade, genero, cpf, end , id);  
            bool cadastrosucesso = CadClientes.Cadastrar(clientes);

            if(cadastrosucesso) Console.WriteLine("\nCliente cadastrado com sucesso. Seu ID para consultas futuras é: " + id);
            else Console.WriteLine("\nOcorreu um erro no processo de cadastramento, contacte o ADM.");
            }
            //==============================================================================================================

            

        }

    }
}
