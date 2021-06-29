using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySqlConnector;

namespace MySQLConnection
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void LoginSQL()
        {
            using (MySqlConnection con = new DBConnection().Connection)
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;

                //  Use prepared statements in using queries
                //  to avoid SQL injetion.
                cmd.CommandText = "SELECT * FROM employee WHERE username = @username AND password = @password";
                cmd.Parameters.AddWithValue("username", textBox_Username.Text);
                cmd.Parameters.AddWithValue("password", textBox_Password.Text);


                MySqlDataReader reader = cmd.ExecuteReader();

                // If no data was retrieved from the query
                // then show the invalid username or password messagebox
                // and stops
                if (!reader.HasRows)
                {
                    MessageBox.Show("Invalid Username or Password",
                        "Login Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    con.Close();
                    return;
                }



                // Set User info
                reader.Read();
                UserInfo.id = reader.GetInt32(0);
                UserInfo.firstame = reader.GetString(1);
                UserInfo.lastname = reader.GetString(2);
                UserInfo.username = reader.GetString(3);

                
                
                
                
                // Makes sure that the db is closed
                con.Close();

                // Show the dashboard
                new Dashboard().Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Refer to LoginSQL() 
            LoginSQL();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            using (MySqlConnection con = new DBConnection().Connection)
            {
                try
                {
                    con.Open();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database is not found");
                    Application.Exit();

                }
               
            }
        }
    }
}
