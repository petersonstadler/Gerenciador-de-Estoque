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
            CategoriaDAO catDao = new CategoriaDAO();
            Categoria categoria = new Categoria();
            categoria.Id = 3;
            categoria.Nome = "CACHECOL";
            catDao.Alterar(categoria.Id, categoria);
            DtProdutos.DataSource = catDao.ListarEmDataTable();
        }
    }
}
