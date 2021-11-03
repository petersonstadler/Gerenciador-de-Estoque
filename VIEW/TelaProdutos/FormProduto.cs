using System;
using System.Drawing;
using System.Runtime.InteropServices;
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


        public FormProduto()
        {
            InitializeComponent();
            txtID.Text = "0";
            operacao = "CADASTRAR";
            txtIdCategoria.Text = "1";
            ckBoxAtivo.Checked = true;
            txtNomeCategoria.Text = PegarNomeDaCategoria(1);
            PreencherComboBoxes();
        }

        private void PreencherComboBoxes()
        {
            cbBoxTamanho.Items.Add("P");
            cbBoxTamanho.Items.Add("M");
            cbBoxTamanho.Items.Add("G");
            cbBoxTamanho.Items.Add("GG");
            cbBoxTamanho.Items.Add("XG");
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

        public FormProduto(ref Produto prod)
        {
            try
            {
                InitializeComponent();
                produto = prod;
                operacao = "ALTERAR";
                PreencherComboBoxes();
                PreencherTxtBoxes();
                txtNomeCategoria.Text = PegarNomeDaCategoria(Convert.ToInt32(txtIdCategoria.Text));
            }
            catch(Exception er)
            {
                MessageBox.Show("Falha ao tentar alterar produto! \n\n" + er, "Preencher Campos para alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public FormProduto(ref Produto prod, string duplicar)
        {
            try
            {
                InitializeComponent();
                produto = prod;
                operacao = "CADASTRAR";
                PreencherComboBoxes();
                PreencherTxtBoxes();
                txtID.Text = "0";
                txtNomeCategoria.Text = PegarNomeDaCategoria(Convert.ToInt32(txtIdCategoria.Text));
            }
            catch (Exception er)
            {
                MessageBox.Show("Falha ao tentar alterar produto! \n\n" + er, "Preencher Campos para alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void ValidarCampoTamanho(string txt)
        {
            if(txt.Length < 1)
            {
                lblTamanho.BackColor = Color.Red;
                tamanhoValidado = false;
            }
            else
            {
                tamanhoValidado = true;
                lblTamanho.BackColor = Color.Green;
            }
        }

        private void ValidarCampoCategoria(string txt)
        {
            int valor;
            if (int.TryParse(txt, out valor))
            {
                if (valor > 0)
                {
                    CategoriaDAO categoriaDAO = new CategoriaDAO();
                    if (categoriaDAO.VerificarCategoria(valor))
                    {
                        lblCategoria.BackColor = Color.Green;
                        idCategoriaValidado = true;
                    }
                    categoriaDAO.CloseConnections();
                }
                else
                {
                    lblCategoria.BackColor = Color.Red;
                    idCategoriaValidado = false;
                }
            }
            else
            {
                lblCategoria.BackColor = Color.Red;
                idCategoriaValidado = false;
            }
        }

        private string ValidarCampoValores(string txt, ref bool validador)
        {
            string mensagem = "";
            Validador validar = new Validador();
            if (validar.ValidarCampoPreco(txt))
            {
                mensagem = "";
                validador = true;
            }
            else
            {
                mensagem = "*O campo precisa conter um valor válido!";
                validador = false;
            }
            return mensagem;
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

        private void cbBoxTamanho_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoTamanho(cbBoxTamanho.Text);
        }

        private void txtIdCategoria_TextChanged(object sender, EventArgs e)
        {
            ValidarCampoCategoria(txtIdCategoria.Text);
        }

        private void txtCusto_TextChanged(object sender, EventArgs e)
        {
            lblMensagemCusto.Text = ValidarCampoValores(txtCusto.Text, ref custoValidado);
        }

        private void txtVenda_TextChanged(object sender, EventArgs e)
        {
            lblMensagemVenda.Text = ValidarCampoValores(txtVenda.Text, ref vendaValidado);
        }

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador validar = new Validador();
            if(validar.CampoFloat(txtCusto.Text, e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador validar = new Validador();
            if (validar.CampoFloat(txtVenda.Text, e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            SeletorDeCategoria selecionarCategoria = new SeletorDeCategoria(ref categoria);
            selecionarCategoria.Location = MousePosition;
            selecionarCategoria.ShowDialog();
            if(selecionarCategoria.DialogResult == DialogResult.OK)
            {
                txtIdCategoria.Text = Convert.ToString(categoria.Id);
                txtNomeCategoria.Text = categoria.Nome;
            }
            selecionarCategoria.Dispose();
        }
    }
}
