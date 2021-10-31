using System;
using System.Collections.Generic;
using Gerenciador_de_Estoque.DAO;

namespace Gerenciador_de_Estoque.MODEL
{
    public class Pedido
    {
        private int id;
        private string operacao;
        private string pessoa;
        private DateTime data;
        private decimal frete;
        private string status;
        private string financeiro;

        private List<ItemNoPedido> listaItens = new List<ItemNoPedido>();

        public int Id { get => id; set => id = value; }
        public string Operacao { get => operacao; set => operacao = value; }
        public string Pessoa { get => pessoa; set => pessoa = value; }
        public DateTime Data { get => data; set => data = value; }
        public decimal Frete { get => frete; set => frete = value; }
        public string Status { get => status; set => status = value; }
        public string Financeiro { get => financeiro; set => financeiro = value; }
        internal List<ItemNoPedido> ListaItens { get => listaItens; set => listaItens = value; }

        public void GerarListaDeItens()
        {
            listaItens = new List<ItemNoPedido>();
            ItemNoPedidoDAO itensDAO = new ItemNoPedidoDAO();
            List<object> lista = itensDAO.ListarComFiltro("pedidos_idpedido = " + this.id);
            foreach(object item in lista)
            {
                listaItens.Add(item as ItemNoPedido);
            }
            itensDAO.CloseConnections();
        }

        public decimal PegarValorTotalItensPedido()
        {
            decimal valor = 0;
            foreach(ItemNoPedido item in listaItens)
            {
                valor += ((decimal)item.Quantidade * item.Preco) + item.Acrescimo - item.Desconto;
            }
            return valor;
        }

        public decimal PegarValorTotalDesconto()
        {
            decimal valorDesconto = 0;
            foreach(ItemNoPedido item in listaItens)
            {
                valorDesconto += item.Desconto;
            }
            return valorDesconto;
        }

        public decimal PegarValorTotalAcrescimo()
        {
            decimal valorAcrescimo = 0;
            foreach(ItemNoPedido item in listaItens)
            {
                valorAcrescimo += item.Acrescimo;
            }
            return valorAcrescimo;
        }
    }
}
