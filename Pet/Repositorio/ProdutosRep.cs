using System;
using Pet.Dominio.ClassePai.ClassesFilhas;

namespace Repositorio
{
    public class ProdutosRep : Dominio.ICrud
    {
        public string Cadastrar()
        {
        Produtos pr = new Produtos();
        string composicao = "Código do Produto: "+ pr.IdProd+
                            "Tipo do Produto: "+pr.TipoProd+
                            "Quantidade do Produto: "+pr.QuantidadeProd+
                            "Preço do Produto: "+pr.PrecoProd;
                                
        return "Informações do Produto\n\n"+composicao; 
        }

        public string Consultar(string ID)
        {
            throw new NotImplementedException();
        }
    }
}