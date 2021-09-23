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
        private readonly MySqlConnection conn;
        private readonly MySqlCommand cmd;
        public string nometabela = "";
        public string[] NomeColunas = new string[0];
        public string[] ApelidoColunas = new string[0];

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

            string sql = "SELECT " + ColunasParaString(NomeColunas, ApelidoColunas) + " FROM " + nometabela;
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
                MessageBox.Show("Erro ao listar Produtos! \n\n" + e.Message, "Listar Produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
