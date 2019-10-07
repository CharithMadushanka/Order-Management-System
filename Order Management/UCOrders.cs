using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Data.SqlClient;

namespace Order_Management
{
    public partial class UCOrders : UserControl
    {
        public UCOrders()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;

        private void UCOrders_Load(object sender, EventArgs e)
        {
            
        }

        public void loadData()
        {
            con = new SqlConnection("Data Source=NAWAM-T046-LAP;Initial Catalog=Order Management;Integrated Security=True");

            try
            {
                con.Open();
                da = new SqlDataAdapter("select * from Orders", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                dataGrid_orders.DataSource = dt;
            }
            catch (SqlException)
            {
                MetroMessageBox.Show(this, "Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try            {                DialogResult dr = MessageBox.Show("Do you really want to Delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);                if (dr.ToString() == "Yes")                {                    con.Open();                    SqlCommand cmd = new SqlCommand("delete from Orders where customer_name= '" + dataGrid_orders.CurrentRow.Cells["customer_name"].Value.ToString() + "'", con);                    int i = cmd.ExecuteNonQuery();                    if (i == 1)
                    {
                        MessageBox.Show("Data Delete Successfully", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }                    else                    {
                        MessageBox.Show("Data Cannot Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    con.Close();                }            }            catch (SqlException)            {                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            }            catch (Exception)            {                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            }
        }

        private void btn_search_ord_Click(object sender, EventArgs e)
        {
            if(txt_search_ord.Text.Length > 0)
            {
                con.Open();
                da = new SqlDataAdapter("select * from Orders where customer_name like '" + txt_search_ord.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                dataGrid_orders.DataSource = dt;
            }
        }
    }
}
