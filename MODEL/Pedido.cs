using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ItemNoPedidoDAO itensDAO = new ItemNoPedidoDAO();

        }
    }
}
