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

        private void AdicionarParametrosSemId(Produto produto)
        {
            mySqlCmd.Parameters.AddWithValue("?nome", produto.Nome);
            mySqlCmd.Parameters.AddWithValue("?descricao", produto.Descricao);
            mySqlCmd.Parameters.AddWithValue("?tamanho", produto.Tamanho);
            mySqlCmd.Parameters.AddWithValue("?custo", produto.Custo);
            mySqlCmd.Parameters.AddWithValue("?preco", produto.Preco);
            mySqlCmd.Parameters.AddWithValue("?idcategoria", produto.Idcategoria);
            mySqlCmd.Parameters.AddWithValue("?quantidade", produto.Quantidade);
            mySqlCmd.Parameters.AddWithValue("?ativo", produto.Ativo);
        }

        public void InserirProduto(Produto produto)
        {
            mySqlCmd.CommandText = "INSERT INTO produtos (nomeproduto, descproduto, tamanhoproduto, custoproduto, precoproduto, categorias_idcategoria, qtdproduto, ativoproduto) VALUES (?nome, ?descricao, ?tamanho, ?custo, ?preco, ?idcategoria, ?quantidade, ?ativo);";
            AdicionarParametrosSemId(produto);
            try
            {
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Produto inserido com sucesso! \n\n", "Inserir Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar comando Inserir Produto! \n\n" + e.Message, "Inserir Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Erro ao listar Produtos! \n\n" + e.Message, "Listar Produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private Produto PreencherDadosComDataReader(MySqlDataReader dr)
        {
            Produto produto = new Produto();
            try
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    produto.Id = dr.GetInt32(0);
                    produto.Nome = dr.GetString(1);
                    produto.Descricao = dr.GetString(2);
                    produto.Tamanho = dr.GetString(3);
                    produto.Custo = dr.GetDecimal(4);
                    produto.Preco = dr.GetDecimal(5);
                    produto.Idcategoria = dr.GetInt32(6);
                    produto.Quantidade = dr.GetFloat(7);
                    produto.Ativo = dr.GetBoolean(8);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao Preencher dados! \n\n" + e, "Preencher dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return produto;
        }

        public Produto BuscarProdutoPorId(int id)
        {
            Produto produto = new Produto();
            try
            {
                mySqlCmd.CommandText = "SELECT idproduto, nomeproduto, descproduto, tamanhoproduto, custoproduto, precoproduto, categorias_idcategoria, qtdproduto, ativoproduto FROM produtos WHERE idproduto = ?idproduto";
                mySqlCmd.Parameters.AddWithValue("idproduto", id);
                MySqlDataReader dr = mySqlCmd.ExecuteReader();
                produto = PreencherDadosComDataReader(dr);
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao buscar Produto! \n\n" + e.Message, "Buscar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return produto;
        }

        public void AlterarProduto(Produto produto)
        {
            mySqlCmd.CommandText = $"UPDATE produtos SET nomeproduto = ?nome, descproduto = ?descricao, tamanhoproduto = ?tamanho, custoproduto = ?custo, precoproduto = ?preco, categorias_idcategoria = ?idcategoria, qtdproduto = ?quantidade, ativoproduto = ?ativo WHERE idproduto = ?idproduto;";
            AdicionarParametrosSemId(produto);
            mySqlCmd.Parameters.AddWithValue("idproduto", produto.Id);
            try
            {
                mySqlCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao alterar Produto! \n\n" + e.Message, "Alterar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
