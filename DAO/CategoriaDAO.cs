using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciador_de_Estoque.MODEL;
using MySql.Data.MySqlClient;

namespace Gerenciador_de_Estoque.DAO
{
    class CategoriaDAO : DAO
    {



        public CategoriaDAO()
        {
            nomeTabela = "categorias";
            apelidoTabela = "Categorias";

            nomeTodasColunas = new string[] { "idcategoria", "nomecategoria" };
            apelidoTodasColunas = new string[] { "Id", "Nome" };

            nomeColunasSelect = new string[] { "idcategoria", "nomecategoria" };
            apelidoColunasSelect = new string[] { "Id", "Nome" };

            colunasInserir = new string[] { "nomecategoria" };
            parametrosColunasInserir = new string[] { "?nome" };

            colunasAlterar = colunasInserir;
            parametrosColunasAlterar = parametrosColunasInserir;
        }

        protected override void AddParametrosInserir(object obj)
        {
            Categoria categoria = obj as Categoria;
            cmd.Parameters.AddWithValue(parametrosColunasInserir[0], categoria.Nome);
        }

        protected override void AddParametroAlterar(object obj)
        {
            Categoria categoria = obj as Categoria;
            cmd.Parameters.AddWithValue(parametrosColunasAlterar[0], categoria.Nome);
        }

        protected override object PreencherDados(MySqlDataReader dr)
        {
            Categoria categoria = new Categoria();
            if (dr.Read())
            {
                categoria.Id = dr.GetInt32("idcategoria");
                categoria.Nome = dr.GetString("nomecategoria");
            }
            else
            {
                categoria.Id = 0;
            }
            return categoria;
        }
    }
}
