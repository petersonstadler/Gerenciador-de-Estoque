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
        private int indiceItemSelecionado = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private DataTable MostrarItensPedido()
        {
            int cont = 1;
            decimal total = 0;
            decimal totalDesconto = 0;
            decimal totalAcrescimo = 0;
            DataTable dt = new DataTable();
            dt.Columns.Add("Ordem", typeof(int));
            dt.Columns.Add("Produto", typeof(string));
            dt.Columns.Add("Preço", typeof(decimal));
            dt.Columns.Add("Quantidade", typeof(float));
            dt.Columns.Add("Desconto", typeof(decimal));
            dt.Columns.Add("Acréscimo", typeof(decimal));
            dt.Columns.Add("Total", typeof(decimal));
            foreach (ItemNoPedido item in pedido.ListaItens)
            {
                ProdutoDAO produtoDAO = new ProdutoDAO();
                Produto produto = produtoDAO.BuscarPorId(item.Idproduto) as Produto;
                dt.Rows.Add(cont, produto.Nome, item.Preco, item.Quantidade, item.Desconto, item.Acrescimo, ((decimal)item.Quantidade * item.Preco) + item.Acrescimo - item.Desconto);
                produtoDAO.CloseConnections();
                total += ((decimal)item.Quantidade * item.Preco) + item.Acrescimo - item.Desconto;
                totalDesconto += item.Desconto;
                totalAcrescimo += item.Acrescimo;
                cont++;
            }
            lblValorAcrescimoTotal.Text = Convert.ToString(totalAcrescimo);
            lblValorDescontoTotal.Text = Convert.ToString(totalDesconto);
            lblValorTotal.Text = Convert.ToString(total);
            return dt;
        }

        public FormPedido()
        {
            InitializeComponent();
            PedidoDAO pedidoDAO = new PedidoDAO();
            operacao = "CRIAR";
            pedido.Id = pedidoDAO.PegarIdDoUltimoPedidoCriado();
            txtID.Text = Convert.ToString(pedido.Id);
            txtFrete.Text = "0";
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
        }

        private void GerarCbBoxOperacao()
        {
            comboBoxOperacao.Items.Add("ENTRADA");
            comboBoxOperacao.Items.Add("SAIDA");
        }

        private void GerarCbBoxStatus()
        {
            comboBoxStatus.Items.Add("Aberto");
            comboBoxStatus.Items.Add("Fechado");
            comboBoxStatus.Items.Add("Cancelado");
        }

        private void RemoverItemSelecionadoDaLista()
        {
            try
            {
                pedido.ListaItens.RemoveAt(indiceItemSelecionado);
                dataGridItensPedido.DataSource = MostrarItensPedido();
            }
            catch
            {
                MessageBox.Show("Precisa selecionar um item válido para remover!", "Remover Itens", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AdicionarItem()
        {
            bool itemAdicionado = false;
            ItemNoPedido item = new ItemNoPedido();
            SeletorDeProduto selecionarProduto = new SeletorDeProduto(ref item);
            item.Idpedido = pedido.Id;
            selecionarProduto.ShowDialog();
            if(selecionarProduto.DialogResult == DialogResult.OK)
            {
                foreach(ItemNoPedido itemNoPedido in pedido.ListaItens)
                {
                    if(itemNoPedido.Idproduto == item.Idproduto)
                    {
                        itemNoPedido.Quantidade += item.Quantidade;
                        itemNoPedido.Preco = item.Preco;
                        itemNoPedido.Desconto += item.Desconto;
                        itemNoPedido.Acrescimo += item.Acrescimo;
                        itemAdicionado = true;
                        break;
                    }
                }
                if (!itemAdicionado)
                {
                    pedido.ListaItens.Add(item);
                }
                dataGridItensPedido.DataSource = MostrarItensPedido();
            }
            selecionarProduto.Dispose();
        }

        private void menuItens_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Adicionar":
                    AdicionarItem();
                    break;
                case "Remover":
                    RemoverItemSelecionadoDaLista();
                    break;
            }
        }

        private ContextMenuStrip CriarMenuStripItens()
        {
            ContextMenuStrip menuItens = new ContextMenuStrip();
            menuItens.Items.Add("Adicionar");
            menuItens.Items.Add("Remover");
            menuItens.ItemClicked += new ToolStripItemClickedEventHandler(menuItens_ItemClicked);
            return menuItens;
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            GerarCbBoxStatus();
            GerarCbBoxOperacao();
            GerarCbBoxFinanceiro();
            dataGridItensPedido.ContextMenuStrip = CriarMenuStripItens();
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
            if (listaA.Count != listaB.Count)
                return false;
            for(int i = 0; i < listaA.Count; i++)
            {
                if(!CompararItensPedido(listaA[i], listaB[i]))
                {
                    return false;
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

        private void GerarMovimento()
        {
            MovimentoDAO movimentoDAO = new MovimentoDAO();
            if (comboBoxStatus.Text == "Fechado")
            {
                movimentoDAO.CriarMovimentoDePedido(pedido);
            }
            else
            {
                movimentoDAO.ExcluirMovimentoDePedido(pedido);
            }
            movimentoDAO.CloseConnections();
        }

        private void CriarNovoPedido()
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            pedidoDAO.Inserir(pedido);
            CriarListaDeItens(pedido);
            pedidoDAO.CloseConnections();
            GerarMovimento();
        }

        private void AlterarPedido()
        {
            PedidoDAO pedidoDAO = new PedidoDAO();
            pedidoDAO.Alterar(pedido.Id, pedido);
            Pedido pedidoAntigo = pedidoDAO.BuscarPorId(pedido.Id) as Pedido;
            pedidoAntigo.GerarListaDeItens();
            if (!CompararListasDeItensPedido(pedido.ListaItens, pedidoAntigo.ListaItens))
            {
                ItemNoPedidoDAO itensDAO2 = new ItemNoPedidoDAO();
                itensDAO2.Deletar(pedido.Id);
                itensDAO2.CloseConnections();
                CriarListaDeItens(pedido);
            }
            pedidoDAO.CloseConnections();
            GerarMovimento();
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

        private void dataGridItensPedido_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridItensPedido.CurrentRow.Selected = true;
                indiceItemSelecionado = Convert.ToInt32(dataGridItensPedido.CurrentRow.Cells[0].Value) - 1;
            }
            catch(Exception er)
            {
                MessageBox.Show("Falha ao selecionar Item! \n\n" + er, "Selecionar Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
