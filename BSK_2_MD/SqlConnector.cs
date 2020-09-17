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
        private List<string> selectList = new List<string>();
        private List<string> insertList = new List<string>();
        private SelectQueries selectQueries = new SelectQueries();
        private SqlConnection sqlConnection = null;
        private bool connected = false;

        public SqlConnector()
        {
            this.FillLists();
        }

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
                        password + "';  USE " + databasename + "; CREATE USER " + username + " FOR LOGIN " + username + ";" +
                        "alter role [db_datareader] add member [" + username + "];" +
                        "alter role [db_datawriter] add member [" + username + "];";

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
                    connected = true;
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
                connected = false;
                sqlConnection.Close();
            }
        }

        public string ExecuteCommandSelect(int commandNumber)
        {
            string queryString = "";
            try
            {
                queryString = selectList[commandNumber];
            }
            catch
            {
                MessageBox.Show("No such query", "Error", MessageBoxButtons.OK);
                return "Error";
            }
            if (sqlConnection != null && connected && queryString != "")
            {
                string output = "";
                SqlCommand command = new SqlCommand(queryString, sqlConnection);
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        output += "| ";
                        int columns = reader.FieldCount - 1;
                        for (int i = 0; i < columns; i++)
                        {
                            output += (reader.GetName(i)) + " | ";
                        }
                        output += Environment.NewLine;
                        output += Environment.NewLine;
                        while (reader.Read())
                        {
                            output += "| ";
                            for (int i = 0; i < columns; i++)
                            {
                                var temp_out = reader.GetValue(i).ToString() + " | ";
                                if (temp_out == " | ")
                                {
                                    temp_out = "\t| ";
                                }
                                output += temp_out;
                            }
                            output += Environment.NewLine;
                            output += Environment.NewLine;
                        }
                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }
                    return output;
                }
                catch
                {
                    output = "Clereance level to low";
                    return output;
                }
            }
            else
            {
                return "Error";
            }

        }
        public string ExecuteCommandInsert(int commandNumber)
        {
            string queryString = "";
            try
            {
                queryString = insertList[commandNumber];
            }
            catch
            {
                MessageBox.Show("No such query", "Error", MessageBoxButtons.OK);
                return "Error";
            }
            if (sqlConnection != null && connected && queryString != "")
            {
                string output = "";
                SqlCommand command = new SqlCommand(queryString, sqlConnection);
                try
                {
                    var result = command.ExecuteNonQuery();
                    output = "Command copleted";
                }
                catch
                {
                    return "Clereance level to low";
                }
                return output;
            }
            else
            {
                return "Error";
            }

        }

        private void FillLists()
        {
            foreach (KeyValuePair<int, string> item in selectQueries.SelectQueriesMap)
            {
                selectList.Add(item.Value);
            }
        }
    }
}
