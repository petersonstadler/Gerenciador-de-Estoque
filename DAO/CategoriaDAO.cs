using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Estoque.DAO
{
    class CategoriaDAO : DAO
    {
        public CategoriaDAO()
        {
            nometabela = "categorias";
            NomeColunas = new string[] { "idcategoria", "nomecategoria" };
            ApelidoColunas = new string[] { "Id", "Nome" };
        }
    }
}
