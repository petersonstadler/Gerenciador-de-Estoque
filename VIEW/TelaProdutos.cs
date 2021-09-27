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
using Gerenciador_de_Estoque.VIEW.FormProdutos;

namespace Gerenciador_de_Estoque.VIEW
{
    public partial class TelaProdutos : Form
    {
        ContextMenuStrip menuProdutos = new ContextMenuStrip();

        public TelaProdutos()
        {
            InitializeComponent();
            this.Carregar();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Carregar()
        {
            ProdutoDAO produtoDao = new ProdutoDAO();
            MovimentoDAO movimentoDAO = new MovimentoDAO();
            DtMovimentos.DataSource = movimentoDAO.ListarEmDataTable();
            DtProdutos.DataSource = produtoDao.ListarEmDataTable();
            produtoDao.CloseConnections();
            movimentoDAO.CloseConnections();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void teste()
        {
            MessageBox.Show("teste");
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string comando = string.Empty;
            switch (e.ClickedItem.Text)
            {
                case "Adicionar":
                    FormProduto formProduto = new FormProduto();
                    formProduto.Show();
                    break;
                case "Alterar":
                    break;
                case "Inativar":
                    break;
            }
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            menuProdutos.Items.Add("Adicionar");
            menuProdutos.Items.Add("Alterar");
            menuProdutos.Items.Add("Inativar");
            DtProdutos.ContextMenuStrip = menuProdutos;

            menuProdutos.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
        }
    }
}
