namespace Inventory_Management_System
{
    partial class ManageProducts
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductidTb = new System.Windows.Forms.TextBox();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.DescriptionTb = new System.Windows.Forms.TextBox();
            this.CategoryidTb = new System.Windows.Forms.TextBox();
            this.SupplierTb = new System.Windows.Forms.TextBox();
            this.MeasureTb = new System.Windows.Forms.TextBox();
            this.StockTb = new System.Windows.Forms.TextBox();
            this.PurchaseTb = new System.Windows.Forms.TextBox();
            this.SellingTb = new System.Windows.Forms.TextBox();
            this.MinStockTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProductsGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 100);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1173, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(679, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Products";
            // 
            // ProductidTb
            // 
            this.ProductidTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductidTb.ForeColor = System.Drawing.Color.Crimson;
            this.ProductidTb.Location = new System.Drawing.Point(12, 121);
            this.ProductidTb.Name = "ProductidTb";
            this.ProductidTb.Size = new System.Drawing.Size(215, 37);
            this.ProductidTb.TabIndex = 7;
            this.ProductidTb.Text = "Productid";
            // 
            // NameTb
            // 
            this.NameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTb.ForeColor = System.Drawing.Color.Crimson;
            this.NameTb.Location = new System.Drawing.Point(12, 176);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(215, 37);
            this.NameTb.TabIndex = 8;
            this.NameTb.Text = "name";
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTb.ForeColor = System.Drawing.Color.Crimson;
            this.DescriptionTb.Location = new System.Drawing.Point(12, 230);
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(215, 37);
            this.DescriptionTb.TabIndex = 9;
            this.DescriptionTb.Text = "Description";
            // 
            // CategoryidTb
            // 
            this.CategoryidTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryidTb.ForeColor = System.Drawing.Color.Crimson;
            this.CategoryidTb.Location = new System.Drawing.Point(12, 291);
            this.CategoryidTb.Name = "CategoryidTb";
            this.CategoryidTb.Size = new System.Drawing.Size(215, 37);
            this.CategoryidTb.TabIndex = 10;
            this.CategoryidTb.Text = "Categoryid";
            this.CategoryidTb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SupplierTb
            // 
            this.SupplierTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierTb.ForeColor = System.Drawing.Color.Crimson;
            this.SupplierTb.Location = new System.Drawing.Point(12, 396);
            this.SupplierTb.Name = "SupplierTb";
            this.SupplierTb.Size = new System.Drawing.Size(215, 37);
            this.SupplierTb.TabIndex = 11;
            this.SupplierTb.Text = "Supplierid";
            // 
            // MeasureTb
            // 
            this.MeasureTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeasureTb.ForeColor = System.Drawing.Color.Crimson;
            this.MeasureTb.Location = new System.Drawing.Point(12, 343);
            this.MeasureTb.Name = "MeasureTb";
            this.MeasureTb.Size = new System.Drawing.Size(215, 37);
            this.MeasureTb.TabIndex = 12;
            this.MeasureTb.Text = "Unit of Measure";
            // 
            // StockTb
            // 
            this.StockTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTb.ForeColor = System.Drawing.Color.Crimson;
            this.StockTb.Location = new System.Drawing.Point(12, 452);
            this.StockTb.Name = "StockTb";
            this.StockTb.Size = new System.Drawing.Size(235, 37);
            this.StockTb.TabIndex = 13;
            this.StockTb.Text = "InitialStockQuantity";
            this.StockTb.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // PurchaseTb
            // 
            this.PurchaseTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseTb.ForeColor = System.Drawing.Color.Crimson;
            this.PurchaseTb.Location = new System.Drawing.Point(12, 505);
            this.PurchaseTb.Name = "PurchaseTb";
            this.PurchaseTb.Size = new System.Drawing.Size(215, 37);
            this.PurchaseTb.TabIndex = 14;
            this.PurchaseTb.Text = "PurchasePrice";
            // 
            // SellingTb
            // 
            this.SellingTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingTb.ForeColor = System.Drawing.Color.Crimson;
            this.SellingTb.Location = new System.Drawing.Point(12, 560);
            this.SellingTb.Name = "SellingTb";
            this.SellingTb.Size = new System.Drawing.Size(215, 37);
            this.SellingTb.TabIndex = 15;
            this.SellingTb.Text = "Selling Price";
            // 
            // MinStockTb
            // 
            this.MinStockTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinStockTb.ForeColor = System.Drawing.Color.Crimson;
            this.MinStockTb.Location = new System.Drawing.Point(12, 614);
            this.MinStockTb.Name = "MinStockTb";
            this.MinStockTb.Size = new System.Drawing.Size(252, 37);
            this.MinStockTb.TabIndex = 16;
            this.MinStockTb.Text = "MinimumStockLevel";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(187, 670);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 55);
            this.button2.TabIndex = 20;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(113, 742);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 55);
            this.button3.TabIndex = 21;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ProductsGV
            // 
            this.ProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGV.Location = new System.Drawing.Point(449, 170);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.RowHeadersWidth = 62;
            this.ProductsGV.RowTemplate.Height = 28;
            this.ProductsGV.Size = new System.Drawing.Size(797, 427);
            this.ProductsGV.TabIndex = 22;
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(662, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 39);
            this.label4.TabIndex = 23;
            this.label4.Text = "PRODUCTS LIST";
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 809);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MinStockTb);
            this.Controls.Add(this.SellingTb);
            this.Controls.Add(this.PurchaseTb);
            this.Controls.Add(this.StockTb);
            this.Controls.Add(this.MeasureTb);
            this.Controls.Add(this.SupplierTb);
            this.Controls.Add(this.CategoryidTb);
            this.Controls.Add(this.DescriptionTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.ProductidTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductidTb;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.TextBox DescriptionTb;
        private System.Windows.Forms.TextBox CategoryidTb;
        private System.Windows.Forms.TextBox SupplierTb;
        private System.Windows.Forms.TextBox MeasureTb;
        private System.Windows.Forms.TextBox StockTb;
        private System.Windows.Forms.TextBox PurchaseTb;
        private System.Windows.Forms.TextBox SellingTb;
        private System.Windows.Forms.TextBox MinStockTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView ProductsGV;
        private System.Windows.Forms.Label label4;
    }
}