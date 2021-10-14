using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gerenciador_de_Estoque.DAO
{
    class Conexao
    {
        private readonly string dbhost = "localhost";
        private readonly string dbnome = "db_groovy";
        private readonly string user = "cliente";
        private readonly string passwd = "tangerina";
        private readonly int port = 3306;

        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                string conString = "server=" + this.dbhost + ";database=" + this.dbnome + ";uid=" + this.user + ";pwd=" + this.passwd + ";port=" + this.port;
                conn = new MySqlConnection(conString);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao conectar-se com o banco de dados! \n\n" + e, "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }
    }
}
