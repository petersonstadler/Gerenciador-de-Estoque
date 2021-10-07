using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
