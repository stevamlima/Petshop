using System;

namespace Pet.Dominio.ClassePai.ClassesFilhas
{
    public class Servicos : Vendas
    {
        public int IdServico {get; set;}
        
        public string HorarioServico { get; set; }

        public string DuracaoServico { get; set; }

        public double PrecoServico {get ; set;}

        public Servicos()
        {
            
        }

        public Servicos(int IdVenda, string DescricaoVenda, DateTime DataVenda, double PrecoVenda, int IdServico, string HorarioServico, string DuracaoServico, double PrecoServico)
        {
                base.IdVenda = IdVenda;
                base.DescricaoVenda = DescricaoVenda;
                base.DataVenda = DataVenda;
                base.PrecoVenda = PrecoVenda;
                this.HorarioServico = HorarioServico;
                this.DuracaoServico = DuracaoServico;
                this.PrecoServico = PrecoServico;

        }
    }
}