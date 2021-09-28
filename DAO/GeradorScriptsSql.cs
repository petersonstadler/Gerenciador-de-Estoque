using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Estoque.DAO
{
    class GeradorScriptsSql
    {
        //Pega as colunas que estão em uma Array e formata elas em uma string no formato: coluna1, coluna2, coluna3.
        public string ColunasParaString(string[] NomeColunas)
        {
            string colunas = "";
            for (int i = 0; i < NomeColunas.Length; i++)
            {
                if (i == 0)
                {
                    colunas += NomeColunas[i];
                }
                else
                {
                    colunas += ", " + NomeColunas[i];
                }
            }
            return colunas;
        }

        //Pega as colunas que estão em uma Array e formata elas em uma string no formato: coluna1 as apelido1, coluna2 as apelido2, coluna3 as apelido3.
        public string ColunasParaString(string[] NomeColunas, string[] ApelidoColunas)
        {
            string colunas = "";
            for (int i = 0; i < NomeColunas.Length; i++)
            {
                if (i == 0)
                {
                    colunas += NomeColunas[i] + " as " + ApelidoColunas[i];
                }
                else
                {
                    colunas += ", " + NomeColunas[i] + " as " + ApelidoColunas[i];
                }
            }
            return colunas;
        }

        public string GerarSqlSELECT(string nomeTabela, string[] nomeColunasSelect, string[] apelidoColunasSelect)
        {

            string sql = "SELECT " + ColunasParaString(nomeColunasSelect, apelidoColunasSelect) + " FROM " + nomeTabela;
            return sql;
        }

        private string GerarParametros(string[] listaParametros)
        {
            string parametros = "";
            for (int i = 0; i < listaParametros.Length; i++)
            {
                if (i == 0)
                {
                    parametros += listaParametros[i];
                }
                else
                {
                    parametros += ", " + listaParametros[i];
                }
            }
            return parametros;
        }

        public string GerarSqlINSERT(string nomeTabela, string[] colunasInserir, string[] parametrosColunasInserir)
        {
            string sql = "INSERT INTO " + nomeTabela + "(" + ColunasParaString(colunasInserir) + ") VALUES (" + GerarParametros(parametrosColunasInserir) + ")";
            return sql;
        }

        private string GerarColunasComParametrosUPDATE(string[] colunasAlterar, string[] parametrosAlterar)
        {
            string colunasComParametros = "";
            for (int i = 0; i < parametrosAlterar.Length; i++)
            {
                if (i == 0)
                {
                    colunasComParametros += colunasAlterar[i] + " = " + parametrosAlterar[i];
                }
                else
                {
                    colunasComParametros += ", " + colunasAlterar[i] + " = " + parametrosAlterar[i];
                }
            }
            return colunasComParametros;
        }

        public string GerarSqlUPDATE(int id, string nomeColunaId, string nomeTabela, string[] colunasAlterar, string[] parametrosColunasAlterar)
        {
            string sql = "UPDATE " + nomeTabela + " SET " + GerarColunasComParametrosUPDATE(colunasAlterar, parametrosColunasAlterar) + " WHERE " + nomeColunaId + " = " + id;
            return sql;
        }
    }
}
