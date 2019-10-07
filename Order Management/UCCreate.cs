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

using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace Order_Management
{
    public partial class UCCreate : UserControl
    {
        public UCCreate()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void btn_create_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=NAWAM-T046-LAP;Initial Catalog=Order Management;Integrated Security=True");

            try
            {
                if(cmb_title.SelectedItem == null)
                {
                    MessageBox.Show("Title cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(string.IsNullOrEmpty(txt_fname.Text))
                {
                    MessageBox.Show("First Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(txt_fname.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("First Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(string.IsNullOrEmpty(txt_lname.Text))
                {
                    MessageBox.Show("Last Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(txt_lname.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Last Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_phone.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Phone No cannot have letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(txt_phone.TextLength != 10)
                {
                    MessageBox.Show("Phone No must have 10 numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(string.IsNullOrEmpty(txt_email.Text))
                {
                    MessageBox.Show("Email cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txt_address.Text))
                {
                    MessageBox.Show("Address cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmb_item.SelectedItem == null)
                {
                    MessageBox.Show("Item cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmb_quantity.SelectedItem == null)
                {
                    MessageBox.Show("Quantity cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    SqlCommand cmdOrder = new SqlCommand("Insert into Orders values ('" + txt_fname.Text + "','" + txt_phone.Text + "','" + txt_address.Text + "','" + dateTimePicker1.Value + "','" + cmb_item.SelectedItem + "','" + cmb_quantity.SelectedItem + "')", con);
                    cmdOrder.ExecuteNonQuery();
                    con.Close();
                    cmdOrder.Dispose();

                    con.Open();
                    SqlCommand cmdCustomer = new SqlCommand("Insert into Customers values ('" + cmb_title.SelectedItem + "','" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_phone.Text + "','" + txt_email.Text + "')", con);
                    cmdCustomer.ExecuteNonQuery();
                    con.Close();
                    cmdCustomer.Dispose();

                    Execute(txt_email.Text,txt_fname.Text);
                    MessageBox.Show("Order has been created successfully", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_title.ResetText();
            txt_fname.Clear();
            txt_lname.Clear();
            txt_phone.Clear();
            txt_email.Clear();
            txt_address.Clear();
            dateTimePicker1.ResetText();
            cmb_item.ResetText();
            cmb_quantity.ResetText();
        }

        static async Task Execute(string receiver,string name)
        {
            //var apiKey = Environment.GetEnvironmentVariable("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");
            var client = new SendGridClient("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");
            var from = new EmailAddress("info@restaurantpronto.com", "Restaurant Pronto");
            var subject = "Order Received";
            var to = new EmailAddress(receiver, name);
            var plainTextContent = $"Hi {name}, your order has been received.Thank you for ordering with Restaurant Pronto. Call 0112729729 for Inquries.";
            var htmlContent = $"<strong>Hi {name}, your order has been received.Thank you for ordering with Restaurant Pronto. Call 0112729729 for Inquries.</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
