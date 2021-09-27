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

namespace Gerenciador_de_Estoque.VIEW
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void teste_Click(object sender, EventArgs e)
        {
            ProdutoDAO produtoDao = new ProdutoDAO();
            MovimentoDAO movimentoDAO = new MovimentoDAO();

            produtoDao.Deletar(69);

            DtProdutos.DataSource = produtoDao.ListarEmDataTable();
            DtMovimentos.DataSource = movimentoDAO.ListarEmDataTable();
            produtoDao.CloseConnections();
            movimentoDAO.CloseConnections();
        }
    }
}
