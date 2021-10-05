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

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Carregar()
        {
            ProdutoDAO produtoDao = new ProdutoDAO();
            DtProdutos.DataSource = produtoDao.ListarEmDataTable();
            produtoDao.CloseConnections();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void CriarFormProdutoAdicionar()
        {
            FormProduto formProduto = new FormProduto();
            formProduto.ShowDialog();
            if(formProduto.DialogResult == DialogResult.OK)
            {
                DtProdutos.DataSource = new ProdutoDAO().ListarEmDataTable();
            }
            formProduto.Dispose();
        }

        private void CriarFormProdutoAlterar()
        {
            FormProduto formProduto = new FormProduto(ref produtoSelecionado);
            formProduto.ShowDialog();
            if(formProduto.DialogResult == DialogResult.OK)
            {
                DtProdutos.DataSource = new ProdutoDAO().ListarEmDataTable(); 
            }
            formProduto.Dispose();
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
            }
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            menuProdutos.Items.Add("Adicionar");
            menuProdutos.Items.Add("Alterar");
            DtProdutos.ContextMenuStrip = menuProdutos;
            menuProdutos.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
        }

        private void DtProdutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idProduto;
            string valorIdString;
            DtProdutos.CurrentRow.Selected = true;
            valorIdString = Convert.ToString(DtProdutos.Rows[e.RowIndex].Cells[0].Value);
            if(int.TryParse(valorIdString, out idProduto))
            {
                ProdutoDAO produtoDAO = new ProdutoDAO();
                produtoSelecionado = produtoDAO.BuscarPorId(idProduto) as Produto;
                MovimentoDAO movimentoDAO = new MovimentoDAO();
                movimentoDAO.NomeColunasSelect = new string[] { "idmovimento", "descmovimento", "qtdmovimento", "operacaomovimento", "pedidos_idpedido" };
                movimentoDAO.ApelidoColunasSelect = new string[] { "Id", "Descrição", "Quantidade", "Operação", "IdPedido" };
                DtMovimentos.DataSource = movimentoDAO.ListarPorFiltroIdProduto(idProduto);
                movimentoDAO.CloseConnections();
                produtoDAO.CloseConnections();
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            DtProdutos.DataSource = new ProdutoDAO().BuscarPorNome(txtBusca.Text);
        }
    }
}
