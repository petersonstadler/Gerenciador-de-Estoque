using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Gerenciador_de_Estoque.DAO
{
    class FinanceiroDAO : DAO
    {
        public decimal CalcularFaturamentoPorPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            decimal faturamento = 0;
            string inicio = dataInicial.Year + "-" + dataInicial.Month + "-" + dataInicial.Day + " 00-00-00";
            string final = dataFinal.Year + "-" + dataFinal.Month + "-" + dataFinal.Day + " 23-59-59";
            try
            {
                cmd.CommandText = $"SELECT COALESCE(SUM(preco) - SUM(desconto) + SUM(acrescimo) - (SELECT SUM(fretepedido) FROM pedidos WHERE statuspedido = 'Fechado' AND operacaopedido = 'SAIDA'), 0) as Faturamento FROM pedidos_has_produtos WHERE (SELECT statuspedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Fechado' AND (SELECT financeiropedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Pago' AND (SELECT operacaopedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'SAIDA' AND (SELECT datapedido FROM pedidos WHERE idpedido = pedidos_idpedido) BETWEEN '{inicio}' AND '{final}'";
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

        public decimal CalcularGastosPorPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            decimal gastos = 0;
            string inicio = dataInicial.Year + "-" + dataInicial.Month + "-" + dataInicial.Day + " 00-00-00";
            string final = dataFinal.Year + "-" + dataFinal.Month + "-" + dataFinal.Day + " 23-59-59";
            try
            {
                cmd.CommandText = $"SELECT COALESCE(SUM(custo) - SUM(desconto) + SUM(acrescimo) + (SELECT SUM(fretepedido) FROM pedidos WHERE statuspedido = 'Fechado' AND operacaopedido = 'ENTRADA'), 0) as Gastos FROM pedidos_has_produtos WHERE (SELECT statuspedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Fechado' AND (SELECT financeiropedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Pago' AND (SELECT operacaopedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'ENTRADA' AND (SELECT datapedido FROM pedidos WHERE idpedido = pedidos_idpedido) BETWEEN '{inicio}' AND '{final}'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    gastos = dr.GetDecimal("Gastos");
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao Calcular Faturamento! \n\n" + e, "Financeiro: Calcular Faturamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return gastos;
        }
    }
}
