using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;


namespace BSK_2_MD
{
    public partial class Login : MaterialForm
    {
        private string password = null;
        private string login = null;
        private SqlConnector sqlConnector = null;


        public Login()
        {
            InitializeComponent();
            sqlConnector = new SqlConnector();
        }

        private void StartMainWindow()
        {
            this.Hide();
            Main mainWindow = new Main(ref sqlConnector);
            mainWindow.Show();
            mainWindow.FormClosed += MainWindow_FormClosed;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            sqlConnector.Disconnect();
            this.Close();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            this.password = passwordBox.Text;
            this.login = loginBox.Text;
            if( password != null && password != "" && login != null && login != "")
            {
                // check in authorization database cleareance level for each object
                if(sqlConnector.ConnectToDataBase(username: login, password: password))
                {
                    StartMainWindow();
                }
                else
                {
                    MessageBox.Show("Wrong credentials", "Error", MessageBoxButtons.OK);
                }

            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            this.password = passwordBox.Text;
            this.login = loginBox.Text;
            if (password != null && password != "" && login != null && login != "")
            {
                //create new user with uncpecified access
                if (sqlConnector.CreateUser(username: login, password: password))
                {
                    MessageBox.Show("User created successfully", "Success", MessageBoxButtons.OK);
                    StartMainWindow();
                }
                else
                {
                    MessageBox.Show("Wrong credentials", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
