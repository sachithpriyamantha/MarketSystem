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
    public partial class Seller : Form
    {
        DBConnect dbCon = new DBConnect();
        public Seller()
        {
            InitializeComponent();
        }
        private void getTable()
        {
            string selectQuery = "SELECT * FROM SellerTable";
            SqlCommand command = new SqlCommand(selectQuery, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SellerDGV.DataSource = table;
        }
        private void clear()
        {
            IDTb.Clear();
            NameTb.Clear();
            AgeTb.Clear();
            MobTb.Clear();
            PasswordTb.Clear();
        }
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO SellerTable VALUES(" + IDTb.Text + ",'" + NameTb.Text + "'," + AgeTb.Text + "," + MobTb.Text + ",'" + PasswordTb.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dbCon.GetCon());
                dbCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Seller_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDTb.Text == "" || NameTb.Text == "" || AgeTb.Text == "" || MobTb.Text == ""||PasswordTb.Text=="")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE SellerTable SET SellerName='" + NameTb + "',SellerAge='" + AgeTb + "',SellerPhone='" + MobTb + "',SellerPassword='" + PasswordTb + "'WHERE SellerID=" + IDTb.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dbCon.GetCon());
                    dbCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Seller Updated", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellerDGV_Click(object sender, EventArgs e)
        {
            IDTb.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            NameTb.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            AgeTb.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            MobTb.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            PasswordTb.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDTb.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = "DELETE FROM SellerTable WHERE SellerID=" + IDTb.Text + "";
                    SqlCommand command = new SqlCommand(deleteQuery, dbCon.GetCon());
                    dbCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutBtn_MouseEnter(object sender, EventArgs e)
        {
            LogoutBtn.ForeColor = Color.Red;
        }

        private void LogoutBtn_MouseLeave(object sender, EventArgs e)
        {
            LogoutBtn.ForeColor = Color.White;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            Product item = new Product();
            item.Show();
            this.Hide();
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            Category type = new Category();
            type.Show();
            this.Hide();
        }
    }
}
