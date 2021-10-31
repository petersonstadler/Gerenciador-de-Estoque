using System;
using System.Windows.Forms;
using Gerenciador_de_Estoque.MODEL;
using Gerenciador_de_Estoque.DAO;

namespace Gerenciador_de_Estoque.VIEW.FormProdutos
{
    public partial class SeletorDeCategoria : Form
    {
        Categoria categoria;

        public SeletorDeCategoria(ref Categoria categoriaExterna)
        {
            InitializeComponent();
            categoria = categoriaExterna;
            dataGridCategorias.DataSource = new CategoriaDAO().ListarEmDataTable();
        }

        private void dataGridCategorias_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridCategorias.CurrentRow.Selected = true;
            categoria.Id = Convert.ToInt32(dataGridCategorias.Rows[e.RowIndex].Cells[0].Value);
            categoria.Nome = Convert.ToString(dataGridCategorias.Rows[e.RowIndex].Cells[1].Value);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridCategorias.DataSource = new CategoriaDAO().BuscarPorNome(textBox1.Text);
        }
    }
}
