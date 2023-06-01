
namespace Market_System
{
    partial class Product
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ProductDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TypeCb = new System.Windows.Forms.ComboBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.QtyTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_exit = new System.Windows.Forms.Label();
            this.SellerBtn = new System.Windows.Forms.Button();
            this.CategoryBtn = new System.Windows.Forms.Button();
            this.SellingBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.ProductDGV);
            this.panel1.Controls.Add(this.TypeCb);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.InsertBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CategoryCb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.QtyTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PriceTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NameTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IDTb);
            this.panel1.Location = new System.Drawing.Point(175, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 546);
            this.panel1.TabIndex = 0;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Location = new System.Drawing.Point(651, 53);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(121, 46);
            this.RefreshBtn.TabIndex = 19;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ProductDGV
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.ProductDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.ProductDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.ProductDGV.EnableHeadersVisualStyles = false;
            this.ProductDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV.Location = new System.Drawing.Point(307, 108);
            this.ProductDGV.Name = "ProductDGV";
            this.ProductDGV.RowHeadersVisible = false;
            this.ProductDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDGV.Size = new System.Drawing.Size(503, 434);
            this.ProductDGV.TabIndex = 18;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductDGV.ThemeStyle.HeaderStyle.Height = 23;
            this.ProductDGV.ThemeStyle.ReadOnly = false;
            this.ProductDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ProductDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductDGV.Click += new System.EventHandler(this.ProductDGV_Click);
            // 
            // TypeCb
            // 
            this.TypeCb.FormattingEnabled = true;
            this.TypeCb.Location = new System.Drawing.Point(481, 70);
            this.TypeCb.Name = "TypeCb";
            this.TypeCb.Size = new System.Drawing.Size(141, 21);
            this.TypeCb.TabIndex = 16;
            this.TypeCb.Text = "Select Category";
            this.TypeCb.SelectionChangeCommitted += new System.EventHandler(this.TypeCb_SelectionChangeCommitted);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Black;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(31, 425);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(80, 34);
            this.DeleteBtn.TabIndex = 15;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Black;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(31, 370);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(80, 34);
            this.UpdateBtn.TabIndex = 14;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.Black;
            this.InsertBtn.FlatAppearance.BorderSize = 0;
            this.InsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertBtn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.ForeColor = System.Drawing.Color.White;
            this.InsertBtn.Location = new System.Drawing.Point(31, 319);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(80, 34);
            this.InsertBtn.TabIndex = 13;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(13, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Category";
            // 
            // CategoryCb
            // 
            this.CategoryCb.FormattingEnabled = true;
            this.CategoryCb.Location = new System.Drawing.Point(108, 208);
            this.CategoryCb.Name = "CategoryCb";
            this.CategoryCb.Size = new System.Drawing.Size(195, 21);
            this.CategoryCb.TabIndex = 11;
            this.CategoryCb.Text = "Select Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(13, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // QtyTb
            // 
            this.QtyTb.BorderRadius = 18;
            this.QtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyTb.DefaultText = "";
            this.QtyTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QtyTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QtyTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyTb.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.QtyTb.ForeColor = System.Drawing.Color.Black;
            this.QtyTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyTb.Location = new System.Drawing.Point(103, 159);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.PasswordChar = '\0';
            this.QtyTb.PlaceholderText = "";
            this.QtyTb.SelectedText = "";
            this.QtyTb.Size = new System.Drawing.Size(200, 36);
            this.QtyTb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // PriceTb
            // 
            this.PriceTb.BorderRadius = 18;
            this.PriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTb.DefaultText = "";
            this.PriceTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTb.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.PriceTb.ForeColor = System.Drawing.Color.Black;
            this.PriceTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTb.Location = new System.Drawing.Point(103, 117);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.PasswordChar = '\0';
            this.PriceTb.PlaceholderText = "";
            this.PriceTb.SelectedText = "";
            this.PriceTb.Size = new System.Drawing.Size(200, 36);
            this.PriceTb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // NameTb
            // 
            this.NameTb.BorderRadius = 18;
            this.NameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTb.DefaultText = "";
            this.NameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTb.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.NameTb.ForeColor = System.Drawing.Color.Black;
            this.NameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTb.Location = new System.Drawing.Point(103, 75);
            this.NameTb.Name = "NameTb";
            this.NameTb.PasswordChar = '\0';
            this.NameTb.PlaceholderText = "";
            this.NameTb.SelectedText = "";
            this.NameTb.Size = new System.Drawing.Size(200, 36);
            this.NameTb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.label1.Location = new System.Drawing.Point(338, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Products";
            // 
            // IDTb
            // 
            this.IDTb.BorderRadius = 18;
            this.IDTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTb.DefaultText = "";
            this.IDTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTb.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.IDTb.ForeColor = System.Drawing.Color.Black;
            this.IDTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTb.Location = new System.Drawing.Point(103, 35);
            this.IDTb.Name = "IDTb";
            this.IDTb.PasswordChar = '\0';
            this.IDTb.PlaceholderText = "";
            this.IDTb.SelectedText = "";
            this.IDTb.Size = new System.Drawing.Size(200, 36);
            this.IDTb.TabIndex = 2;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.White;
            this.label_exit.Location = new System.Drawing.Point(973, -3);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(27, 30);
            this.label_exit.TabIndex = 14;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // SellerBtn
            // 
            this.SellerBtn.FlatAppearance.BorderSize = 0;
            this.SellerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerBtn.Font = new System.Drawing.Font("Lucida Fax", 18F);
            this.SellerBtn.ForeColor = System.Drawing.Color.White;
            this.SellerBtn.Location = new System.Drawing.Point(12, 74);
            this.SellerBtn.Name = "SellerBtn";
            this.SellerBtn.Size = new System.Drawing.Size(121, 52);
            this.SellerBtn.TabIndex = 15;
            this.SellerBtn.Text = "Seller";
            this.SellerBtn.UseVisualStyleBackColor = true;
            this.SellerBtn.Click += new System.EventHandler(this.SellerBtn_Click);
            // 
            // CategoryBtn
            // 
            this.CategoryBtn.FlatAppearance.BorderSize = 0;
            this.CategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryBtn.Font = new System.Drawing.Font("Lucida Fax", 18F);
            this.CategoryBtn.ForeColor = System.Drawing.Color.White;
            this.CategoryBtn.Location = new System.Drawing.Point(12, 139);
            this.CategoryBtn.Name = "CategoryBtn";
            this.CategoryBtn.Size = new System.Drawing.Size(144, 52);
            this.CategoryBtn.TabIndex = 16;
            this.CategoryBtn.Text = "Category";
            this.CategoryBtn.UseVisualStyleBackColor = true;
            this.CategoryBtn.Click += new System.EventHandler(this.CategoryBtn_Click);
            // 
            // SellingBtn
            // 
            this.SellingBtn.FlatAppearance.BorderSize = 0;
            this.SellingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellingBtn.Font = new System.Drawing.Font("Lucida Fax", 18F);
            this.SellingBtn.ForeColor = System.Drawing.Color.White;
            this.SellingBtn.Location = new System.Drawing.Point(12, 210);
            this.SellingBtn.Name = "SellingBtn";
            this.SellingBtn.Size = new System.Drawing.Size(121, 52);
            this.SellingBtn.TabIndex = 17;
            this.SellingBtn.Text = "Sellings";
            this.SellingBtn.UseVisualStyleBackColor = true;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(12, 521);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(121, 52);
            this.LogoutBtn.TabIndex = 18;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            this.LogoutBtn.MouseEnter += new System.EventHandler(this.LogoutBtn_MouseEnter);
            this.LogoutBtn.MouseLeave += new System.EventHandler(this.LogoutBtn_MouseLeave);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(997, 588);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.SellingBtn);
            this.Controls.Add(this.CategoryBtn);
            this.Controls.Add(this.SellerBtn);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.ComboBox TypeCb;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CategoryCb;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox QtyTb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox PriceTb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox NameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox IDTb;
        private System.Windows.Forms.Button SellerBtn;
        private System.Windows.Forms.Button CategoryBtn;
        private System.Windows.Forms.Button SellingBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private Guna.UI2.WinForms.Guna2DataGridView ProductDGV;
    }
}