using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MySqlConnector;

namespace MySQLConnection
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
            GetInfo();
        }


        void UpdateTable(string column, string data)
        {
            using (MySqlConnection con = new DBConnection().Connection)
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE employee" +
                    " SET " + column + " = @value " +
                    " WHERE id = @id";

                cmd.Parameters.AddWithValue("value", data);
                cmd.Parameters.AddWithValue("id", UserInfo.id);
                

                cmd.ExecuteNonQuery();

                con.Close();
            }
        }

        void GetInfo()
        {
            using (MySqlConnection con = new DBConnection().Connection)
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM employee";
                
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Read();

                label_id.Text = reader.GetValue(0).ToString();

                textBox_lastname.Text = reader.GetValue(1).ToString();
                textBox_firstname.Text = reader.GetValue(2).ToString();
                textBox_username.Text = reader.GetValue(3).ToString();
                textBox_password.Text = reader.GetValue(4).ToString();

                con.Close();
            }

        }

        void UpdateInfo(Button btn, TextBox txtbox, string column)
        {
            if (btn.Text == "Update")
            {
                txtbox.Enabled = true;
                txtbox.ForeColor = Color.Red;
                btn.BackColor = Color.Violet;
                btn.Text = "Finish";
            }
            else
            {
                txtbox.Enabled = false;
                txtbox.ForeColor = Color.Black;
                btn.Text = "Update";
                btn.BackColor = Color.FromArgb(255, 128, 128);
                UpdateTable(column, txtbox.Text);

                MessageBox.Show("Info Updated");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateInfo(button1,textBox_lastname, "lastname");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateInfo(button4, textBox_username, "username");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateInfo(button3, textBox_password, "password");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateInfo(button2, textBox_lastname, "firstname");
        }
    }
}
