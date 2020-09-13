using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace BSK_2_MD
{
    public class SqlConnector
    {
        private SqlConnection sqlConnection = null;
        public bool ConnectToDataBase(string username, string password)
        {
            if (sqlConnection == null)
            {
                return Connect(username, password);
            }
            else
            {
                return Connect(username, password);
            }
        }

        public bool CreateUser(string username, string password)
        {

            string connection = @"Data Source=LAPTOP-9BG7K3OP;Initial Catalog=BSK_2;Integrated Security=True";
            string databasename = "BSK_2";

            try
            {

                using (SqlConnection conn = new SqlConnection(connection))
                {

                    conn.Open();


                    string sql = "CREATE LOGIN " + username + " WITH PASSWORD = '" +
                        password + "';  USE " + databasename + "; CREATE USER " + username + " FOR LOGIN " + username + ";";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                }
                Thread.Sleep(50);
                return ConnectToDataBase(username, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                return ConnectToDataBase(username, password);
            }
        }

        private bool Connect(string username, string password)
        {
            try
            {
                /// @"Data Source=LAPTOP-9BG7K3OP;Initial Catalog=RowLevelSecurity;User ID=<username>;Password=<psswd>;"
                string connectionString = String.Format(@"Data Source=LAPTOP-9BG7K3OP;Initial Catalog=BSK_2;User ID={0};Password={1};", username, password);
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void Disconnect()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
