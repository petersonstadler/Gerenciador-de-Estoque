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
using Gerenciador_de_Estoque.MODEL;
using Gerenciador_de_Estoque.DAO;

namespace Gerenciador_de_Estoque.VIEW.FormProdutos
{
    public partial class FormProduto : Form
    {
        private Produto produto;
        private string operacao = "";
        private bool nomeValidado = false;
        private bool tamanhoValidado = false;
        private bool idCategoriaValidado = false;
        private bool custoValidado = false;
        private bool vendaValidado = false;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void PreencherComboBoxes()
        {
            cbBoxTamanho.Items.Add("P");
            cbBoxTamanho.Items.Add("M");
            cbBoxTamanho.Items.Add("G");
            cbBoxTamanho.Items.Add("GG");
            cbBoxTamanho.Items.Add("XG");
        }

        private void PreencherTxtBoxes()
        {
            txtID.Text = Convert.ToString(produto.Id);
            txtNome.Text = produto.Nome;
            txtDescricao.Text = produto.Descricao;
            cbBoxTamanho.Text = produto.Tamanho;
            txtCusto.Text = Convert.ToString(produto.Custo);
            txtVenda.Text = Convert.ToString(produto.Preco);
            txtIdCategoria.Text = Convert.ToString(produto.Idcategoria);
            ckBoxAtivo.Checked = produto.Ativo;
        }

        private string PegarNomeDaCategoria(int id)
        {
            string nome = "";
            CategoriaDAO categoriaDAO = new CategoriaDAO();
            Categoria categoria = new Categoria();
            categoria = categoriaDAO.BuscarPorId(id) as Categoria;
            nome = categoria.Nome;
            return nome;
        }

        public FormProduto()
        {
            InitializeComponent();
            txtID.Text = "0";
            operacao = "CADASTRAR";
            txtIdCategoria.Text = "1";
            txtNomeCategoria.Text = PegarNomeDaCategoria(1);
            PreencherComboBoxes();
        }

        public FormProduto(ref Produto prod)
        {
            InitializeComponent();
            produto = prod;
            operacao = "ALTERAR";
            PreencherComboBoxes();
            PreencherTxtBoxes();
            txtNomeCategoria.Text = PegarNomeDaCategoria(Convert.ToInt32(txtIdCategoria.Text));
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private string ValidarCampoNome(string txtValue)
        {
            Validador validar = new Validador();
            if (!validar.ValidarCampoNome(txtValue))
            {
                nomeValidado = false;
                return "*Campo nome precisa conter um valor válido!";
            }
            else
            {
                nomeValidado = true;
                return "";
            }
        }

        private bool validacaoDeCampos()
        {
            if (nomeValidado && tamanhoValidado && idCategoriaValidado && custoValidado && vendaValidado)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Existem campos que ainda não foram validados!", "Validação de campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private Produto PreencherProduto()
        {
            Produto prod = new Produto();
            prod.Id = Convert.ToInt32(txtID.Text);
            prod.Nome = txtNome.Text;
            prod.Descricao = txtDescricao.Text;
            prod.Tamanho = cbBoxTamanho.Text;
            prod.Custo = Convert.ToDecimal(txtCusto.Text);
            prod.Preco = Convert.ToDecimal(txtVenda.Text);
            prod.Idcategoria = Convert.ToInt32(txtIdCategoria.Text);
            prod.Quantidade = 0;
            prod.Ativo = ckBoxAtivo.Checked;
            return prod;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validacaoDeCampos())
            {
                ProdutoDAO produtoDAO = new ProdutoDAO();
                produto = PreencherProduto();
                if(operacao == "ALTERAR")
                {
                    produtoDAO.Alterar(produto.Id, produto);
                    MessageBox.Show("Produto alterado com sucesso!", "Alterar Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    produtoDAO.Inserir(produto);
                    MessageBox.Show("Produto inserido com sucesso!", "Inserir Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                produtoDAO.CloseConnections();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblMensagemNome.Text = ValidarCampoNome(txtNome.Text);
        }
    }
}
