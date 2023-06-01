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
    public partial class Selling : Form
    {
        DBConnect dbCon = new DBConnect();
        public Selling()
        {
            InitializeComponent();
        }
        private void GetCategory()
        {
            string selectQuery = "SELECT * FROM CategoryTable";
            SqlCommand command = new SqlCommand(selectQuery, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CategoryCb.DataSource = table;
            CategoryCb.ValueMember = "TypeName";
        }
        private void getTable()
        {
            string selectQuery = "SELECT ProductName,ProductPrice FROM ProductTable";
            SqlCommand command = new SqlCommand(selectQuery, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            ProductDGV.DataSource = table;
        }
        private void GetSellTable()
        {
            string selectQuery = "SELECT * FROM BillTable";
            SqlCommand command = new SqlCommand(selectQuery, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SalesDGV.DataSource = table;
        }
        private void Selling_Load(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Today.ToShortDateString();
            SellerLbl.Text = LoginForm.SellerName;
            GetCategory();
            getTable();
            GetSellTable();
        }

        private void ProductDGV_Click(object sender, EventArgs e)
        {
            NameTb.Text = ProductDGV.SelectedRows[0].Cells[0].Value.ToString();
            PriceTb.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        int grandTotal = 0, x = 0;

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO BillTable VALUES(" + BillidTb.Text + ",'" + SellerLbl.Text + "','" + DateLbl.Text + "'," + grandTotal.ToString() + ")";
                SqlCommand command = new SqlCommand(insertQuery, dbCon.GetCon());
                dbCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbCon.CloseCon();
                GetSellTable();
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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void CategoryCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuerry = "SELECT ProductName, ProductPrice FROM ProductTable WHERE ProductType='" + CategoryCb.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuerry, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            ProductDGV.DataSource = table;
        }

        private void AddorderBtn_Click(object sender, EventArgs e)
        {
            if(NameTb.Text==""||QtyTb.Text=="")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int Total = Convert.ToInt32(PriceTb.Text) * Convert.ToInt32(QtyTb.Text);
                DataGridViewRow addrow = new DataGridViewRow();
                addrow.CreateCells(OrderDGV);
                addrow.Cells[0].Value = ++x;
                addrow.Cells[1].Value = NameTb.Text;
                addrow.Cells[2].Value = PriceTb.Text;
                addrow.Cells[3].Value = QtyTb.Text;
                addrow.Cells[4].Value = Total;
                OrderDGV.Rows.Add(addrow);
                grandTotal += Total;
                RupeesLbl.Text = grandTotal + " Rupees";
            }
        }
    }
}
