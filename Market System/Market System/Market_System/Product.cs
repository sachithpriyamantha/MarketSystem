using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Market_System
{
    public partial class Product : Form
    {
        DBConnect dbCon = new DBConnect();
        public Product()
        {
            InitializeComponent();
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            Category type = new Category();
            type.Show();
            this.Hide();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            GetCategory();
            getTable();
        }
        private void GetCategory()
        {
            string selectQuery = "SELECT * FROM CategoryTable";
            SqlCommand command = new SqlCommand(selectQuery, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CategoryCb.DataSource = table;
            CategoryCb.ValueMember= "TypeName";
            TypeCb.DataSource = table;
            TypeCb.ValueMember = "TypeName";
        }
        private void getTable()
        {
            string selectQuery = "SELECT * FROM ProductTable";
            SqlCommand command = new SqlCommand(selectQuery, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            ProductDGV.DataSource = table;
        }
        private void clear()
        {
            IDTb.Clear();
            NameTb.Clear();
            PriceTb.Clear();
            QtyTb.Clear();
            CategoryCb.SelectedIndex = 0;
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO ProductTable VALUES(" + IDTb.Text + ",'" + NameTb.Text + "'," + PriceTb.Text + "," + QtyTb.Text + ",'" + CategoryCb.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dbCon.GetCon());
                dbCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbCon.CloseCon();
                getTable();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDTb.Text == "" || NameTb.Text == "" || PriceTb.Text == ""||QtyTb.Text=="")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE ProductTable SET ProductName='" + NameTb.Text + "',ProductPrice=" + PriceTb.Text + ",ProductQty=" + QtyTb.Text + ",ProductType='" + CategoryCb.Text + "'WHERE ProductID=" + IDTb.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dbCon.GetCon());
                    dbCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Updated", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ProductDGV_Click(object sender, EventArgs e)
        {
            IDTb.Text = ProductDGV.SelectedRows[0].Cells[0].Value.ToString();
            NameTb.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            QtyTb.Text = ProductDGV.SelectedRows[0].Cells[3].Value.ToString();
            CategoryCb.SelectedValue = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
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
                    string deleteQuery = "DELETE FROM ProductTable WHERE ProductID="+IDTb.Text+"";
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

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void TypeCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM ProductTable WHERE ProductType='"+TypeCb.SelectedValue.ToString()+"'";
            SqlCommand command = new SqlCommand(selectQuery, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            ProductDGV.DataSource = table;
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
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

        private void SellerBtn_Click(object sender, EventArgs e)
        {
            Seller sell = new Seller();
            sell.Show();
            this.Hide();
        }
    }
}
