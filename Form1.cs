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
                Produto prod = new Produto();
                ProdutoDAO prodDAO = new ProdutoDAO();
                prod.Ativo = true;
                prod.Nome = "teste2";
                prod.Descricao = "desc";
                prod.Id = 2;
                prod.Idcategoria = 2;
                prod.Tamanho = "G";
                prod.Custo = 1;
                prod.Preco = 2;

                prodDAO.AlterarProduto(prod);
              
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao clicar em botão teste! \n\n" + ex.Message, "Inserir produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
