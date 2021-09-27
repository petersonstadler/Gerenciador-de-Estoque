using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerenciador_de_Estoque.MODEL;
using MySql.Data.MySqlClient;

namespace Gerenciador_de_Estoque.DAO
{
    class MovimentoDAO : DAO
    {
        public MovimentoDAO()
        {
            nomeTabela = "movimentos";
            apelidoTabela = "Movimentos";

            nomeTodasColunas = new string[] { "idmovimento", "descmovimento", "qtdmovimento", "produtos_idproduto", "operacaomovimento", "pedidos_idpedido" };
            apelidoTodasColunas = new string[] { "Id", "Descrição", "Quantidade", "Produto", "Operação", "Id Pedido" };

            nomeColunasSelect = new string[] { "idmovimento", "descmovimento", "qtdmovimento", "produtos_idproduto", "operacaomovimento", "pedidos_idpedido" }; ;
            apelidoColunasSelect = new string[] { "Id", "Descrição", "Quantidade", "Produto", "Operação", "IdPedido" };

            colunasInserir = new string[] { "descmovimento", "qtdmovimento", "produtos_idproduto", "operacaomovimento", "pedidos_idpedido" };
            parametrosColunasInserir = new string[] { "?descricao", "?quantidade", "?idproduto", "?operacao", "?idpedido" };

            colunasAlterar = new string[] { "descmovimento" };
            parametrosColunasAlterar = new string[] { "?descricao" };
        }

        protected override void AddParametrosInserir(object obj)
        {
            Movimento movimento = obj as Movimento;
            cmd.Parameters.AddWithValue(parametrosColunasInserir[0], movimento.Descricao);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[1], movimento.Quantidade);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[2], movimento.Idproduto);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[3], movimento.Operacao);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[4], movimento.Idpedido);
        }

        protected override void AddParametroAlterar(object obj)
        {
            Movimento movimento = obj as Movimento;
            cmd.Parameters.AddWithValue(parametrosColunasAlterar[0], movimento.Descricao);
        }

        protected override object PreencherDados(MySqlDataReader dr)
        {
            Movimento movimento = new Movimento();
            if (dr.Read())
            {
                movimento.Id = dr.GetInt32("idmovimento");
                movimento.Descricao = dr.GetString("descmovimento");
                movimento.Quantidade = dr.GetInt32("qtdmovimento");
                movimento.Idproduto = dr.GetInt32("produtos_idproduto");
                movimento.Operacao = dr.GetString("operacaomovimento");
                movimento.Idpedido = dr.GetInt32("pedidos_idpedido");
            }
            else
            {
                movimento.Id = 0;
            }
            return movimento;
        }
    }
}
