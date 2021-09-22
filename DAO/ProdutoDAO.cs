using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Gerenciador_de_Estoque.MODEL;
using System.Data;

namespace Gerenciador_de_Estoque.DAO
{
    public class ProdutoDAO
    {
        private readonly MySqlConnection mySqlConn;
        private readonly MySqlCommand mySqlCmd;

        public ProdutoDAO()
        {
            mySqlConn = new Conexao().GetConnection();
            mySqlCmd = mySqlConn.CreateCommand();
        }

        public void CloseConnection()
        {
            try
            {
                mySqlConn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao fechar conexão! \n\n" + e.Message, "Fechar Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InserirProduto(Produto produto)
        {
            mySqlCmd.CommandText = "INSERT INTO produtos (nomeproduto, descproduto, tamanhoproduto, custoproduto, precoproduto, categorias_idcategoria, qtdproduto, ativoproduto) VALUES (?nome, ?descricao, ?tamanho, ?custo, ?preco, ?idcategoria, ?quantidade, ?ativo);";
            mySqlCmd.Parameters.AddWithValue("?nome", produto.Nome);
            mySqlCmd.Parameters.AddWithValue("?descricao", produto.Descricao);
            mySqlCmd.Parameters.AddWithValue("?tamanho", produto.Tamanho);
            mySqlCmd.Parameters.AddWithValue("?custo", produto.Custo);
            mySqlCmd.Parameters.AddWithValue("?preco", produto.Preco);
            mySqlCmd.Parameters.AddWithValue("?idcategoria", produto.Idcategoria);
            mySqlCmd.Parameters.AddWithValue("?quantidade", produto.Quantidade);
            mySqlCmd.Parameters.AddWithValue("?ativo", produto.Ativo);
            try
            {
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Produto inserido com sucesso!", "Inserir Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar comando Inserir Produto!" + e.Message, "Inserir Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ListarProdutosEmDataTable()
        {
            DataTable dt = new DataTable();
            mySqlCmd.CommandText = "SELECT nomeproduto as Nome, tamanhoproduto as Tamanho, custoproduto as Custo, precoproduto as Preço, qtdproduto as Quantidade, CASE WHEN ativoproduto = true THEN 'SIM' ELSE 'NÃO' end as Ativo FROM produtos";
            try
            {
                MySqlDataReader dr = mySqlCmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao listar Produtos!" + e.Message, "Listar Produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
