
namespace Market_System
{
    partial class Seller
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SellerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MobTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.CategoryBtn = new System.Windows.Forms.Button();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AgeTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.SellingBtn = new System.Windows.Forms.Button();
            this.NameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordTb = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.FlatAppearance.BorderSize = 0;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Lucida Fax", 18F);
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(12, 517);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(121, 52);
            this.LogoutBtn.TabIndex = 24;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            this.LogoutBtn.MouseEnter += new System.EventHandler(this.LogoutBtn_MouseEnter);
            this.LogoutBtn.MouseLeave += new System.EventHandler(this.LogoutBtn_MouseLeave);
            // 
            // SellerDGV
            // 
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            this.SellerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.SellerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellerDGV.BackgroundColor = System.Drawing.Color.White;
            this.SellerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellerDGV.DefaultCellStyle = dataGridViewCellStyle39;
            this.SellerDGV.EnableHeadersVisualStyles = false;
            this.SellerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.Location = new System.Drawing.Point(307, 107);
            this.SellerDGV.Name = "SellerDGV";
            this.SellerDGV.RowHeadersVisible = false;
            this.SellerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellerDGV.Size = new System.Drawing.Size(503, 434);
            this.SellerDGV.TabIndex = 18;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SellerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SellerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SellerDGV.ThemeStyle.HeaderStyle.Height = 23;
            this.SellerDGV.ThemeStyle.ReadOnly = false;
            this.SellerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellerDGV.ThemeStyle.RowsStyle.Height = 22;
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellerDGV.Click += new System.EventHandler(this.SellerDGV_Click);
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
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mobile No";
            // 
            // MobTb
            // 
            this.MobTb.BorderRadius = 18;
            this.MobTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MobTb.DefaultText = "";
            this.MobTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MobTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MobTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MobTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MobTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MobTb.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.MobTb.ForeColor = System.Drawing.Color.Black;
            this.MobTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MobTb.Location = new System.Drawing.Point(108, 159);
            this.MobTb.Name = "MobTb";
            this.MobTb.PasswordChar = '\0';
            this.MobTb.PlaceholderText = "";
            this.MobTb.SelectedText = "";
            this.MobTb.Size = new System.Drawing.Size(178, 36);
            this.MobTb.TabIndex = 9;
            // 
            // CategoryBtn
            // 
            this.CategoryBtn.FlatAppearance.BorderSize = 0;
            this.CategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryBtn.Font = new System.Drawing.Font("Lucida Fax", 18F);
            this.CategoryBtn.ForeColor = System.Drawing.Color.White;
            this.CategoryBtn.Location = new System.Drawing.Point(12, 138);
            this.CategoryBtn.Name = "CategoryBtn";
            this.CategoryBtn.Size = new System.Drawing.Size(131, 52);
            this.CategoryBtn.TabIndex = 22;
            this.CategoryBtn.Text = "Category";
            this.CategoryBtn.UseVisualStyleBackColor = true;
            this.CategoryBtn.Click += new System.EventHandler(this.CategoryBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.FlatAppearance.BorderSize = 0;
            this.ProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductBtn.Font = new System.Drawing.Font("Lucida Fax", 18F);
            this.ProductBtn.ForeColor = System.Drawing.Color.White;
            this.ProductBtn.Location = new System.Drawing.Point(12, 70);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(121, 52);
            this.ProductBtn.TabIndex = 21;
            this.ProductBtn.Text = "Product";
            this.ProductBtn.UseVisualStyleBackColor = true;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.White;
            this.label_exit.Location = new System.Drawing.Point(973, -3);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(27, 30);
            this.label_exit.TabIndex = 20;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age";
            // 
            // AgeTb
            // 
            this.AgeTb.BorderRadius = 18;
            this.AgeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AgeTb.DefaultText = "";
            this.AgeTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AgeTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AgeTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AgeTb.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.AgeTb.ForeColor = System.Drawing.Color.Black;
            this.AgeTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AgeTb.Location = new System.Drawing.Point(108, 117);
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.PasswordChar = '\0';
            this.AgeTb.PlaceholderText = "";
            this.AgeTb.SelectedText = "";
            this.AgeTb.Size = new System.Drawing.Size(179, 36);
            this.AgeTb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 35);
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
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seller";
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
            this.IDTb.Location = new System.Drawing.Point(108, 35);
            this.IDTb.Name = "IDTb";
            this.IDTb.PasswordChar = '\0';
            this.IDTb.PlaceholderText = "";
            this.IDTb.SelectedText = "";
            this.IDTb.Size = new System.Drawing.Size(178, 36);
            this.IDTb.TabIndex = 2;
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
            this.SellingBtn.TabIndex = 23;
            this.SellingBtn.Text = "Sellings";
            this.SellingBtn.UseVisualStyleBackColor = true;
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
            this.NameTb.Location = new System.Drawing.Point(108, 75);
            this.NameTb.Name = "NameTb";
            this.NameTb.PasswordChar = '\0';
            this.NameTb.PlaceholderText = "";
            this.NameTb.SelectedText = "";
            this.NameTb.Size = new System.Drawing.Size(178, 36);
            this.NameTb.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.PasswordTb);
            this.panel1.Controls.Add(this.SellerDGV);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.InsertBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.MobTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AgeTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NameTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IDTb);
            this.panel1.Location = new System.Drawing.Point(175, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 546);
            this.panel1.TabIndex = 19;
            // 
            // PasswordTb
            // 
            this.PasswordTb.BorderRadius = 18;
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.DefaultText = "";
            this.PasswordTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTb.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.PasswordTb.ForeColor = System.Drawing.Color.Black;
            this.PasswordTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTb.Location = new System.Drawing.Point(108, 203);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '●';
            this.PasswordTb.PlaceholderText = "";
            this.PasswordTb.SelectedText = "";
            this.PasswordTb.Size = new System.Drawing.Size(178, 36);
            this.PasswordTb.TabIndex = 19;
            this.PasswordTb.UseSystemPasswordChar = true;
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(997, 588);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.CategoryBtn);
            this.Controls.Add(this.ProductBtn);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.SellingBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seller";
            this.Load += new System.EventHandler(this.Seller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutBtn;
        private Guna.UI2.WinForms.Guna2DataGridView SellerDGV;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox MobTb;
        private System.Windows.Forms.Button CategoryBtn;
        private System.Windows.Forms.Button ProductBtn;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox AgeTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox IDTb;
        private System.Windows.Forms.Button SellingBtn;
        private Guna.UI2.WinForms.Guna2TextBox NameTb;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTb;
    }
}