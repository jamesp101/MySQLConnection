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


            // See button1_Click() 
            NewTransaction nt = new NewTransaction();
            nt.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(nt);
        }

        // Makes sure that the app will 
        // close if 'x' button is clicked
        // --
        // Add this to 'Form Closed' event
        // in the Desgin view
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear all elements (if any) in
            // the panel1 and adds the 'NewTrasnaction.cs'
            // UserControll to panel1
            NewTransaction nt = new NewTransaction();

            // Makes sure that the UserControl is filled within
            // the panel
            nt.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(nt);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Change the panel with History UserControll
            History nt = new History();

            nt.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(nt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Change the panel with History UserControll
            Profile nt = new Profile();

            nt.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(nt);
        }
    }
}
