using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciador_de_Estoque.MODEL;
using MySql.Data.MySqlClient;

namespace Gerenciador_de_Estoque.DAO
{
    class MovimentoDAO : DAO
    {
        public MovimentoDAO()
        {
            NomeTabela = "movimentos";
            ApelidoTabela = "Movimentos";

            NomeTodasColunas = new string[] { "idmovimento", "descmovimento", "qtdmovimento", "produtos_idproduto", "operacaomovimento", "pedidos_idpedido" };
            ApelidoTodasColunas = new string[] { "Id", "Descrição", "Quantidade", "Produto", "Operação", "IdPedido" };

            NomeColunasSelect = new string[] { "idmovimento", "descmovimento", "qtdmovimento", "produtos_idproduto", "operacaomovimento", "pedidos_idpedido" };
            ApelidoColunasSelect = new string[] { "Id", "Descrição", "Quantidade", "Produto", "Operação", "IdPedido" };

            ColunasInserir = new string[] { "descmovimento", "qtdmovimento", "produtos_idproduto", "operacaomovimento", "pedidos_idpedido" };
            ParametrosColunasInserir = new string[] { "?descricao", "?quantidade", "?idproduto", "?operacao", "?idpedido" };

            ColunasAlterar = new string[] { "descmovimento" };
            ParametrosColunasAlterar = new string[] { "?descricao" };
        }

        protected override void AddParametrosInserir(object obj)
        {
            Movimento movimento = obj as Movimento;
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[0], movimento.Descricao);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[1], movimento.Quantidade);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[2], movimento.Idproduto);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[3], movimento.Operacao);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[4], movimento.Idpedido);
        }

        protected override void AddParametroAlterar(object obj)
        {
            Movimento movimento = obj as Movimento;
            cmd.Parameters.AddWithValue(ParametrosColunasAlterar[0], movimento.Descricao);
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

        public DataTable ListarPorFiltroIdProduto(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                string colunas = new GeradorScriptsSql().ColunasParaString(NomeColunasSelect, ApelidoColunasSelect);
                cmd.CommandText = "SELECT " + colunas + " FROM " + NomeTabela + " WHERE produtos_idproduto = ?id";
                cmd.Parameters.AddWithValue("?id", id);
                MySqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao listar movimentos por filtro de produtos! \n\n" + e, "Listar Movimentos com Filtro de Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        protected override List<object> PreencherLista(MySqlDataReader dr)
        {
            List<object> lista = new List<object>();
            while (dr.Read())
            {
                Movimento movimento = new Movimento();
                movimento.Id = dr.GetInt32(0);
                movimento.Descricao = dr.GetString(1);
                movimento.Quantidade = dr.GetFloat(2);
                movimento.Idproduto = dr.GetInt32(3);
                movimento.Operacao = dr.GetString(4);
                movimento.Idpedido = dr.GetInt32(5);
                lista.Add(movimento);
            }
            return lista;
        }


        public void ExcluirMovimentoDePedido(Pedido pedido)
        {
            List<object> listaMovimentos = ListarComFiltro("pedidos_idpedido = " + pedido.Id);
            if(listaMovimentos.Count > 0)
            {
                foreach(object obj in listaMovimentos)
                {
                    Movimento movimento = obj as Movimento;
                    Deletar(movimento.Id);
                }
            }
        }

        public void CriarMovimentoDePedido(Pedido pedido)
        {
            ExcluirMovimentoDePedido(pedido);
            foreach(ItemNoPedido item in pedido.ListaItens)
            {
                Movimento movimentoItem = new Movimento();
                movimentoItem.Descricao = "Movimento gerado pelo pedido: " + pedido.Id;
                movimentoItem.Quantidade = item.Quantidade;
                movimentoItem.Idproduto = item.Idproduto;
                movimentoItem.Operacao = pedido.Operacao;
                movimentoItem.Idpedido = pedido.Id;
                Inserir(movimentoItem);
            }
        }
    }
}
