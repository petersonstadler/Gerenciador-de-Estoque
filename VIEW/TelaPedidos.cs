using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciador_de_Estoque.DAO;
using Gerenciador_de_Estoque.MODEL;
using Gerenciador_de_Estoque.VIEW.TelaPedidos;

namespace Gerenciador_de_Estoque.VIEW
{
    public partial class TelaPedidos1 : Form
    {
        private Pedido pedidoSelecionado;

        private void Carregar()
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            dataGridPedidos.DataSource = pedidoDAO.ListarEmDataTable();
            pedidoDAO.CloseConnections();
        }

        public TelaPedidos1()
        {
            InitializeComponent();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChamarFormPedidoCriar()
        {
            FormPedido formPedido = new FormPedido();
            formPedido.ShowDialog();
            if(formPedido.DialogResult == DialogResult.OK)
            {
                PedidoDAO pedidoDAO = new PedidoDAO();
                dataGridPedidos.DataSource = pedidoDAO.ListarEmDataTable();
                pedidoDAO.CloseConnections();
            }
            formPedido.Dispose();
        }

        private void ChamarFormPedidoAlterar()
        {
            if (pedidoSelecionado != null)
            {
                FormPedido formPedido = new FormPedido(pedidoSelecionado);
                formPedido.ShowDialog();
                if (formPedido.DialogResult == DialogResult.OK)
                {
                    PedidoDAO pedidoDAO = new PedidoDAO();
                    dataGridPedidos.DataSource = pedidoDAO.ListarEmDataTable();
                    pedidoDAO.CloseConnections();
                }
                formPedido.Dispose();
            }
        }

        private void MenuPedidosItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Criar Pedido":
                    ChamarFormPedidoCriar();
                    break;
                case "Alterar Pedido":
                    ChamarFormPedidoAlterar();
                    break;
            }
        }

        private void CriarMenuDeContextoPedido()
        {
            ContextMenuStrip menuPedidos = new ContextMenuStrip();
            menuPedidos.Items.Add("Criar Pedido");
            menuPedidos.Items.Add("Alterar Pedido");
            menuPedidos.ItemClicked += new ToolStripItemClickedEventHandler(MenuPedidosItemClicked);
            dataGridPedidos.ContextMenuStrip = menuPedidos;
        }

        private void TelaPedidos_Load(object sender, EventArgs e)
        {
            Carregar();
            CriarMenuDeContextoPedido();
        }

        private void dataGridPedidos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            ItemNoPedidoDAO itensDAO = new ItemNoPedidoDAO();
            dataGridPedidos.CurrentRow.Selected = true;
            int idPedido = Convert.ToInt32(dataGridPedidos.CurrentRow.Cells[0].Value);
            pedidoSelecionado = pedidoDAO.BuscarPorId(idPedido) as Pedido;
            dataGridItens.DataSource = itensDAO.ListarEmDataTableComFiltros("pedidos_idpedido = " + idPedido);
            pedidoSelecionado.GerarListaDeItens();
            pedidoDAO.CloseConnections();
            itensDAO.CloseConnections();
        }
    }
}
