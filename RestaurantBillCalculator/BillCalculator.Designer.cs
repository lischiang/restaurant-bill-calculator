namespace RestaurantBillCalculator
{
    partial class BillCalculator
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
            this.comboBoxBeverage = new System.Windows.Forms.ComboBox();
            this.comboBoxAppetizer = new System.Windows.Forms.ComboBox();
            this.comboBoxMainCourse = new System.Windows.Forms.ComboBox();
            this.comboBoxDessert = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblCurrency1 = new System.Windows.Forms.Label();
            this.lblCurrency2 = new System.Windows.Forms.Label();
            this.lblCurrency3 = new System.Windows.Forms.Label();
            this.lblBeverage = new System.Windows.Forms.Label();
            this.lblAppetizer = new System.Windows.Forms.Label();
            this.lblMainCourse = new System.Windows.Forms.Label();
            this.lblDessert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBeverage
            // 
            this.comboBoxBeverage.FormattingEnabled = true;
            this.comboBoxBeverage.Location = new System.Drawing.Point(28, 31);
            this.comboBoxBeverage.Name = "comboBoxBeverage";
            this.comboBoxBeverage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBeverage.TabIndex = 1;
            this.comboBoxBeverage.SelectedIndexChanged += new System.EventHandler(this.comboBoxBeverage_SelectedIndexChanged);
            // 
            // comboBoxAppetizer
            // 
            this.comboBoxAppetizer.FormattingEnabled = true;
            this.comboBoxAppetizer.Location = new System.Drawing.Point(183, 30);
            this.comboBoxAppetizer.Name = "comboBoxAppetizer";
            this.comboBoxAppetizer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAppetizer.TabIndex = 2;
            this.comboBoxAppetizer.SelectedIndexChanged += new System.EventHandler(this.comboBoxAppetizer_SelectedIndexChanged);
            // 
            // comboBoxMainCourse
            // 
            this.comboBoxMainCourse.FormattingEnabled = true;
            this.comboBoxMainCourse.Location = new System.Drawing.Point(339, 31);
            this.comboBoxMainCourse.Name = "comboBoxMainCourse";
            this.comboBoxMainCourse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMainCourse.TabIndex = 3;
            this.comboBoxMainCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainCourse_SelectedIndexChanged);
            // 
            // comboBoxDessert
            // 
            this.comboBoxDessert.FormattingEnabled = true;
            this.comboBoxDessert.Location = new System.Drawing.Point(498, 30);
            this.comboBoxDessert.Name = "comboBoxDessert";
            this.comboBoxDessert.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDessert.TabIndex = 4;
            this.comboBoxDessert.SelectedIndexChanged += new System.EventHandler(this.comboBoxDessert_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductCategory,
            this.ProductPrice,
            this.Quantity,
            this.ProductTotal});
            this.dataGridView1.Location = new System.Drawing.Point(28, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 187);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 200;
            // 
            // ProductCategory
            // 
            this.ProductCategory.HeaderText = "Product Category";
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            this.ProductCategory.Width = 200;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Product Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // ProductTotal
            // 
            this.ProductTotal.HeaderText = "Product Total";
            this.ProductTotal.Name = "ProductTotal";
            this.ProductTotal.ReadOnly = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(826, 155);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(124, 44);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(826, 227);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(124, 42);
            this.btnCheckOut.TabIndex = 7;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(826, 299);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 43);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(28, 377);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(28, 411);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 10;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(28, 448);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(128, 373);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 12;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.Enabled = false;
            this.txtTax.Location = new System.Drawing.Point(128, 408);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 13;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(128, 444);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCurrency1
            // 
            this.lblCurrency1.AutoSize = true;
            this.lblCurrency1.Location = new System.Drawing.Point(90, 376);
            this.lblCurrency1.Name = "lblCurrency1";
            this.lblCurrency1.Size = new System.Drawing.Size(35, 13);
            this.lblCurrency1.TabIndex = 15;
            this.lblCurrency1.Text = "CAD$";
            // 
            // lblCurrency2
            // 
            this.lblCurrency2.AutoSize = true;
            this.lblCurrency2.Location = new System.Drawing.Point(90, 411);
            this.lblCurrency2.Name = "lblCurrency2";
            this.lblCurrency2.Size = new System.Drawing.Size(35, 13);
            this.lblCurrency2.TabIndex = 16;
            this.lblCurrency2.Text = "CAD$";
            // 
            // lblCurrency3
            // 
            this.lblCurrency3.AutoSize = true;
            this.lblCurrency3.Location = new System.Drawing.Point(90, 447);
            this.lblCurrency3.Name = "lblCurrency3";
            this.lblCurrency3.Size = new System.Drawing.Size(35, 13);
            this.lblCurrency3.TabIndex = 17;
            this.lblCurrency3.Text = "CAD$";
            // 
            // lblBeverage
            // 
            this.lblBeverage.AutoSize = true;
            this.lblBeverage.Location = new System.Drawing.Point(28, 13);
            this.lblBeverage.Name = "lblBeverage";
            this.lblBeverage.Size = new System.Drawing.Size(53, 13);
            this.lblBeverage.TabIndex = 18;
            this.lblBeverage.Text = "Beverage";
            // 
            // lblAppetizer
            // 
            this.lblAppetizer.AutoSize = true;
            this.lblAppetizer.Location = new System.Drawing.Point(183, 13);
            this.lblAppetizer.Name = "lblAppetizer";
            this.lblAppetizer.Size = new System.Drawing.Size(51, 13);
            this.lblAppetizer.TabIndex = 19;
            this.lblAppetizer.Text = "Appetizer";
            // 
            // lblMainCourse
            // 
            this.lblMainCourse.AutoSize = true;
            this.lblMainCourse.Location = new System.Drawing.Point(336, 13);
            this.lblMainCourse.Name = "lblMainCourse";
            this.lblMainCourse.Size = new System.Drawing.Size(66, 13);
            this.lblMainCourse.TabIndex = 20;
            this.lblMainCourse.Text = "Main Course";
            // 
            // lblDessert
            // 
            this.lblDessert.AutoSize = true;
            this.lblDessert.Location = new System.Drawing.Point(495, 13);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(43, 13);
            this.lblDessert.TabIndex = 21;
            this.lblDessert.Text = "Dessert";
            // 
            // BillCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 518);
            this.Controls.Add(this.lblDessert);
            this.Controls.Add(this.lblMainCourse);
            this.Controls.Add(this.lblAppetizer);
            this.Controls.Add(this.lblBeverage);
            this.Controls.Add(this.lblCurrency3);
            this.Controls.Add(this.lblCurrency2);
            this.Controls.Add(this.lblCurrency1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxDessert);
            this.Controls.Add(this.comboBoxMainCourse);
            this.Controls.Add(this.comboBoxAppetizer);
            this.Controls.Add(this.comboBoxBeverage);
            this.Name = "BillCalculator";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.comboBoxBeverage, 0);
            this.Controls.SetChildIndex(this.comboBoxAppetizer, 0);
            this.Controls.SetChildIndex(this.comboBoxMainCourse, 0);
            this.Controls.SetChildIndex(this.comboBoxDessert, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btnRemove, 0);
            this.Controls.SetChildIndex(this.btnCheckOut, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.lblSubtotal, 0);
            this.Controls.SetChildIndex(this.lblTax, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.txtSubtotal, 0);
            this.Controls.SetChildIndex(this.txtTax, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.lblCurrency1, 0);
            this.Controls.SetChildIndex(this.lblCurrency2, 0);
            this.Controls.SetChildIndex(this.lblCurrency3, 0);
            this.Controls.SetChildIndex(this.lblBeverage, 0);
            this.Controls.SetChildIndex(this.lblAppetizer, 0);
            this.Controls.SetChildIndex(this.lblMainCourse, 0);
            this.Controls.SetChildIndex(this.lblDessert, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxBeverage;
        private System.Windows.Forms.ComboBox comboBoxAppetizer;
        private System.Windows.Forms.ComboBox comboBoxMainCourse;
        private System.Windows.Forms.ComboBox comboBoxDessert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblCurrency1;
        private System.Windows.Forms.Label lblCurrency2;
        private System.Windows.Forms.Label lblCurrency3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotal;
        private System.Windows.Forms.Label lblBeverage;
        private System.Windows.Forms.Label lblAppetizer;
        private System.Windows.Forms.Label lblMainCourse;
        private System.Windows.Forms.Label lblDessert;
    }
}

