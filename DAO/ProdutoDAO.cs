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
            NomeTabela = "produtos";
            ApelidoTabela = "Produtos";

            NomeTodasColunas = new string[] { "idproduto", "nomeproduto", "descproduto", "tamanhoproduto", "custoproduto", "precoproduto", "categorias_idcategoria", "ativoproduto" };
            ApelidoTodasColunas = new string[] { "Id", "Nome", "Descrição", "Tamanho", "Custo", "Preço", "Categoria", "Ativo" };

            NomeColunasSelect = new string[] { "idproduto", "nomeproduto", "descproduto", "tamanhoproduto", "custoproduto", "precoproduto", "(SELECT nomecategoria FROM categorias WHERE categorias_idcategoria = idcategoria)", "((SELECT SUM(qtdmovimento) FROM movimentos WHERE produtos_idproduto = idproduto AND operacaomovimento = 'ENTRADA') - (SELECT SUM(qtdmovimento) FROM movimentos WHERE produtos_idproduto = idproduto AND operacaomovimento = 'SAIDA'))", "ativoproduto" };
            ApelidoColunasSelect = new string[] { "Id", "Nome", "Descrição", "Tamanho", "Custo", "Preço", "Categoria", "Quantidade", "Ativo" };

            ColunasInserir = new string[] { "nomeproduto", "descproduto", "tamanhoproduto", "custoproduto", "precoproduto", "categorias_idcategoria", "ativoproduto" };
            ParametrosColunasInserir = new string[] { "?nome", "?descricao", "?tamanho", "?custo", "?preco", "?categoria", "?ativo" };

            ColunasAlterar = new string[] { "nomeproduto", "descproduto", "tamanhoproduto", "custoproduto", "precoproduto", "categorias_idcategoria", "ativoproduto" };
            ParametrosColunasAlterar = new string[] { "?nome", "?descricao", "?tamanho", "?custo", "?preco", "?categoria", "?ativo" };
        }

        protected override void AddParametrosInserir(object obj)
        {
            Produto produto = obj as Produto;
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[0], produto.Nome);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[1], produto.Descricao);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[2], produto.Tamanho);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[3], produto.Custo);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[4], produto.Preco);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[5], produto.Idcategoria);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[6], produto.Ativo);
        }

        protected override void AddParametroAlterar(object obj)
        {
            Produto produto = obj as Produto;
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[0], produto.Nome);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[1], produto.Descricao);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[2], produto.Tamanho);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[3], produto.Custo);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[4], produto.Preco);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[5], produto.Idcategoria);
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[6], produto.Ativo);
        }

        protected override object PreencherDados(MySqlDataReader dr)
        {
            Produto produto = new Produto();
            if (dr.Read())
            {
                produto.Id = dr.GetInt32(NomeTodasColunas[0]);
                produto.Nome = dr.GetString(NomeTodasColunas[1]);
                produto.Descricao = dr.GetString(NomeColunasSelect[2]);
                produto.Tamanho = dr.GetString(NomeTodasColunas[3]);
                produto.Custo = dr.GetDecimal(NomeTodasColunas[4]);
                produto.Preco = dr.GetDecimal(NomeTodasColunas[5]);
                produto.Idcategoria = dr.GetInt32(NomeTodasColunas[6]);
                produto.Ativo = dr.GetBoolean(NomeTodasColunas[7]);
            }
            else
            {
                produto.Id = 0;
            }
            return produto;
        }

        protected override List<object> PreencherLista(MySqlDataReader dr)
        {
            List<object> lista = new List<object>();
            while (dr.Read())
            {
                Produto produto = new Produto();
                produto.Id = dr.GetInt32(0);
                produto.Nome = dr.GetString(1);
                produto.Descricao = dr.GetString(2);
                produto.Tamanho = dr.GetString(3);
                produto.Custo = dr.GetDecimal(4);
                produto.Preco = dr.GetDecimal(5);
                produto.Idcategoria = dr.GetInt32(6);
                produto.Ativo = dr.GetBoolean(7);
                lista.Add(produto);
            }
            return lista;
        }
    }
}
