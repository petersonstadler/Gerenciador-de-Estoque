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
                cmd.CommandText = $"SELECT COALESCE(SUM((preco * qtd) - desconto + acrescimo), 0) as Faturamento FROM pedidos_has_produtos WHERE (SELECT statuspedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Fechado' AND (SELECT financeiropedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Pago' AND (SELECT operacaopedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'SAIDA' AND (SELECT datapedido FROM pedidos WHERE idpedido = pedidos_idpedido) BETWEEN '{inicio}' AND '{final}'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    faturamento = dr.GetDecimal("Faturamento");
                }
                dr.Close();
            }
            catch (Exception e)
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
                cmd.CommandText = $"SELECT COALESCE(SUM((custo * qtd) - desconto + acrescimo + (SELECT fretepedido FROM pedidos WHERE idpedido = pedidos_idpedido)), 0) as Gastos FROM pedidos_has_produtos WHERE (SELECT statuspedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Fechado' AND (SELECT financeiropedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Pago' AND (SELECT operacaopedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'ENTRADA' AND (SELECT datapedido FROM pedidos WHERE idpedido = pedidos_idpedido) BETWEEN '{inicio}' AND '{final}'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    gastos = dr.GetDecimal("Gastos");
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao Calcular Gastos! \n\n" + e, "Financeiro: Calcular Gastos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return gastos;
        }

        public decimal CalcularFiadosPorPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            decimal fiados = 0;
            string inicio = dataInicial.Year + "-" + dataInicial.Month + "-" + dataInicial.Day + " 00-00-00";
            string final = dataFinal.Year + "-" + dataFinal.Month + "-" + dataFinal.Day + " 23-59-59";
            try
            {
                cmd.CommandText = $"SELECT COALESCE(SUM(preco * qtd - desconto + acrescimo), 0) as Fiados  FROM pedidos_has_produtos WHERE (SELECT statuspedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Fechado' AND (SELECT financeiropedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Fiado' AND (SELECT operacaopedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'SAIDA' AND (SELECT datapedido FROM pedidos WHERE idpedido = pedidos_idpedido) BETWEEN '{inicio}' AND '{final}'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    fiados = dr.GetDecimal("Fiados");
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao Calcular Fiados! \n\n" + e, "Financeiro: Calcular Fiados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return fiados;
        }

        public decimal CalcularDividasPorPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            decimal dividas = 0;
            string inicio = dataInicial.Year + "-" + dataInicial.Month + "-" + dataInicial.Day + " 00-00-00";
            string final = dataFinal.Year + "-" + dataFinal.Month + "-" + dataFinal.Day + " 23-59-59";
            try
            {
                cmd.CommandText = $"SELECT COALESCE(SUM(custo * qtd - desconto + acrescimo + (SELECT fretepedido FROM pedidos WHERE idpedido = pedidos_idpedido)), 0) as Dividas  FROM pedidos_has_produtos WHERE (SELECT statuspedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Fechado' AND (SELECT financeiropedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Fiado' AND (SELECT operacaopedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Entrada' AND (SELECT datapedido FROM pedidos WHERE idpedido = pedidos_idpedido) BETWEEN '{inicio}' AND '{final}'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dividas = dr.GetDecimal("Dividas");
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao Calcular Dividas! \n\n" + e, "Financeiro: Calcular Dividas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dividas;
        }

        public decimal CalcularLucroDeVendasPorPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            decimal lucro = 0;
            string inicio = dataInicial.Year + "-" + dataInicial.Month + "-" + dataInicial.Day + " 00-00-00";
            string final = dataFinal.Year + "-" + dataFinal.Month + "-" + dataFinal.Day + " 23-59-59";
            try
            {
                cmd.CommandText = $"SELECT COALESCE(SUM((preco * qtd) - (custo * qtd) - desconto + acrescimo - (select fretepedido from pedidos where idpedido = pedidos_idpedido)), 0) as Lucro FROM  pedidos_has_produtos WHERE (SELECT statuspedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Fechado' AND (SELECT financeiropedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'Pago' AND (SELECT operacaopedido FROM pedidos WHERE idpedido = pedidos_idpedido) = 'SAIDA' AND (SELECT datapedido FROM pedidos WHERE idpedido = pedidos_idpedido) BETWEEN '{inicio}' AND '{final}'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lucro = dr.GetDecimal("Lucro");
                }
                dr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Falha ao Calcular Lucro das Vendas! \n\n" + e, "Financeiro: Calcular Lucro das Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lucro;
        }
    }
}