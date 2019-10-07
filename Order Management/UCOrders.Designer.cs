namespace Order_Management
{
    partial class UCOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOrders));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGrid_orders = new System.Windows.Forms.DataGridView();
            this.txt_search_ord = new MetroFramework.Controls.MetroTextBox();
            this.btn_search_ord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Orders";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Teal;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(100, 400);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 30);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "      Delete";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dataGrid_orders
            // 
            this.dataGrid_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_orders.Location = new System.Drawing.Point(75, 150);
            this.dataGrid_orders.Name = "dataGrid_orders";
            this.dataGrid_orders.Size = new System.Drawing.Size(600, 225);
            this.dataGrid_orders.TabIndex = 16;
            // 
            // txt_search_ord
            // 
            // 
            // 
            // 
            this.txt_search_ord.CustomButton.Image = null;
            this.txt_search_ord.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txt_search_ord.CustomButton.Name = "";
            this.txt_search_ord.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_search_ord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search_ord.CustomButton.TabIndex = 1;
            this.txt_search_ord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search_ord.CustomButton.UseSelectable = true;
            this.txt_search_ord.CustomButton.Visible = false;
            this.txt_search_ord.Lines = new string[0];
            this.txt_search_ord.Location = new System.Drawing.Point(79, 100);
            this.txt_search_ord.MaxLength = 32767;
            this.txt_search_ord.Name = "txt_search_ord";
            this.txt_search_ord.PasswordChar = '\0';
            this.txt_search_ord.PromptText = "Search By Name";
            this.txt_search_ord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search_ord.SelectedText = "";
            this.txt_search_ord.SelectionLength = 0;
            this.txt_search_ord.SelectionStart = 0;
            this.txt_search_ord.ShortcutsEnabled = true;
            this.txt_search_ord.Size = new System.Drawing.Size(225, 25);
            this.txt_search_ord.TabIndex = 17;
            this.txt_search_ord.UseSelectable = true;
            this.txt_search_ord.WaterMark = "Search By Name";
            this.txt_search_ord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search_ord.WaterMarkFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_search_ord
            // 
            this.btn_search_ord.BackColor = System.Drawing.Color.Teal;
            this.btn_search_ord.FlatAppearance.BorderSize = 0;
            this.btn_search_ord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_ord.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_ord.ForeColor = System.Drawing.Color.White;
            this.btn_search_ord.Image = ((System.Drawing.Image)(resources.GetObject("btn_search_ord.Image")));
            this.btn_search_ord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search_ord.Location = new System.Drawing.Point(350, 100);
            this.btn_search_ord.Name = "btn_search_ord";
            this.btn_search_ord.Size = new System.Drawing.Size(140, 25);
            this.btn_search_ord.TabIndex = 18;
            this.btn_search_ord.Text = "       Search";
            this.btn_search_ord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_search_ord.UseVisualStyleBackColor = false;
            this.btn_search_ord.Click += new System.EventHandler(this.btn_search_ord_Click);
            // 
            // UCOrders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btn_search_ord);
            this.Controls.Add(this.txt_search_ord);
            this.Controls.Add(this.dataGrid_orders);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCOrders";
            this.Size = new System.Drawing.Size(756, 504);
            this.Load += new System.EventHandler(this.UCOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGrid_orders;
        private MetroFramework.Controls.MetroTextBox txt_search_ord;
        private System.Windows.Forms.Button btn_search_ord;
    }
}
