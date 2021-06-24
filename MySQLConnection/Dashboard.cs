using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MySQLConnection
{
    public partial class Dashboard : Form
    {




        public Dashboard()
        {
            InitializeComponent();
        }

        // Makes sure that the app will 
        // close if 'x' button is clicked
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear all elements (if any) in
            // the panel1 and adds the 'NewTrasnaction.cs'
            // UserControll to panel1
            NewTransaction nt = new NewTransaction();

            // Makes sure that the UserControll is filled within
            // the panel
            nt.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(nt);
            
        }
    }
}
