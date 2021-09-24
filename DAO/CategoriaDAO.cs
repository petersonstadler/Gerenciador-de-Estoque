using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gerenciador_de_Estoque.MODEL;

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
        }

        protected override void AddParametrosInserir(object obj)
        {
            Categoria categoria = obj as Categoria;
            cmd.Parameters.AddWithValue(parametrosColunasInserir[0], categoria.Nome);
        }
    }
}
