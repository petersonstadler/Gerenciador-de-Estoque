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
    public partial class FormPedido : Form
    {

        private String operacao = "";
        private Pedido pedido = new Pedido();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private DataTable MostrarItensPedido()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Produto", typeof(string));
            dt.Columns.Add("Preço", typeof(decimal));
            dt.Columns.Add("Quantidade", typeof(int));
            dt.Columns.Add("Desconto", typeof(decimal));
            dt.Columns.Add("Acréscimo", typeof(decimal));
            foreach (ItemNoPedido item in pedido.ListaItens)
            {
                ProdutoDAO produtoDAO = new ProdutoDAO();
                Produto produto = produtoDAO.BuscarPorId(item.Idproduto) as Produto;
                dt.Rows.Add(produto.Nome, item.Preco, item.Quantidade, item.Desconto, item.Acrescimo);
                produtoDAO.CloseConnections();
            }
            return dt;
        }

        public FormPedido()
        {
            InitializeComponent();
            PedidoDAO pedidoDAO = new PedidoDAO();
            operacao = "CRIAR";
            pedido.Id = pedidoDAO.PegarIdDoUltimoPedidoCriado();
            txtID.Text = Convert.ToString(pedido.Id);
            pedidoDAO.CloseConnections();
            dataGridItensPedido.DataSource = MostrarItensPedido();
        }

        public FormPedido(Pedido pedido)
        {
            InitializeComponent();
            operacao = "ALTERAR";
            this.pedido = pedido;
            txtID.Text = Convert.ToString(pedido.Id);
            txtPessoa.Text = pedido.Pessoa;
            txtFrete.Text = Convert.ToString(pedido.Frete);
            dateTimePickerPedido.Value = pedido.Data;
            comboBoxFinanceiro.Text = pedido.Financeiro;
            comboBoxOperacao.Text = pedido.Operacao;
            comboBoxStatus.Text = pedido.Status;
            dataGridItensPedido.DataSource = MostrarItensPedido();
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


        private void GerarCbBoxFinanceiro()
        {
            comboBoxFinanceiro.Items.Add("Pago");
            comboBoxFinanceiro.Items.Add("Fiado");
            comboBoxFinanceiro.Text = "Pago";
        }

        private void GerarCbBoxOperacao()
        {
            comboBoxOperacao.Items.Add("ENTRADA");
            comboBoxOperacao.Items.Add("SAIDA");
            comboBoxOperacao.Text = "SAIDA";
        }

        private void GerarCbBoxStatus()
        {
            comboBoxStatus.Items.Add("Aberto");
            comboBoxStatus.Items.Add("Fechado");
            comboBoxStatus.Items.Add("Cancelado");
            comboBoxStatus.Text = "Aberto";
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            GerarCbBoxStatus();
            GerarCbBoxOperacao();
            GerarCbBoxFinanceiro();
        }

        private bool CompararItensPedido(ItemNoPedido itemA, ItemNoPedido itemB)
        {
            if (itemA.Idpedido == itemB.Idpedido && itemA.Idproduto == itemB.Idproduto && itemA.Preco == itemB.Preco && itemA.Quantidade == itemB.Quantidade && itemA.Desconto == itemB.Desconto && itemA.Acrescimo == itemB.Acrescimo)
                return true;
            else
                return false;
        }

        private bool CompararListasDeItensPedido(List<ItemNoPedido> listaA, List<ItemNoPedido> listaB)
        {
            foreach(ItemNoPedido itemListaA in listaA)
            {
                foreach(ItemNoPedido itemListaB in listaB)
                {
                    if(!CompararItensPedido(itemListaA, itemListaB))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void CriarListaDeItens(Pedido pedido)
        {
            try
            {
                foreach (ItemNoPedido item in pedido.ListaItens)
                {
                    ItemNoPedidoDAO itensDAO = new ItemNoPedidoDAO();
                    itensDAO.Inserir(item);
                    itensDAO.CloseConnections();
                }
            }catch(Exception e)
            {
                MessageBox.Show("Falha ao tentar criar Lista de Itens! " + e, "Criar lista de Itens", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CriarNovoPedido()
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            pedidoDAO.Inserir(pedido);
            CriarListaDeItens(pedido);
            pedidoDAO.CloseConnections();
        }

        private void AlterarPedido()
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            pedidoDAO.Alterar(pedido.Id, pedido);
            Pedido pedidoAntigo = pedidoDAO.BuscarPorId(pedido.Id) as Pedido;
            if(!CompararListasDeItensPedido(pedido.ListaItens, pedidoAntigo.ListaItens))
            {
                ItemNoPedidoDAO itensDAO = new ItemNoPedidoDAO();
                itensDAO.Deletar(pedido.Id);
                CriarListaDeItens(pedido);
                itensDAO.CloseConnections();
            }
            pedidoDAO.CloseConnections();
        }

        private bool ValidarFrete()
        {
            decimal valor;
            if (decimal.TryParse(txtFrete.Text, out valor))
            {
                lblMsgFrete.Text = "";
                return true;
            }
            lblMsgFrete.Text = "*";
            return false;
        }

        private bool ValidarOperacao()
        {
            if (comboBoxOperacao.Text == "ENTRADA" || comboBoxOperacao.Text == "SAIDA")
            {
                lblMsgOperacao.Text = "";
                return true;
            }
            lblMsgOperacao.Text = "*";
            return false;
        }

        private bool ValidarStatus()
        {
            if (comboBoxStatus.Text == "Aberto" || comboBoxStatus.Text == "Fechado" || comboBoxStatus.Text == "Cancelado")
            {
                lblMsgStatus.Text = "";
                return true;
            }
            lblMsgStatus.Text = "*";
            return false;
        }

        private bool ValidarFinanceiro()
        {
            if (comboBoxFinanceiro.Text == "Pago" || comboBoxFinanceiro.Text == "Fiado")
            {
                lblMsgFinanceiro.Text = "";
                return true;
            }
            lblMsgFinanceiro.Text = "*";
            return false;
        }

        private bool ValidarListaItens()
        {
            if(pedido.ListaItens.Count > 0)
            {
                lblMsgListaItens.Text = "";
                return true;
            }
            lblMsgListaItens.Text = "*O pedido precisa conter pelo menos um item!";
            return false;
        }

        private bool ValidarPedido()
        {
            bool operacao, frete, status, financeiro, listaItens;
            operacao = ValidarOperacao();
            frete = ValidarFrete();
            status = ValidarStatus();
            financeiro = ValidarFinanceiro();
            listaItens = ValidarListaItens();
            if (operacao && frete && status && financeiro && listaItens)
                return true;
            MessageBox.Show("Os valor de algum campo não é válido! Verifique!", "Campos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void PreencherPedido()
        {
            pedido.Operacao = comboBoxOperacao.Text;
            pedido.Data = dateTimePickerPedido.Value;
            pedido.Pessoa = txtPessoa.Text;
            pedido.Financeiro = comboBoxFinanceiro.Text;
            pedido.Status = comboBoxStatus.Text;
            pedido.Frete = Convert.ToDecimal(txtFrete.Text);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarPedido())
            {
                if(operacao == "CRIAR")
                {
                    PreencherPedido();
                    CriarNovoPedido();
                }
                if(operacao == "ALTERAR")
                {
                    PreencherPedido();
                    AlterarPedido();
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void comboBoxOperacao_TextChanged(object sender, EventArgs e)
        {
            ValidarOperacao();
        }

        private void txtFrete_TextChanged(object sender, EventArgs e)
        {
            ValidarFrete();
        }

        private void comboBoxStatus_TextChanged(object sender, EventArgs e)
        {
            ValidarStatus();
        }

        private void comboBoxFinanceiro_TextChanged(object sender, EventArgs e)
        {
            ValidarFinanceiro();
        }
    }
}
