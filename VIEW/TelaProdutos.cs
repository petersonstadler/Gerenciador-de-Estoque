using System;
using System.Windows.Forms;
using Gerenciador_de_Estoque.DAO;
using Gerenciador_de_Estoque.MODEL;
using Gerenciador_de_Estoque.VIEW.FormProdutos;

namespace Gerenciador_de_Estoque.VIEW
{
    public partial class TelaProdutos : Form
    {
        ContextMenuStrip menuProdutos = new ContextMenuStrip();
        Produto produtoSelecionado;

        public TelaProdutos()
        {
            InitializeComponent();
            this.Carregar();
        }

        private void Carregar()
        {
            AtualizarDtProdutos();
        }

        private void CriarFormProdutoAdicionar()
        {
            FormProduto formProduto = new FormProduto();
            formProduto.ShowDialog();
            if(formProduto.DialogResult == DialogResult.OK)
            {
                AtualizarDtProdutos();
            }
            formProduto.Dispose();
        }

        private void CriarFormProdutoAlterar()
        {
            if (produtoSelecionado != null)
            {
                FormProduto formProduto = new FormProduto(ref produtoSelecionado);
                formProduto.ShowDialog();
                if (formProduto.DialogResult == DialogResult.OK)
                {
                    AtualizarDtProdutos();
                }
                formProduto.Dispose();
            }
        }

        private void CriarFormProdutoDuplicar()
        {
            if(produtoSelecionado != null)
            {
                FormProduto formProduto = new FormProduto(ref produtoSelecionado, "DUPLICAR");
                formProduto.ShowDialog();
                if(formProduto.DialogResult == DialogResult.OK)
                {
                    AtualizarDtProdutos();
                }
                formProduto.Dispose();
            }
        }

        private void AtualizarDtProdutos()
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            DtProdutos.DataSource = produtoDAO.ListarEmDataTable();
            produtoDAO.CloseConnections();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            menuProdutos.Items.Add("Adicionar");
            menuProdutos.Items.Add("Alterar");
            menuProdutos.Items.Add("Duplicar");
            DtProdutos.ContextMenuStrip = menuProdutos;
            menuProdutos.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Adicionar":
                    CriarFormProdutoAdicionar();
                    break;
                case "Alterar":
                    CriarFormProdutoAlterar();
                    break;
                case "Duplicar":
                    CriarFormProdutoDuplicar();
                    break;
            }
        }

        private void DtProdutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idProduto;
                string valorIdString;
                DtProdutos.CurrentRow.Selected = true;
                valorIdString = Convert.ToString(DtProdutos.Rows[e.RowIndex].Cells[0].Value);
                if (int.TryParse(valorIdString, out idProduto))
                {
                    ProdutoDAO produtoDAO = new ProdutoDAO();
                    produtoSelecionado = produtoDAO.BuscarPorId(idProduto) as Produto;
                    MovimentoDAO movimentoDAO = new MovimentoDAO();
                    movimentoDAO.NomeColunasSelect = new string[] { "idmovimento", "descmovimento", "qtdmovimento", "operacaomovimento", "pedidos_idpedido" };
                    movimentoDAO.ApelidoColunasSelect = new string[] { "Id", "Descrição", "Quantidade", "Operação", "IdPedido" };
                    //DtMovimentos.DataSource = movimentoDAO.ListarPorFiltroIdProduto(idProduto);
                    DtMovimentos.DataSource = movimentoDAO.ListarEmDataTableComFiltros("produtos_idproduto = " + idProduto + " AND " + "qtdmovimento != 0");
                    movimentoDAO.CloseConnections();
                    produtoDAO.CloseConnections();
                }
            }
            catch(Exception er)
            {
                MessageBox.Show("Falha ao selecionar Produto! \n\n" + er, "Selecionar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            DtProdutos.DataSource = produtoDAO.BuscarPorNome(txtBusca.Text);
            produtoDAO.CloseConnections();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
