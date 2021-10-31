using System;
using System.Windows.Forms;
using Gerenciador_de_Estoque.DAO;
using Gerenciador_de_Estoque.MODEL;
using Gerenciador_de_Estoque.VIEW.TelaPedidos;

namespace Gerenciador_de_Estoque.VIEW
{
    public partial class TelaPedidos1 : Form
    {
        private Pedido pedidoSelecionado;

        public TelaPedidos1()
        {
            InitializeComponent();
        }

        private void TelaPedidos_Load(object sender, EventArgs e)
        {
            AtualizarDataGridPedidos();
            CriarMenuDeContextoPedido();
        }

        private void AtualizarDataGridPedidos()
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            dataGridPedidos.DataSource = pedidoDAO.ListarEmDataTable();
            pedidoDAO.CloseConnections();
        }

        private void CriarMenuDeContextoPedido()
        {
            ContextMenuStrip menuPedidos = new ContextMenuStrip();
            menuPedidos.Items.Add("Criar Pedido");
            menuPedidos.Items.Add("Alterar Pedido");
            menuPedidos.ItemClicked += new ToolStripItemClickedEventHandler(MenuPedidosItemClicked);
            dataGridPedidos.ContextMenuStrip = menuPedidos;
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

        private void ChamarFormPedidoCriar()
        {
            FormPedido formPedido = new FormPedido();
            formPedido.ShowDialog();
            if (formPedido.DialogResult == DialogResult.OK)
            {
                AtualizarDataGridPedidos();
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
                    AtualizarDataGridPedidos();
                }
                formPedido.Dispose();
            }
        }

        private void dataGridPedidos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch(Exception er)
            {
                MessageBox.Show("Falha ao selecionar pedido! \n\n" + er, "Selecionar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
