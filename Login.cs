using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Development_Prototype
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string local;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //creates a connection to database
            string connectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Task 2\My Work\UserInfromation.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                //gives variables values
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                local = txtLocation.Text;

                connection.Open();
                //checks database to see if values are equal
                string query = "SELECT COUNT(*) FROM UserInfo WHERE username_register = @users AND password_register = @pass";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username_register", user);
                    command.Parameters.AddWithValue("@username_register", pass);
                    int count = (int)command.ExecuteScalar();
                    //if the values are the sames sends user to weather page else gives a error message
                    
                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");
                        Weather weth = new Weather();
                        weth.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Please try again.");
                    }
                }
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sends user to register page
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
