using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_Estoque.DAO
{
    class FinanceiroDAO : DAO
    {
        public decimal CalcularFaturamento(DateTime dataInicial, DateTime dataFinal)
        {
            decimal faturamento = 0;
            string inicio = dataInicial.Year + "-" + dataInicial.Month + "-" + dataInicial.Day;
            string final = dataFinal.Year + "-" + dataFinal.Month + "-" + dataFinal.Day;
            try
            {
                cmd.CommandText = $"SELECT coalesce(SUM(preco), 0) as Faturamento  FROM pedidos_has_produtos WHERE (SELECT statuspedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Fechado' AND (SELECT financeiropedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Pago' AND (SELECT operacaopedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'SAIDA' AND (SELECT datapedido FROM pedidos WHERE idpedido = pedidos_idpedido) BETWEEN '{inicio}' AND '{final}';";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    faturamento = dr.GetDecimal("Faturamento");
                }
                dr.Close();
            }catch(Exception e)
            {
                MessageBox.Show("Falha ao Calcular Faturamento! \n\n" + e, "Financeiro: Calcular Faturamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return faturamento;
        }
    }
}
