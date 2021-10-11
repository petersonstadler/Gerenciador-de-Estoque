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

namespace Gerenciador_de_Estoque.VIEW.TelaPedidos
{
    public partial class SeletorDeProduto : Form
    {
        private int idProdutoSelecionado = 0;
        private ItemNoPedido item = new ItemNoPedido();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private ProdutoDAO MontarProdutoDAO()
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            produtoDAO.NomeColunasSelect = new string [] { "idproduto", "nomeproduto", "precoproduto" };
            produtoDAO.ApelidoColunasSelect = new string[] { "ID", "Nome", "Preço" };
            return produtoDAO;
        }

        public SeletorDeProduto(ref ItemNoPedido itemRecebido)
        {
            InitializeComponent();
            item = itemRecebido;
            ProdutoDAO produtoDAO = MontarProdutoDAO();
            dataGridProduto.DataSource = produtoDAO.ListarEmDataTable();
            txtAcrescimo.Text = "0";
            txtDesconto.Text = "0";
            txtQuantidade.Text = "1";
            txtPreco.Text = "0";
            produtoDAO.CloseConnections();
        }

        private void lblAddItem_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dataGridProduto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridProduto.CurrentRow.Cells[0] != null)
            {
                dataGridProduto.CurrentRow.Selected = true;
                idProdutoSelecionado = Convert.ToInt32(dataGridProduto.CurrentRow.Cells[0].Value);
                txtPreco.Text = Convert.ToString(dataGridProduto.CurrentRow.Cells[2].Value);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ProdutoDAO produtoDAO = MontarProdutoDAO();
            dataGridProduto.DataSource = produtoDAO.BuscarPorNome(txtBusca.Text);
            produtoDAO.CloseConnections();
        }

        private bool ValidarCampos()
        {
            Validador validar = new Validador();
            bool campoQuantidade, campoPreco, campoAcrescimo, campoDesconto;
            campoQuantidade = validar.ValidarCampoPreco(txtQuantidade.Text);
            campoPreco = validar.ValidarCampoPreco(txtPreco.Text);
            campoAcrescimo = validar.ValidarCampoPreco(txtAcrescimo.Text);
            campoDesconto = validar.ValidarCampoPreco(txtDesconto.Text);
            lblMsgAcrescimo.Text = "*";
            lblMsgDesconto.Text = "*";
            lblMsgPreco.Text = "*";
            lblMsgQuantidade.Text = "*";
            if (campoQuantidade)
                lblMsgQuantidade.Text = "";
            if (campoPreco)
                lblMsgPreco.Text = "";
            if (campoAcrescimo)
                lblMsgAcrescimo.Text = "";
            if (campoDesconto)
                lblMsgDesconto.Text = "";
            if (campoQuantidade && campoPreco && campoAcrescimo && campoDesconto)
                return true;
            return false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                item.Idproduto = idProdutoSelecionado;
                item.Preco = Convert.ToDecimal(txtPreco.Text);
                item.Acrescimo = Convert.ToDecimal(txtAcrescimo.Text);
                item.Desconto = Convert.ToDecimal(txtDesconto.Text);
                item.Quantidade = (float)Convert.ToDecimal(txtQuantidade.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Os campos precisam conter valores válidos!", "Validar Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
