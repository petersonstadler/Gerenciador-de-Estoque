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
            CategoriaDAO produtoDao = new CategoriaDAO();
            MovimentoDAO movimentoDAO = new MovimentoDAO();
            Movimento movimento = new Movimento();
            /*movimento.Descricao = "Movimento teste 23";
            movimento.Quantidade = 1;
            movimento.Idproduto = 1;
            movimento.Operacao = "ENTRADA";
            movimento.Idpedido = 0;
            movimentoDAO.Inserir(movimento);*/
            movimento = movimentoDAO.BuscarPorId(3) as Movimento;
            MessageBox.Show($"{movimento.Descricao}");
            DtProdutos.DataSource = produtoDao.ListarEmDataTable();
            DtMovimentos.DataSource = movimentoDAO.ListarEmDataTable();
        }
    }
}
