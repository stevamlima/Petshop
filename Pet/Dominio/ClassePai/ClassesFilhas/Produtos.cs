using System;
using Dominio;

namespace Dominio
{
    public class Produtos : Dominio.Vendas
    {
        public int IdProd {get; set; }

        public string TipoProd { get; set; }

        public int QuantidadeProd { get; set; }

        public double PrecoProd {get ; set;}


        public Produtos()
        {
            
        }

        public Produtos(int IdVenda, string DescricaoVenda, DateTime DataVenda, double PrecoVenda, int IdProd, string TipoProd, int QuantidadeProd, double PrecoProd)
        {
                base.IdVenda = IdVenda;
                base.DescricaoVenda = DescricaoVenda;
                base.DataVenda = DataVenda;
                base.PrecoVenda = PrecoVenda;
                this.IdProd = IdProd;
                this.TipoProd = TipoProd;
                this.QuantidadeProd = QuantidadeProd;
                this.PrecoProd = PrecoProd;

        }
    }
}