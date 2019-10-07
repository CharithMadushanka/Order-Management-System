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

namespace Order_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = btn_home.Height;
            ucHome1.BringToFront();
            ucHome1.startTimer();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_home.Height;
            sidePanel.Top = btn_home.Top;
            ucHome1.BringToFront();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_create.Height;
            sidePanel.Top = btn_create.Top;
            ucCreate1.BringToFront();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_orders.Height;
            sidePanel.Top = btn_orders.Top;
            ucOrders1.BringToFront();

            ucOrders1.loadData();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_customers.Height;
            sidePanel.Top = btn_customers.Top;
            ucCustomers1.BringToFront();

            ucCustomers1.loadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
