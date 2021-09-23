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
            /*CategoriaDAO catDao = new CategoriaDAO();
            DtProdutos.DataSource = catDao.ListarEmDataTable();*/
            ProdutoDAO prodDao = new ProdutoDAO();
            DtProdutos.DataSource = prodDao.ListarProdutosEmDataTable();
        }
    }
}
