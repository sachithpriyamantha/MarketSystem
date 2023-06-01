using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Market_System
{
    public partial class LoginForm : Form
    {
        DBConnect dbCon = new DBConnect();
        public static string SellerName;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.White;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            UnameTb.Clear();
            PasswordTb.Clear();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter User Name and Password","Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(SelectroleCb.SelectedIndex>-1)
                {
                    if (SelectroleCb.SelectedItem.ToString() == "ADMIN")
                    {
                        if (UnameTb.Text == "Admin" && PasswordTb.Text == "Admin12345")
                        {
                            Product item = new Product();
                            item.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Please enter the correct password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        string selectQuery = "SELECT * FROM SellerTable WHERE SellerName='" + UnameTb.Text + "' AND SellerPassword='" + PasswordTb.Text + "'";
                        SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dbCon.GetCon());
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            SellerName = UnameTb.Text;
                            Selling selling = new Selling();
                            selling.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Role", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SelectroleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
