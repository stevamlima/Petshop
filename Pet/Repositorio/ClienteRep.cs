using System;
using System.IO;
using System.Text;
using Dominio;

namespace Repositorio
{       
    public class ClientesRep : Dominio.ICrud
    {
        public bool Cadastrar(Clientes clientes) //método para cadastrar o EVENTO
        {
            bool efetuado = false;
            StreamWriter arquivo = null;

            try
            {
                arquivo = new StreamWriter("CadastroClientes.csv", true); 
                arquivo.WriteLine(
                    clientes.ID + ";"+
                    clientes.Nome + ";" + // fazendo um get
                    clientes.Idade + ";" + // outro get
                    clientes.Genero + ";" +
                    clientes.Cpf + ";" +
                    clientes.End.Logradouro + ";" + // Acessamos a classe Cat (categoria) e acessamos o parâmetro Nome
                    clientes.End.Numero + ";" +
                    clientes.End.Bairro + ";" +
                    clientes.End.Cidade + ";" +
                    clientes.End.Estado + ";" +
                    clientes.End.Cep
                );
                efetuado = true;
            }
            
            catch(Exception ex)
            {
                throw new Exception("Erro ao tentar gravar o arquivo!"+ex.Message); //exibe uma mensagem avisando que não foi possível gravar no arquivo
            }
            finally //fecha o arquivo após o TRY/CATCH
            {
                arquivo.Close();
            }
            return efetuado;
        }
        //===============================================================================================================================================


        //================================================LÓGICA PARA FAZER A CONSULTA DOS DADOS DO CSV==================================================
        public string Consultar(string ID) //método para pesquisar o EVENTO por TÍTULO
        {
            string resultado = ("ID não encontrada");
            StreamReader ler = null;

            try
            {
                ler = new StreamReader("CadastroClientes.csv", Encoding.Default); //Encoding.Default serve para utilizar
                string linha = "";
                while((linha=ler.ReadLine())!=null)
                {
                    string[] dados = linha.Split(';');
                    if(dados[0] == ID)
                    {
                        resultado = linha;
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                resultado = ("Erro ao tentar ler o arquivo!"+ex.Message);
            }
            finally
            {
                ler.Close();
            }

            return resultado;
        }
        //===============================================================================================================================================
        
        public string VerificarRepID(string ID) //método para pesquisar o EVENTO por TÍTULO
        {
            string resultado = "";
            StreamReader ler = null;

            try
            {
                ler = new StreamReader("CadastroClientes.csv", Encoding.Default); //Encoding.Default serve para utilizar
                string linha = "";
                while((linha=ler.ReadLine())!=null)
                {
                    string[] dados = linha.Split(';');
                    if(dados[0] == ID)
                    {
                        resultado = ID;
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                resultado = ("Erro ao tentar ler o arquivo!"+ex.Message);
            }
            finally
            {
                ler.Close();
            }

            return resultado;
        }
        //===============================================================================================================================================
    
    }
}