using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gerenciador_de_Estoque.DAO
{
    class ProdutoDAO
    {
        private MySqlConnection mySqlConn;
        private MySqlCommand mySqlCmd;

        public ProdutoDAO()
        {
            mySqlConn = new Conexao().GetConnection();
            mySqlCmd = mySqlConn.CreateCommand();
        }

        public void CloseConnection()
        {
            try
            {
                mySqlConn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao fechar conexão! \n\n" + e.Message, "Fechar Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InserirProduto()
        {

        }
    }
}
