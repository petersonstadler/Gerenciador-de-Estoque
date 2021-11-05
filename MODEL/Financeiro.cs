using System;

namespace Gerenciador_de_Estoque.MODEL
{
    class Financeiro
    {
        private DateTime dataInicial, dataFinal;
        private decimal faturamento, lucro, fiado, gastos, dividas, lucroDasVendas;

        public DateTime DataInicial { get => dataInicial; set => dataInicial = value; }
        public DateTime DataFinal { get => dataFinal; set => dataFinal = value; }
        public decimal Faturamento { get => faturamento; set => faturamento = value; }
        public decimal Lucro { get => lucro; set => lucro = value; }
        public decimal Fiado { get => fiado; set => fiado = value; }
        public decimal Gastos { get => gastos; set => gastos = value; }
        public decimal Dividas { get => dividas; set => dividas = value; }
        public decimal LucroDasVendas { get => lucroDasVendas; set => lucroDasVendas = value; }
    }
}
