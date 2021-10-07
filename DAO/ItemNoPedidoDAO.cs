using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            NomeTodasColunas = new string[] { "pedidos_idpedido", "produtos_idproduto", "preco", "qtd", "desconto", "acrescimo" };
            ApelidoTodasColunas = new string[] { "IdPedido", "IdPeoduto", "Preço", "Quantidade", "Desconto", "Acrescimo" };

            NomeColunasSelect = new string[] { "(SELECT nomeproduto FROM produtos WHERE idproduto = produtos_idproduto)", "preco", "qtd", "desconto", "acrescimo" };
            ApelidoColunasSelect = new string[] { "Produto", "Preço", "Quantidade", "Desconto", "Acréscimo" };

            ColunasInserir = NomeTodasColunas;
            ParametrosColunasInserir = new string[] { "?idpedido", "?idproduto", "?preco", "?quantidade", "?desconto", "?acrescimo" };

            ColunasAlterar = ColunasInserir;
            ParametrosColunasAlterar = ParametrosColunasInserir;
        }

        protected override void AddParametrosInserir(object obj)
        {
            ItemNoPedido itemNoPedido = obj as ItemNoPedido;
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[0], itemNoPedido.Idpedido);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[1], itemNoPedido.Idproduto);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[2], itemNoPedido.Preco);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[3], itemNoPedido.Quantidade);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[4], itemNoPedido.Desconto);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[5], itemNoPedido.Acrescimo);
        }

        protected override void AddParametroAlterar(object obj)
        {
            ItemNoPedido itemNoPedido = obj as ItemNoPedido;
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[0], itemNoPedido.Idpedido);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[1], itemNoPedido.Idproduto);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[2], itemNoPedido.Preco);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[3], itemNoPedido.Quantidade);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[4], itemNoPedido.Desconto);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[5], itemNoPedido.Acrescimo);
        }

        protected override object PreencherDados(MySqlDataReader dr)
        {
            ItemNoPedido itemNoPedido = new ItemNoPedido();
            if (dr.Read())
            {
                itemNoPedido.Idpedido = dr.GetInt32(0);
                itemNoPedido.Idproduto = dr.GetInt32(1);
                itemNoPedido.Preco = dr.GetDecimal(2);
                itemNoPedido.Quantidade = dr.GetInt32(3);
                itemNoPedido.Desconto = dr.GetDecimal(4);
                itemNoPedido.Acrescimo = dr.GetDecimal(5);
            }
            return itemNoPedido;
        }
    }
}
