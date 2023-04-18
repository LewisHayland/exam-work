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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        //sets the string local to public so it can be used in other pages
        public static string local;

        public void btnRegister_Click(object sender, EventArgs e)
        {            
            //opens a connection to database
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Task 2\My Work\UserInfromation.accdb"))
            {
                //set variables with values
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                local = txtLocation.Text;
                string my_health = txtHealth.Text;


                connection.Open();
                string query = "INSERT INTO UserInfo (username_register, password_register, user_location, health_problem) VALUES (@user, @pass, @local, @my_health)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    //insets into the database the values
                    command.Parameters.AddWithValue("@username_register",user);
                    command.Parameters.AddWithValue("@password_register", pass);
                    command.Parameters.AddWithValue("@user_location", local);
                    command.Parameters.AddWithValue("@health_problem", my_health);

                    command.ExecuteNonQuery();
                }
                //closes the database and sends user to login page
                connection.Close();
            }
            MessageBox.Show("Registration successful");
            Login log = new Login();
            log.Show();
            this.Hide();
         
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //sends user to login page
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
