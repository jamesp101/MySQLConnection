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
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
        }

        double total = 0;

        private void History_Load(object sender, EventArgs e)
        {
            using (MySqlConnection con = new DBConnection().Connection)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM vwTransactions";



                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string[] i =
                    {
                        reader.GetValue(0).ToString(),
                        reader.GetValue(1).ToString(),
                        reader.GetValue(2).ToString(),

                    };

                    ListViewItem item = new ListViewItem(i);
                    listView1.Items.Add(item);

                   
                }
                con.Close();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                return;
            }
            using (MySqlConnection con = new DBConnection().Connection)
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();

                // Get the id of the selected item
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM vwTransactionsDetails WHERE transaction_id=@id";
                cmd.Parameters.AddWithValue("id", listView1.SelectedItems[0].SubItems[0].Text ); 
                
                MySqlDataReader reader = cmd.ExecuteReader();

                listView_cart.Items.Clear();

                while (reader.Read())
                {
                    string[] i =
                    {
                        reader.GetValue(1).ToString(),
                        reader.GetValue(2).ToString(),
                        reader.GetValue(3).ToString(),
                        reader.GetValue(4).ToString(),
                    };

                    

                    ListViewItem item = new ListViewItem(i);
                    listView_cart.Items.Add(item);

                    Double.TryParse(reader.GetValue(4).ToString(), out total);
                    label_total.Text = total.ToString();
                }
                con.Close();
            }
        }
    }
}


/*
    CREATE VIEW vwTransactions AS

    SELECT 
    `transactions`.`id`,
    `transactions`.`transaction_date`,
    CONCAT(`employee`.`lastname`, ', ', employee.firstname) as Employee

    FROM
    transactions

    INNER JOIN employee

        ON transactions.employee_id = employee.id
*/

/*
CREATE VIEW vwtransactionsDetails as
    SELECT 
    transaction_details.transaction_id,
    transaction_details.item_id,
    items.name,
    transaction_details.qty,
    items.price * transaction_details.qty as 'subtotal'
    FROM 
	    `transaction_details` 

    INNER JOIN items
    ON transaction_details.item_id = items.id

*/