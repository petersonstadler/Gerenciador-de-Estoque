using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gerenciador_de_Estoque.MODEL;
using MySql.Data.MySqlClient;

namespace Gerenciador_de_Estoque.DAO
{
    class ItemNoPedidoDAO : DAO
    {
        public ItemNoPedidoDAO()
        {
            NomeTabela = "pedidos_has_produtos";
            ApelidoTabela = "ItensPedido";

            NomeTodasColunas = new string[] { "pedidos_idpedido", "produtos_idproduto", "custo", "preco", "qtd", "desconto", "acrescimo" };
            ApelidoTodasColunas = new string[] { "IdPedido", "IdPeoduto", "Custo", "Preço", "Quantidade", "Desconto", "Acrescimo" };

            NomeColunasSelect = new string[] { "(SELECT nomeproduto FROM produtos WHERE idproduto = produtos_idproduto)", "preco", "qtd", "desconto", "acrescimo" };
            ApelidoColunasSelect = new string[] { "Produto", "Preço", "Quantidade", "Desconto", "Acréscimo" };

            ColunasInserir = NomeTodasColunas;
            ParametrosColunasInserir = new string[] { "?idpedido", "?idproduto", "?custo","?preco", "?quantidade", "?desconto", "?acrescimo" };

            ColunasAlterar = ColunasInserir;
            ParametrosColunasAlterar = ParametrosColunasInserir;
        }

        protected override void AddParametrosInserir(object obj)
        {
            ItemNoPedido itemNoPedido = obj as ItemNoPedido;
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[0], itemNoPedido.Idpedido);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[1], itemNoPedido.Idproduto);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[2], itemNoPedido.Custo);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[3], itemNoPedido.Preco);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[4], itemNoPedido.Quantidade);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[5], itemNoPedido.Desconto);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[6], itemNoPedido.Acrescimo);
        }

        protected override void AddParametroAlterar(object obj)
        {
            ItemNoPedido itemNoPedido = obj as ItemNoPedido;
            cmd.Parameters.AddWithValue(ParametrosColunasAlterar[0], itemNoPedido.Idpedido);
            cmd.Parameters.AddWithValue(ParametrosColunasAlterar[1], itemNoPedido.Idproduto);
            cmd.Parameters.AddWithValue(ParametrosColunasAlterar[2], itemNoPedido.Custo);
            cmd.Parameters.AddWithValue(ParametrosColunasAlterar[3], itemNoPedido.Preco);
            cmd.Parameters.AddWithValue(ParametrosColunasAlterar[4], itemNoPedido.Quantidade);
            cmd.Parameters.AddWithValue(ParametrosColunasAlterar[5], itemNoPedido.Desconto);
            cmd.Parameters.AddWithValue(ParametrosColunasAlterar[6], itemNoPedido.Acrescimo);
        }

        protected override object PreencherDados(MySqlDataReader dr)
        {
            ItemNoPedido itemNoPedido = new ItemNoPedido();
            if (dr.Read())
            {
                itemNoPedido.Idpedido = dr.GetInt32(0);
                itemNoPedido.Idproduto = dr.GetInt32(1);
                itemNoPedido.Custo = dr.GetDecimal(2);
                itemNoPedido.Preco = dr.GetDecimal(3);
                itemNoPedido.Quantidade = dr.GetInt32(4);
                itemNoPedido.Desconto = dr.GetDecimal(5);
                itemNoPedido.Acrescimo = dr.GetDecimal(6);
            }
            return itemNoPedido;
        }

        public List<ItemNoPedido> ListarItensDoPedido(Pedido pedido)
        {
            List<ItemNoPedido> itens = new List<ItemNoPedido>();
            try
            {
                cmd.CommandText = new GeradorScriptsSql().GerarSqlSELECT(NomeTabela, NomeTodasColunas, ApelidoTodasColunas) + " WHERE pedidos_idpedido = " + pedido.Id;
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ItemNoPedido itemAtual = new ItemNoPedido();
                    itemAtual.Idpedido = dr.GetInt32(NomeTodasColunas[0]);
                    itemAtual.Idproduto = dr.GetInt32(NomeTodasColunas[1]);
                    itemAtual.Custo = dr.GetDecimal(NomeTodasColunas[2]);
                    itemAtual.Preco = dr.GetDecimal(NomeTodasColunas[3]);
                    itemAtual.Quantidade = dr.GetInt32(NomeTodasColunas[4]);
                    itemAtual.Desconto = dr.GetDecimal(NomeTodasColunas[5]);
                    itemAtual.Acrescimo = dr.GetDecimal(NomeTodasColunas[6]);
                    itens.Add(itemAtual);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Falha ao tentar listar Itens do Pedido! " + e, "Listar Itens do Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return itens;
        }

        protected override List<object> PreencherLista(MySqlDataReader dr)
        {
            List<object> lista = new List<object>();
            while (dr.Read())
            {
                ItemNoPedido item = new ItemNoPedido();
                item.Idpedido = dr.GetInt32(0);
                item.Idproduto = dr.GetInt32(1);
                item.Custo = dr.GetDecimal(2);
                item.Preco = dr.GetDecimal(3);
                item.Quantidade = dr.GetInt32(4);
                item.Desconto = dr.GetDecimal(5);
                item.Acrescimo = dr.GetDecimal(6);
                lista.Add(item);
            }
            return lista;
        }
    }
}
