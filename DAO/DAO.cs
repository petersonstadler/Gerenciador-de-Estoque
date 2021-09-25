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

        public DataTable ListarEmDataTable()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd.CommandText = new GeradorScriptsSql().GerarSqlSELECT(nomeTabela, nomeColunasSelect, apelidoColunasSelect);
                MySqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao listar {apelidoTabela}! \n\n" + e, $"Listar {apelidoTabela}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        //Este metodo terá que ser sobrescrito na classe que vai ser herdada através do override
        protected virtual void AddParametrosInserir(Object obj) { }

        public void Inserir(Object obj)
        {
            try
            {
                cmd.CommandText = new GeradorScriptsSql().GerarSqlINSERT(nomeTabela, colunasInserir, parametrosColunasInserir);
                AddParametrosInserir(obj);
                _ = cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show($"Erro ao inserir {apelidoTabela}! \n\n" + e.Message, $"Inserir {apelidoTabela}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Este metodo terá que ser sobrescrito na classe que vai ser herdada através do override
        protected virtual void AddParametroAlterar(Object obj) { }

        public void Alterar(int id, Object obj)
        {
            try
            {
                cmd.CommandText = new GeradorScriptsSql().GerarSqlUPDATE(id, nomeTodasColunas[0], nomeTabela, colunasAlterar, parametrosColunasAlterar);
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
            string colunas = new GeradorScriptsSql().ColunasParaString(nomeTodasColunas);
            try
            {
                cmd.CommandText = "SELECT " + colunas + " FROM " + nomeTabela + " WHERE " + nomeTodasColunas[0] + " = " + id;
                MySqlDataReader dr = cmd.ExecuteReader();
                obj = PreencherDados(dr);
                dr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show($"Erro ao buscar {apelidoTabela} por ID! \n\n" + e, $"Buscar {apelidoTabela} por ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return obj;
        }
    }
}
