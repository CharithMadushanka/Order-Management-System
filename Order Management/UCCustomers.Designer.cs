namespace Order_Management
{
    partial class UCCustomers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCustomers));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_customers = new System.Windows.Forms.DataGridView();
            this.btn_cus_delete = new System.Windows.Forms.Button();
            this.txt_search_cus = new MetroFramework.Controls.MetroTextBox();
            this.btn_search_cus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Details";
            // 
            // dataGrid_customers
            // 
            this.dataGrid_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_customers.Location = new System.Drawing.Point(75, 150);
            this.dataGrid_customers.Name = "dataGrid_customers";
            this.dataGrid_customers.Size = new System.Drawing.Size(600, 225);
            this.dataGrid_customers.TabIndex = 2;
            // 
            // btn_cus_delete
            // 
            this.btn_cus_delete.BackColor = System.Drawing.Color.Teal;
            this.btn_cus_delete.FlatAppearance.BorderSize = 0;
            this.btn_cus_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cus_delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cus_delete.ForeColor = System.Drawing.Color.White;
            this.btn_cus_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_cus_delete.Image")));
            this.btn_cus_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cus_delete.Location = new System.Drawing.Point(100, 400);
            this.btn_cus_delete.Name = "btn_cus_delete";
            this.btn_cus_delete.Size = new System.Drawing.Size(150, 30);
            this.btn_cus_delete.TabIndex = 15;
            this.btn_cus_delete.Text = "      Delete";
            this.btn_cus_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cus_delete.UseVisualStyleBackColor = false;
            this.btn_cus_delete.Click += new System.EventHandler(this.btn_cus_delete_Click);
            // 
            // txt_search_cus
            // 
            // 
            // 
            // 
            this.txt_search_cus.CustomButton.Image = null;
            this.txt_search_cus.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txt_search_cus.CustomButton.Name = "";
            this.txt_search_cus.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_search_cus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search_cus.CustomButton.TabIndex = 1;
            this.txt_search_cus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search_cus.CustomButton.UseSelectable = true;
            this.txt_search_cus.CustomButton.Visible = false;
            this.txt_search_cus.Lines = new string[0];
            this.txt_search_cus.Location = new System.Drawing.Point(79, 100);
            this.txt_search_cus.MaxLength = 32767;
            this.txt_search_cus.Name = "txt_search_cus";
            this.txt_search_cus.PasswordChar = '\0';
            this.txt_search_cus.PromptText = "Search By First Name";
            this.txt_search_cus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search_cus.SelectedText = "";
            this.txt_search_cus.SelectionLength = 0;
            this.txt_search_cus.SelectionStart = 0;
            this.txt_search_cus.ShortcutsEnabled = true;
            this.txt_search_cus.Size = new System.Drawing.Size(225, 25);
            this.txt_search_cus.TabIndex = 16;
            this.txt_search_cus.UseSelectable = true;
            this.txt_search_cus.WaterMark = "Search By First Name";
            this.txt_search_cus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search_cus.WaterMarkFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_search_cus
            // 
            this.btn_search_cus.BackColor = System.Drawing.Color.Teal;
            this.btn_search_cus.FlatAppearance.BorderSize = 0;
            this.btn_search_cus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_cus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_cus.ForeColor = System.Drawing.Color.White;
            this.btn_search_cus.Image = ((System.Drawing.Image)(resources.GetObject("btn_search_cus.Image")));
            this.btn_search_cus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search_cus.Location = new System.Drawing.Point(350, 100);
            this.btn_search_cus.Name = "btn_search_cus";
            this.btn_search_cus.Size = new System.Drawing.Size(140, 25);
            this.btn_search_cus.TabIndex = 17;
            this.btn_search_cus.Text = "       Search";
            this.btn_search_cus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_search_cus.UseVisualStyleBackColor = false;
            this.btn_search_cus.Click += new System.EventHandler(this.btn_search_cus_Click);
            // 
            // UCCustomers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btn_search_cus);
            this.Controls.Add(this.txt_search_cus);
            this.Controls.Add(this.btn_cus_delete);
            this.Controls.Add(this.dataGrid_customers);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCCustomers";
            this.Size = new System.Drawing.Size(756, 504);
            this.Load += new System.EventHandler(this.UCCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_customers;
        private System.Windows.Forms.Button btn_cus_delete;
        private MetroFramework.Controls.MetroTextBox txt_search_cus;
        private System.Windows.Forms.Button btn_search_cus;
    }
}
