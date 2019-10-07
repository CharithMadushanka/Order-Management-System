﻿using System;
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
    public partial class UCCustomers : UserControl
    {
        public UCCustomers()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;

        private void UCCustomers_Load(object sender, EventArgs e)
        {
            
        }

        public void loadData()
        {
            con = new SqlConnection("Data Source=NAWAM-T046-LAP;Initial Catalog=Order Management;Integrated Security=True");

            try
            {
                con.Open();
                da = new SqlDataAdapter("select * from Customers", con);                DataTable dt = new DataTable();                da.Fill(dt);                con.Close();                dataGrid_customers.DataSource = dt;
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

        private void btn_cus_delete_Click(object sender, EventArgs e)
        {
            try            {                DialogResult dr = MessageBox.Show("Do you really want to Delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);                if (dr.ToString() == "Yes")                {                    con.Open();                    SqlCommand cmd = new SqlCommand("delete from Customers where first_name= '" + dataGrid_customers.CurrentRow.Cells["first_name"].Value.ToString() + "'", con);                    int i = cmd.ExecuteNonQuery();                    if (i == 1)
                    {
                        MessageBox.Show("Data Delete Successfully", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }                    else                    {
                        MessageBox.Show("Data Cannot Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    con.Close();                }            }            catch (SqlException)            {                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            }            catch (Exception)            {                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            }
        }

        private void btn_search_cus_Click(object sender, EventArgs e)
        {
            if (txt_search_cus.Text.Length > 0)
            {
                con.Open();
                da = new SqlDataAdapter("select * from Customers where first_name like '" + txt_search_cus.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                dataGrid_customers.DataSource = dt;
            }
        }
    }
}
