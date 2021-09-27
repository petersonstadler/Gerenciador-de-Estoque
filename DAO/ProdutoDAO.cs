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
    class ProdutoDAO : DAO
    {

        public ProdutoDAO()
        {
            nomeTabela = "produtos";
            apelidoTabela = "Produtos";

            nomeTodasColunas = new string[] { "idproduto", "nomeproduto", "descproduto", "tamanhoproduto", "custoproduto", "precoproduto", "categorias_idcategoria", "qtdproduto", "ativoproduto" };
            apelidoTodasColunas = new string[] { "Id", "Nome", "Descrição", "Tamanho", "Custo", "Preço", "Categoria", "Quantidade", "Ativo" };

            nomeColunasSelect = nomeTodasColunas;
            apelidoColunasSelect = apelidoTodasColunas;

            colunasInserir = new string[] { "nomeproduto", "descproduto", "tamanhoproduto", "custoproduto", "precoproduto", "categorias_idcategoria", "qtdproduto", "ativoproduto" };
            parametrosColunasInserir = new string[] { "?nome", "?descricao", "?tamanho", "?custo", "?preco", "?categoria", "?quantidade", "?ativo" };

            colunasAlterar = new string[] { "nomeproduto", "descproduto", "tamanhoproduto", "custoproduto", "precoproduto", "categorias_idcategoria", "qtdproduto", "ativoproduto" };
            parametrosColunasAlterar = new string[] { "?nome", "?descricao", "?tamanho", "?custo", "?preco", "?categoria", "?quantidade", "?ativo" };
        }

        protected override void AddParametrosInserir(object obj)
        {
            Produto produto = obj as Produto;
            cmd.Parameters.AddWithValue(parametrosColunasInserir[0], produto.Nome);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[1], produto.Descricao);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[2], produto.Tamanho);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[3], produto.Custo);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[4], produto.Preco);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[5], produto.Idcategoria);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[6], produto.Quantidade);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[7], produto.Ativo);
        }

        protected override void AddParametroAlterar(object obj)
        {
            Produto produto = obj as Produto;
            cmd.Parameters.AddWithValue(parametrosColunasInserir[0], produto.Nome);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[1], produto.Descricao);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[2], produto.Tamanho);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[3], produto.Custo);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[4], produto.Preco);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[5], produto.Idcategoria);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[6], produto.Quantidade);
            cmd.Parameters.AddWithValue(parametrosColunasInserir[7], produto.Ativo);
        }

        protected override object PreencherDados(MySqlDataReader dr)
        {
            Produto produto = new Produto();
            if (dr.Read())
            {
                produto.Id = dr.GetInt32(nomeTodasColunas[0]);
                produto.Nome = dr.GetString(nomeTodasColunas[1]);
                produto.Descricao = dr.GetString(nomeColunasSelect[2]);
                produto.Tamanho = dr.GetString(nomeTodasColunas[3]);
                produto.Custo = dr.GetDecimal(nomeTodasColunas[4]);
                produto.Preco = dr.GetDecimal(nomeTodasColunas[5]);
                produto.Idcategoria = dr.GetInt32(nomeTodasColunas[6]);
                produto.Quantidade = dr.GetFloat(nomeTodasColunas[7]);
                produto.Ativo = dr.GetBoolean(nomeTodasColunas[8]);
            }
            else
            {
                produto.Id = 0;
                MessageBox.Show("Produto não encontrado!", "Buscar Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return produto;
        }
    }
}
