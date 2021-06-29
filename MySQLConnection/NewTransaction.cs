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
    public partial class NewTransaction : UserControl
    {
        public NewTransaction()
        {
            InitializeComponent();


            LoadItems();
        }

        // These variable are properties
        // to track changes through out the transaction.
        //
        private float subtotal = 0.00f;
        private float total = 0.00f;

        void LoadItems()
        {
            using (MySqlConnection con = new DBConnection().Connection)
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM items";

                MySqlDataReader reader = cmd.ExecuteReader();

                // Clear the listview first before loading the items
                // So it will not append.
                listView_items.Items.Clear();

                // Load the data to the list view
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetValue(0).ToString(),
                        reader.GetValue(1).ToString(),
                        reader.GetValue(2).ToString()
                    };
                    ListViewItem item = new ListViewItem(row);
                    listView_items.Items.Add(item);

                }

                con.Close();
            }
        }

        void SearchItems()
        {
            using (MySqlConnection con = new DBConnection().Connection)
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM items WHERE name LIKE @search";

                cmd.Parameters.AddWithValue("search", textBox_search.Text + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                // Clear the listview first before loading the items
                // So it will not append.
                listView_items.Items.Clear();

                // Load the data to the list view
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetValue(0).ToString(),
                        reader.GetValue(1).ToString(),
                        reader.GetValue(2).ToString()
                    };
                    ListViewItem item = new ListViewItem(row);
                    listView_items.Items.Add(item);

                }



                con.Close();
            }
        }

        private void listView_items_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            // Check if there are no selected items in the listview_Items
            // Then disable the UI in the cart system
            if (listView_items.SelectedItems.Count == 0)
            {
                button_add.Enabled = false;
                button_minus.Enabled = false;
                button_addToCart.Enabled = false;
                textBox_qty.Enabled = false;
                return;
            }

            // Enable these items if there is a selected item
            button_add.Enabled = true;
            button_minus.Enabled = true;
            button_addToCart.Enabled = true;
            textBox_qty.Enabled = true;



            textBox_qty.Text = "1";

        }


        // Add +1 to qty
        private void button_add_Click(object sender, EventArgs e)
        {
            textBox_qty.Text = (Int32.Parse(textBox_qty.Text) + 1).ToString();
        }
        // Add -1 to qty.
        // Checks if qty is bellow 1 then dont change the value.
        private void button_minus_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(textBox_qty.Text);
            if (count > 1)
            {
                textBox_qty.Text = (Int32.Parse(textBox_qty.Text) - 1).ToString();
            }
        }



        private void textBox_qty_TextChanged(object sender, EventArgs e)
        {
            // Use only numbers in the QTY textbox
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_search.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox_search.Text = textBox_search.Text.Remove(textBox_search.Text.Length - 1);
                // Stops the code from executing the next statements
                return;
            }



            // Check if qty is empty
            if (textBox_qty.Text == "" ||
                textBox_qty.Text == "0")
            {
                textBox_qty.Text = "1";
            }

            // Change the subtotal
            // To get the subtotal: 
            // Get the price of the selected item 
            // and multiply it by qty
            // subtotal = price * qty
            subtotal = (float)Double.Parse(listView_items.SelectedItems[0].SubItems[2].Text) * Int32.Parse(textBox_qty.Text);
            label_subtotal.Text = subtotal.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Refer to searchitems() method
            SearchItems();
        }

        private void button_addToCart_Click(object sender, EventArgs e)
        {
            string[] li =
            {
                listView_items.SelectedItems[0].SubItems[0].Text,
                listView_items.SelectedItems[0].SubItems[1].Text,
                textBox_qty.Text,
                subtotal.ToString()

            };
            ListViewItem item = new ListViewItem(li);
            listView_cart.Items.Add(item);
            CalculateTotal();
        }

        // Calculate the total if the cart listview is changed

        void CalculateTotal()
        {

            if (listView_items.Items.Count == 0)
            {
                total = 0.00f;

            }
            foreach (ListViewItem item in listView_cart.Items)
            {
                total += (float)Double.Parse(item.SubItems[3].Text);
            }
            label_total.Text = total.ToString();
        }

        private void listView_cart_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView_cart.Items.Count > 1)
            {
                button_remove.Enabled = true;
            }
            else
            {
                button_remove.Enabled = true;
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_cart.SelectedItems)
            {
                listView_cart.Items.Remove(item);
            }
            CalculateTotal();
        }


        void AddTransaction()
        {
            using (MySqlConnection con = new DBConnection().Connection)
            {
                con.Open();


                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO transactions (employee_id) VALUES (@id)";
                cmd.Parameters.AddWithValue("id", UserInfo.id);
                cmd.ExecuteNonQuery();



                // Get the ID transaction created above
                // and save it to 'transaction_id' variable
                cmd.CommandText = "SELECT LAST_INSERT_ID();";
                int transaction_id = Int32.Parse(cmd.ExecuteScalar().ToString());



                // Insert the data to transaction_details
                // with the 'transaction_id' variable
                foreach (ListViewItem item in listView_cart.Items)
                {

                    cmd = new MySqlCommand();

                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO transaction_details " +
                        "(transaction_id, item_id, qty) " +
                        "VALUES " +
                        "(@trans_id, @item_id, @qty)";

                    cmd.Parameters.AddWithValue("trans_id", transaction_id);
                    cmd.Parameters.AddWithValue("item_id", Int32.Parse(item.SubItems[0].Text));
                    cmd.Parameters.AddWithValue("qty", Int32.Parse(item.SubItems[2].Text));
                    cmd.ExecuteNonQuery();
                }


                con.Close();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Confirm to top
                if (MessageBox.Show("Confirm Transaction?", "Confirm",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    AddTransaction();
                    listView_cart.Items.Clear();
                    MessageBox.Show("Transaction Complete");
                }

            }
            catch
            {
                MessageBox.Show("Something went wrong!");
            }
        }


    }
    
}
