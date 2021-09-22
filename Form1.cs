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

namespace Gerenciador_de_Estoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDAO prodDAO = new ProdutoDAO();
                Produto produto = new Produto();
                produto.Nome = "teste";
                produto.Descricao = "descricao teste 2";
                produto.Ativo = true;
                produto.Custo = (decimal)1.20;
                produto.Preco = (decimal)5.50;
                produto.Quantidade = 0;
                produto.Tamanho = "GG";
                produto.Idcategoria = 1;
                prodDAO.InserirProduto(produto);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao inserir produto! \n\n" + ex.Message, "Inserir produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
