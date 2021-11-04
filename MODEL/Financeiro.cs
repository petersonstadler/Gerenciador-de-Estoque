using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Estoque.MODEL
{
    class Financeiro
    {
        private DateTime dataInicial, dataFinal;
        private decimal faturamento, lucro, fiado, custo;

        public DateTime DataInicial { get => dataInicial; set => dataInicial = value; }
        public DateTime DataFinal { get => dataFinal; set => dataFinal = value; }
        public decimal Faturamento { get => faturamento; set => faturamento = value; }
        public decimal Lucro { get => lucro; set => lucro = value; }
        public decimal Fiado { get => fiado; set => fiado = value; }
        public decimal Custo { get => custo; set => custo = value; }
    }
}
