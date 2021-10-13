using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciador_de_Estoque.DAO;
using Gerenciador_de_Estoque.MODEL;

namespace Gerenciador_de_Estoque.VIEW
{
    public partial class TelaCategorias : Form
    {
        Categoria categoriaSelecionada = null;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public TelaCategorias()
        {
            InitializeComponent();
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ExcluirCategoriaSelecionada()
        {
            if(categoriaSelecionada != null)
            {
                CategoriaDAO categoriaDAO = new CategoriaDAO();
                ProdutoDAO produtoDAO = new ProdutoDAO();
                List<object> listaProdutos = produtoDAO.ListarComFiltro("categorias_idcategoria = " + categoriaSelecionada.Id);
                if(listaProdutos.Count > 0)
                {
                    MessageBox.Show("Você não pode excluir uma categoria em uso!", "Excluir Categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    categoriaDAO.Deletar(categoriaSelecionada.Id);
                    MessageBox.Show("Categoria excluida com sucesso!", "Excluir Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                produtoDAO.CloseConnections();
                categoriaDAO.CloseConnections();
            }
        }

        private void menuDataGridCategorias_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Excluir":
                    ExcluirCategoriaSelecionada();
                    break;
            }
        }

        private void TelaCategorias_Load(object sender, EventArgs e)
        {
            CategoriaDAO categoriaDAO = new CategoriaDAO();
            dataGridCategorias.DataSource = categoriaDAO.ListarEmDataTable();
            ContextMenuStrip menuDataGridCategorias = new ContextMenuStrip();
            menuDataGridCategorias.Items.Add("Excluir");
            menuDataGridCategorias.ItemClicked += new ToolStripItemClickedEventHandler(menuDataGridCategorias_ItemClicked);
            dataGridCategorias.ContextMenuStrip = menuDataGridCategorias;
            categoriaDAO.CloseConnections();
        }
    }
}
