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
            AnimaisRep PesAnimal = new AnimaisRep(); //Instancia a classe ANIMAISREP
            string escolha = "";
            string opcao = "";
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
            escolha = Console.ReadLine();

            switch(escolha)
            {
                case "1":
                Console.Clear();
                Console.WriteLine("Cadastro do animal");
                Console.WriteLine("\n1- Cadastrar animal");
                Console.WriteLine("2- Pesquisar animal");
                Console.WriteLine("9- Voltar");
                Console.WriteLine("\nEscolha uma das opções acima: ");
                opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                    CadastraClientes();
                    break;
                    case "2":
                    Console.Write("Pesquisar ID do animal:  ");
                    string pesquisa = Console.ReadLine();
                    Console.WriteLine(PesAnimal.Consultar(pesquisa));
                    break;
                    case "9":
                    break;
                }
                break;

                case "2":
                Console.Clear();
                CadastraAnimais();
                break;
            }
            }while(escolha != "9");

        }

        static void CadastraAnimais()
        {
            //============================================LÓGICA DO CADASTRO DE ANIMAIS==============================================================
            AnimaisRep PesAnimal = new AnimaisRep(); //Instancia a classe ANIMAISREP

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

            Animais animais = new Animais(tipo,raca,cor,nome,nascimento,porte,id);  //Instancia a classe ANIMAIS pedindo os parâmetros estabelecidos
            bool cadastrosucesso = PesAnimal.Cadastrar(animais);

            if(cadastrosucesso) Console.WriteLine("\nAnimal cadastrado com sucesso. Seu ID para consultas futuras é: " + id);
            else Console.WriteLine("\nOcorreu um erro no processo de cadastramento, contacte o ADM.");
            //=======================================================================================================================================

        }

        static void CadastraClientes()
        {
            //============================================LÓGICA DO CADASTRO DE CLIENTES==============================================================
            Console.WriteLine("Cadastro de clientes");
            Console.Write("\nDigite seu nome: "); string nome = Console.ReadLine();
            Console.Write("Digite sua idade: "); string idade = Console.ReadLine();
            Console.Write("Digite seu gênero: "); string genero = Console.ReadLine();
            Console.Write("Digite seu CPF: "); string cpf = Console.ReadLine();
            Console.WriteLine("\nEndereço");
            Console.Write("Digite o logradouro: "); string logradouro = Console.ReadLine();
            Console.Write("Digite o número: "); string num = Console.ReadLine();
            Console.Write("Digite o bairro: "); string bairro = Console.ReadLine();
            Console.Write("Digite a cidade: "); string cidade = Console.ReadLine();
            Console.Write("Digite o estado: "); string estado = Console.ReadLine();
            Console.Write("Digite o CEP: "); string cep = Console.ReadLine();



            ClientesRep CadClientes = new ClientesRep(); //Instancia a classe ANIMAISREP
            
            //============LÓGICA QUE VERIFICA A REPETIÇÃO DO ID============
            string id = string.Empty;
            Random num2 = new Random();
            do
            {
                id = num2.Next(0,100).ToString();
            }while(CadClientes.VerificarRepID(id) == id);
            //=============================================================

            //======================================LÓGICA QUE CADASTRA O CLIENTE APÓS A VERIFICAÇÃO DO ID===========================================

            Clientes clientes = new Clientes(nome, idade, genero, cpf, logradouro, num, bairro, cidade, estado, cep, id);  //Instancia a classe ANIMAIS pedindo os parâmetros estabelecidos
            bool cadastrosucesso = CadClientes.Cadastrar(clientes);

            if(cadastrosucesso) Console.WriteLine("\nCliente cadastrado com sucesso. Seu ID para consultas futuras é: " + id);
            else Console.WriteLine("\nOcorreu um erro no processo de cadastramento, contacte o ADM.");

            Console.Write("Pesquisar ID do animal:  ");
            string pesquisa = Console.ReadLine();
            Console.WriteLine(CadClientes.Consultar(pesquisa));
            //=======================================================================================================================================

        }

    }
}
