using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gerenciador_de_Estoque.DAO
{
    class Conexao
    {
        private string dbhost = "localhost";
        private string dbnome = "db_mayara";
        private string user = "teste";
        private string passwd = "teste";
        private int port = 3306;

        public MySqlConnection GetConnection()
        {
            MySqlConnection con = new MySqlConnection();
            try
            {
                string conString = "server=" + this.dbhost + ";database=" + this.dbnome + ";uid=" + this.user + ";pwd=" + this.passwd + ";port=" + this.port;
                con = new MySqlConnection(conString);
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao conectar-se com o banco de dados! \n\n" + e, "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
    }
}
