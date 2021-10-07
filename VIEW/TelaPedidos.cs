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
using Gerenciador_de_Estoque.VIEW.TelaPedidos;

namespace Gerenciador_de_Estoque.VIEW
{
    public partial class TelaPedidos1 : Form
    {
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

        private void ChamarFormPedido()
        {
            FormPedido formPedido = new FormPedido();
            formPedido.ShowDialog();
        }

        private void MenuPedidosItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Criar Pedido":
                    ChamarFormPedido();
                    break;
                case "Alterar Pedido":
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
    }
}
