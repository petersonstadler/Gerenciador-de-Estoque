using Gerenciador_de_Estoque.MODEL;
using MySql.Data.MySqlClient;

namespace Gerenciador_de_Estoque.DAO
{
    class CategoriaDAO : DAO
    {



        public CategoriaDAO()
        {
            NomeTabela = "categorias";
            ApelidoTabela = "Categorias";

            NomeTodasColunas = new string[] { "idcategoria", "nomecategoria" };
            ApelidoTodasColunas = new string[] { "Id", "Nome" };

            NomeColunasSelect = new string[] { "idcategoria", "nomecategoria" };
            ApelidoColunasSelect = new string[] { "Id", "Nome" };

            ColunasInserir = new string[] { "nomecategoria" };
            ParametrosColunasInserir = new string[] { "?nome" };

            ColunasAlterar = ColunasInserir;
            ParametrosColunasAlterar = ParametrosColunasInserir;
        }

        protected override void AddParametrosInserir(object obj)
        {
            Categoria categoria = obj as Categoria;
            cmd.Parameters.AddWithValue(ParametrosColunasInserir[0], categoria.Nome);
        }

        protected override void AddParametroAlterar(object obj)
        {
            Categoria categoria = obj as Categoria;
            cmd.Parameters.AddWithValue(ParametrosColunasAlterar[0], categoria.Nome);
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

        public bool VerificarCategoria(int idCategoria)
        {
            Categoria categoria = BuscarPorId(idCategoria) as Categoria;
            if (categoria.Id > 0)
                return true;
            return false;
        }
    }
}
