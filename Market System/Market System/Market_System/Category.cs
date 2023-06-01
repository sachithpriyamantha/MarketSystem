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
    public partial class Category : Form
    {
        DBConnect dbCon = new DBConnect();
        public Category()
        {
            InitializeComponent();
        }
        private void getTable()
        {
            string selectQuery = "SELECT * FROM CategoryTable";
            SqlCommand command = new SqlCommand(selectQuery, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CategoryDGV.DataSource = table;
        }
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO CategoryTable VALUES(" + IDTb.Text + ",'" + NameTb.Text + "','" + DescTb.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery,dbCon.GetCon());
                dbCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Added", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDTb.Text == "" || NameTb.Text == "" || DescTb.Text == "")
                {
                    MessageBox.Show("Missing Information","Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE CategoryTable SET TypeName='" + NameTb.Text + "', TypeDesc='" + DescTb.Text + "'WHERE TypeID=" + IDTb.Text + " ";
                    SqlCommand command = new SqlCommand(updateQuery, dbCon.GetCon());
                    dbCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Updated", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryDGV_Click(object sender, EventArgs e)
        {
            IDTb.Text = CategoryDGV.SelectedRows[0].Cells[0].Value.ToString();
            NameTb.Text = CategoryDGV.SelectedRows[0].Cells[1].Value.ToString();
            DescTb.Text = CategoryDGV.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void clear()
        {
            IDTb.Clear();
            NameTb.Clear();
            DescTb.Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery="DELETE FROM CategoryTable WHERE TypeID="+IDTb.Text+"";
                SqlCommand command = new SqlCommand(deleteQuery, dbCon.GetCon());
                dbCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Category Deleted", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbCon.CloseCon();
                getTable();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
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

        private void SellerBtn_Click(object sender, EventArgs e)
        {
            Seller sell = new Seller();
            sell.Show();
            this.Hide();
        }
    }
}
