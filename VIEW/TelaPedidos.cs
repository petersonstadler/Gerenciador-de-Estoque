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

namespace Gerenciador_de_Estoque.VIEW
{
    public partial class TelaPedidos : Form
    {
        private void Carregar()
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            dataGridPedidos.DataSource = pedidoDAO.ListarEmDataTable();
        }

        public TelaPedidos()
        {
            InitializeComponent();
            Carregar();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
