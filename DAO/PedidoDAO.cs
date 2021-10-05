using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerenciador_de_Estoque.MODEL;
using MySql.Data.MySqlClient;

namespace Gerenciador_de_Estoque.DAO
{
    class PedidoDAO : DAO
    {

        public PedidoDAO()
        {
            NomeTabela = "pedidos";
            ApelidoTabela = "Pedidos";

            NomeTodasColunas = new string[] { "idpedido", "operacaopedido", "pessoapedido", "datapedido", "fretepedido", "statuspedido", "financeiropedido" };
            ApelidoTodasColunas = new string[] {"ID", "Operação", "Pessoa/Empresa", "Data", "Frete", "Status", "Financeiro"};

            NomeColunasSelect = new string[] { "idpedido", "operacaopedido", "pessoapedido", "datapedido", "fretepedido", "statuspedido", "financeiropedido" };
            ApelidoColunasSelect = new string[] { "ID", "Operação", "Pessoa/Empresa", "Data", "Frete", "Status", "Financeiro" };

            ColunasInserir = new string[] { "operacaopedido", "pessoapedido", "datapedido", "fretepedido", "statuspedido", "financeiropedido" };
            ParametrosColunasInserir = new string[] {"operacao", "pessoapedido", "datapedido", "fretepedido", "statuspedido", "financeiro"};

            ColunasAlterar = new string[] { "operacaopedido", "pessoapedido", "datapedido", "fretepedido", "statuspedido", "financeiropedido" };
            ParametrosColunasAlterar = new string[] { "operacao", "pessoapedido", "datapedido", "fretepedido", "statuspedido", "financeiro" };
        }

        protected override void AddParametrosInserir(object obj)
        {
            Pedido pedido = obj as Pedido;
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[0], pedido.Operacao);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[1], pedido.Pessoa);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[2], pedido.Data);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[3], pedido.Frete);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[4], pedido.Status);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[5], pedido.Financeiro);
        }

        protected override void AddParametroAlterar(object obj)
        {
            Pedido pedido = obj as Pedido;
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[0], pedido.Operacao);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[1], pedido.Pessoa);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[2], pedido.Data);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[3], pedido.Frete);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[4], pedido.Status);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[5], pedido.Financeiro);
        }

        protected override object PreencherDados(MySqlDataReader dr)
        {
            Pedido pedido = new Pedido();
            if (dr.Read())
            {
                pedido.Id = dr.GetInt32(NomeTodasColunas[0]);
                pedido.Operacao = dr.GetString(NomeTodasColunas[1]);
                pedido.Pessoa = dr.GetString(NomeTodasColunas[2]);
                pedido.Data = dr.GetDateTime(NomeTodasColunas[3]);
                pedido.Frete = dr.GetDecimal(NomeTodasColunas[4]);
                pedido.Status = dr.GetString(NomeTodasColunas[5]);
                pedido.Financeiro = dr.GetString(NomeTodasColunas[6]);
            }
            else
            {
                pedido.Id = 0;
            }
            return pedido;
        }
    }
}
