using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gerenciador_de_Estoque.DAO
{
    class DAO
    {
        protected readonly MySqlConnection conn;
        protected readonly MySqlCommand cmd;

        protected string nomeTabela = "";
        protected string apelidoTabela = "";

        protected string[] nomeTodasColunas = new string[0];
        protected string[] apelidoTodasColunas = new string[0];

        protected string[] nomeColunasSelect = new string[0];
        protected string[] apelidoColunasSelect = new string[0];

        protected string[] colunasInserir = new string[0];
        protected string[] parametrosColunasInserir = new string[0];

        protected string[] colunasAlterar = new string[0];
        protected string[] parametrosColunasAlterar = new string[0];

        public DAO()
        {
            conn = new Conexao().GetConnection();
            cmd = conn.CreateCommand();
        }

        public void CloseConnections()
        {
            try
            {
                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao fechar conexão! \n\n" + e.Message, "Fechar Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Pega as colunas que estão em uma Array e formata elas em uma string no formato: coluna1, coluna2, coluna3.
        private string ColunasParaString(string[] NomeColunas)
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
        private string ColunasParaString(string[] NomeColunas, string[] ApelidoColunas)
        {
            string colunas = "";
            for(int i = 0; i < NomeColunas.Length; i++)
            {
                if(i == 0)
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

        private string GerarSqlSELECT()
        {

            string sql = "SELECT " + ColunasParaString(nomeColunasSelect, apelidoColunasSelect) + " FROM " + nomeTabela;
            return sql;
        }

        public DataTable ListarEmDataTable()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = GerarSqlSELECT();
            try
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao listar {apelidoTabela}! \n\n" + e.Message, $"Listar {apelidoTabela}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private string GerarParametros(string[] listaParametros)
        {
            string parametros = "";
            for(int i = 0; i < listaParametros.Length; i++)
            {
                if(i == 0)
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

        private string GerarSqlINSERT()
        {
            string sql = "INSERT INTO " + nomeTabela + "(" + ColunasParaString(colunasInserir) + ") VALUES (" + GerarParametros(parametrosColunasInserir) + ")";
            return sql;
        }

        //Este metodo terá que ser sobrescrito na classe que vai ser herdada através do override
        protected virtual void AddParametrosInserir(Object obj) { }

        public void Inserir(Object obj)
        {
            try
            {
                cmd.CommandText = GerarSqlINSERT();
                AddParametrosInserir(obj);
                _ = cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show($"Erro ao inserir {apelidoTabela}! \n\n" + e.Message, $"Inserir {apelidoTabela}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GerarColunasComParametrosUPDATE(string[] colunasAlterar, string[] parametrosAlterar)
        {
            string colunasComParametros = "";
            for(int i = 0; i < parametrosAlterar.Length; i++)
            {
                if(i == 0)
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

        private string GerarColunaIdUPDATE()
        {
            string colunaId = nomeTodasColunas[0];
            return colunaId;
        }

        private string GerarSqlUPDATE(int id)
        {
            string sql = "UPDATE " + nomeTabela + " SET " + GerarColunasComParametrosUPDATE(colunasAlterar, parametrosColunasAlterar) + " WHERE " + GerarColunaIdUPDATE() + " = " + id;
            return sql;
        }

        //Este metodo terá que ser sobrescrito na classe que vai ser herdada através do override
        protected virtual void AddParametroAlterar(Object obj) { }

        public void Alterar(int id, Object obj)
        {
            try
            {
                cmd.CommandText = GerarSqlUPDATE(id);
                AddParametroAlterar(obj);
                _ = cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show($"Erro ao Alterar {apelidoTabela}! \n\n" + e.Message, $"Alterar {apelidoTabela}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Deletar(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM " + nomeTabela + " WHERE " + nomeTodasColunas[0] + " = " + id;
                _ = cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show($"Erro ao excluir {apelidoTabela}! \n\n" + e.Message, $"Excluir {apelidoTabela}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Este metodo terá que ser sobrescrito na classe que vai ser herdada através do override
        protected virtual Object PreencherDados(MySqlDataReader dr)
        {
            return new Object();
        }

        public Object BuscarPorId(int id)
        {
            Object obj = null;
            try
            {
                cmd.CommandText = "SELECT " + ColunasParaString(nomeTodasColunas) + " FROM " + nomeTabela + " WHERE " + nomeTodasColunas[0] + " = " + id;
                MySqlDataReader dr = cmd.ExecuteReader();
                obj = PreencherDados(dr);
                dr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show($"Erro ao buscar {apelidoTabela} por ID! \n\n" + e.Message, $"Buscar {apelidoTabela} por ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return obj;
        }
    }
}
