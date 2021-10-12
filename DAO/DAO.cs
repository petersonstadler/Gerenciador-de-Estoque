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

        private string nomeTabela = "";
        private string apelidoTabela = "";

        private string[] nomeTodasColunas = new string[0];
        private string[] apelidoTodasColunas = new string[0];

        private string[] nomeColunasSelect = new string[0];
        private string[] apelidoColunasSelect = new string[0];

        private string[] colunasInserir = new string[0];
        private string[] parametrosColunasInserir = new string[0];

        private string[] colunasAlterar = new string[0];
        private string[] parametrosColunasAlterar = new string[0];

        public string NomeTabela { get => nomeTabela; set => nomeTabela = value; }
        public string ApelidoTabela { get => apelidoTabela; set => apelidoTabela = value; }
        public string[] NomeTodasColunas { get => nomeTodasColunas; set => nomeTodasColunas = value; }
        public string[] ApelidoTodasColunas { get => apelidoTodasColunas; set => apelidoTodasColunas = value; }
        public string[] NomeColunasSelect { get => nomeColunasSelect; set => nomeColunasSelect = value; }
        public string[] ApelidoColunasSelect { get => apelidoColunasSelect; set => apelidoColunasSelect = value; }
        public string[] ColunasInserir { get => colunasInserir; set => colunasInserir = value; }
        public string[] ParametrosColunasInserir { get => parametrosColunasInserir; set => parametrosColunasInserir = value; }
        public string[] ColunasAlterar { get => colunasAlterar; set => colunasAlterar = value; }
        public string[] ParametrosColunasAlterar { get => parametrosColunasAlterar; set => parametrosColunasAlterar = value; }

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
                MessageBox.Show("Erro ao fechar conexão! \n\n" + e, "Fechar Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual List<object> PreencherLista(MySqlDataReader dr) { return new List<object>(); }

        public List<object> ListarComFiltro(string filtros)
        {
            List<object> listaObj = new List<object>();
            try
            {
                cmd.CommandText = new GeradorScriptsSql().GerarSqlSELECT(NomeTabela, NomeTodasColunas, ApelidoTodasColunas) + " WHERE " + filtros;
                MySqlDataReader dr = cmd.ExecuteReader();
                listaObj = PreencherLista(dr);
                dr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao Listar! \n\n" + e, "Listar " + nomeTabela, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaObj;
        }

        public DataTable ListarEmDataTable()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd.CommandText = new GeradorScriptsSql().GerarSqlSELECT(NomeTabela, NomeColunasSelect, ApelidoColunasSelect);
                MySqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao listar {ApelidoTabela}! \n\n" + e, $"Listar {ApelidoTabela}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public DataTable ListarEmDataTableComFiltros(string filtros)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd.CommandText = new GeradorScriptsSql().GerarSqlSELECT(NomeTabela, NomeColunasSelect, ApelidoColunasSelect) + " WHERE " + filtros;
                MySqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao listar {ApelidoTabela}! \n\n" + e, $"Listar {ApelidoTabela}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        //Este metodo terá que ser sobrescrito na classe que vai ser herdada através do override
        protected virtual void AddParametrosInserir(Object obj) { }

        public void Inserir(Object obj)
        {
            try
            {
                cmd.CommandText = new GeradorScriptsSql().GerarSqlINSERT(NomeTabela, ColunasInserir, ParametrosColunasInserir);
                AddParametrosInserir(obj);
                _ = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch(Exception e)
            {
                MessageBox.Show($"Erro ao inserir {ApelidoTabela}! \n\n" + e, $"Inserir {ApelidoTabela}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Este metodo terá que ser sobrescrito na classe que vai ser herdada através do override
        protected virtual void AddParametroAlterar(Object obj) { }

        public void Alterar(int id, Object obj)
        {
            try
            {
                cmd.CommandText = new GeradorScriptsSql().GerarSqlUPDATE(id, NomeTodasColunas[0], NomeTabela, ColunasAlterar, ParametrosColunasAlterar);
                AddParametroAlterar(obj);
                _ = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch(Exception e)
            {
                MessageBox.Show($"Erro ao Alterar {ApelidoTabela}! \n\n" + e, $"Alterar {ApelidoTabela}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Deletar(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM " + NomeTabela + " WHERE " + NomeTodasColunas[0] + " = " + id;
                _ = cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show($"Erro ao excluir {ApelidoTabela}! \n\n" + e, $"Excluir {ApelidoTabela}", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string colunas = new GeradorScriptsSql().ColunasParaString(NomeTodasColunas);
            try
            {
                cmd.CommandText = "SELECT " + colunas + " FROM " + NomeTabela + " WHERE " + NomeTodasColunas[0] + " = " + id;
                MySqlDataReader dr = cmd.ExecuteReader();
                obj = PreencherDados(dr);
                dr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show($"Erro ao buscar {ApelidoTabela} por ID! \n\n" + e, $"Buscar {ApelidoTabela} por ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return obj;
        }

        public DataTable BuscarPorNome(string nome)
        {
            DataTable dt = new DataTable();
            string colunas = new GeradorScriptsSql().ColunasParaString(NomeColunasSelect, ApelidoColunasSelect);
            try
            {
                cmd.CommandText = "SELECT " + colunas + " FROM " + NomeTabela + " WHERE " + NomeTodasColunas[1] + " LIKE " + "?nome";
                cmd.Parameters.AddWithValue("?nome", "%"+nome+"%");
                MySqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                cmd.Parameters.Clear();
            }
            catch(Exception e)
            {
                MessageBox.Show($"Erro ao buscar {ApelidoTabela} por Nome! \n\n" + e, $"Buscar {ApelidoTabela} por Nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
    }
}
