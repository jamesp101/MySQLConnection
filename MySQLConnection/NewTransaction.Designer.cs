
namespace MySQLConnection
{
    partial class NewTransaction
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView_cart = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_subtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_addToCart = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_qty = new System.Windows.Forms.TextBox();
            this.button_minus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.listView_items = new System.Windows.Forms.ListView();
            this.item_id = new System.Windows.Forms.ColumnHeader();
            this.item_name = new System.Windows.Forms.ColumnHeader();
            this.item_price = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.listView_cart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView_items, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1034, 565);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listView_cart
            // 
            this.listView_cart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView_cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_cart.FullRowSelect = true;
            this.listView_cart.HideSelection = false;
            this.listView_cart.Location = new System.Drawing.Point(778, 53);
            this.listView_cart.Name = "listView_cart";
            this.listView_cart.Size = new System.Drawing.Size(253, 309);
            this.listView_cart.TabIndex = 0;
            this.listView_cart.UseCompatibleStateImageBehavior = false;
            this.listView_cart.View = System.Windows.Forms.View.Details;
            this.listView_cart.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_cart_ItemSelectionChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "id";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Qty";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Subtotal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 44);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(86, 11);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(569, 23);
            this.textBox_search.TabIndex = 0;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_subtotal);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button_remove);
            this.panel2.Controls.Add(this.button_addToCart);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.textBox_qty);
            this.panel2.Controls.Add(this.button_minus);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(778, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 194);
            this.panel2.TabIndex = 3;
            // 
            // label_subtotal
            // 
            this.label_subtotal.AutoSize = true;
            this.label_subtotal.ForeColor = System.Drawing.Color.Gray;
            this.label_subtotal.Location = new System.Drawing.Point(134, 21);
            this.label_subtotal.Name = "label_subtotal";
            this.label_subtotal.Size = new System.Drawing.Size(28, 15);
            this.label_subtotal.TabIndex = 9;
            this.label_subtotal.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(15, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Subtotal: P";
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_remove.Enabled = false;
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_remove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_remove.ForeColor = System.Drawing.Color.White;
            this.button_remove.Location = new System.Drawing.Point(198, 69);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(41, 32);
            this.button_remove.TabIndex = 7;
            this.button_remove.Text = "X";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_addToCart
            // 
            this.button_addToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_addToCart.Enabled = false;
            this.button_addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addToCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_addToCart.ForeColor = System.Drawing.Color.White;
            this.button_addToCart.Location = new System.Drawing.Point(15, 70);
            this.button_addToCart.Name = "button_addToCart";
            this.button_addToCart.Size = new System.Drawing.Size(177, 32);
            this.button_addToCart.TabIndex = 6;
            this.button_addToCart.Text = "Add to Cart";
            this.button_addToCart.UseVisualStyleBackColor = false;
            this.button_addToCart.Click += new System.EventHandler(this.button_addToCart_Click);
            // 
            // button_add
            // 
            this.button_add.Enabled = false;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Location = new System.Drawing.Point(198, 40);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(41, 23);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_qty
            // 
            this.textBox_qty.Enabled = false;
            this.textBox_qty.Location = new System.Drawing.Point(62, 41);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(130, 23);
            this.textBox_qty.TabIndex = 4;
            this.textBox_qty.TextChanged += new System.EventHandler(this.textBox_qty_TextChanged);
            // 
            // button_minus
            // 
            this.button_minus.Enabled = false;
            this.button_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minus.Location = new System.Drawing.Point(15, 41);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(41, 23);
            this.button_minus.TabIndex = 3;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Finish Transaction";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label_total);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(778, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 44);
            this.panel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total: P";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(182, 22);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(28, 15);
            this.label_total.TabIndex = 1;
            this.label_total.Text = "0.00";
            // 
            // listView_items
            // 
            this.listView_items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item_id,
            this.item_name,
            this.item_price});
            this.listView_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_items.FullRowSelect = true;
            this.listView_items.HideSelection = false;
            this.listView_items.Location = new System.Drawing.Point(3, 53);
            this.listView_items.Name = "listView_items";
            this.tableLayoutPanel1.SetRowSpan(this.listView_items, 2);
            this.listView_items.Size = new System.Drawing.Size(769, 509);
            this.listView_items.TabIndex = 5;
            this.listView_items.UseCompatibleStateImageBehavior = false;
            this.listView_items.View = System.Windows.Forms.View.Details;
            this.listView_items.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_items_ItemSelectionChanged);
            // 
            // item_id
            // 
            this.item_id.Text = "ID";
            // 
            // item_name
            // 
            this.item_name.Text = "Name";
            this.item_name.Width = 400;
            // 
            // item_price
            // 
            this.item_price.Text = "Price";
            // 
            // NewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewTransaction";
            this.Size = new System.Drawing.Size(1034, 565);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView_cart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_addToCart;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_qty;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.ListView listView_items;
        private System.Windows.Forms.ColumnHeader item_id;
        private System.Windows.Forms.ColumnHeader item_name;
        private System.Windows.Forms.ColumnHeader item_price;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label_subtotal;
        private System.Windows.Forms.Label label6;
    }
}
