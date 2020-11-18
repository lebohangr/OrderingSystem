namespace Poppel_System.Presentation_Layer
{
    partial class CreateOrder
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
            this.components = new System.ComponentModel.Container();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poppelDataset = new Poppel_System.PoppelDataset();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.productTableAdapter = new Poppel_System.PoppelDatasetTableAdapters.ProductTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.product1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product1TableAdapter = new Poppel_System.PoppelDatasetTableAdapters.Product1TableAdapter();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.btnConfirmOrder.FlatAppearance.BorderSize = 0;
            this.btnConfirmOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.Location = new System.Drawing.Point(205, 511);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(155, 41);
            this.btnConfirmOrder.TabIndex = 11;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddToOrder.FlatAppearance.BorderSize = 0;
            this.btnAddToOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Location = new System.Drawing.Point(34, 376);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(155, 32);
            this.btnAddToOrder.TabIndex = 14;
            this.btnAddToOrder.Text = "Add to order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // txtProduct
            // 
            this.txtProduct.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtProduct.Location = new System.Drawing.Point(34, 327);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(155, 22);
            this.txtProduct.TabIndex = 15;
            this.txtProduct.Text = "Search item...";
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            this.txtProduct.Enter += new System.EventHandler(this.txtProduct_Enter);
            this.txtProduct.MouseEnter += new System.EventHandler(this.txtProduct_MouseEnter);
            // 
            // nmQuantity
            // 
            this.nmQuantity.Location = new System.Drawing.Point(205, 327);
            this.nmQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(134, 22);
            this.nmQuantity.TabIndex = 19;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(235, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quantity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCustNo
            // 
            this.txtCustNo.Location = new System.Drawing.Point(205, 460);
            this.txtCustNo.Name = "txtCustNo";
            this.txtCustNo.ReadOnly = true;
            this.txtCustNo.Size = new System.Drawing.Size(155, 22);
            this.txtCustNo.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(31, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Customer Number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(850, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 41);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.quantityInStockDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.product1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(987, 312);
            this.dataGridView1.TabIndex = 24;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.poppelDataset;
            // 
            // poppelDataset
            // 
            this.poppelDataset.DataSetName = "PoppelDataset";
            this.poppelDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGenerate.Enabled = false;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(34, 511);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(155, 41);
            this.btnGenerate.TabIndex = 25;
            this.btnGenerate.Text = "Generate Picking List";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(398, 326);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(425, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // product1BindingSource
            // 
            this.product1BindingSource.DataMember = "Product1";
            this.product1BindingSource.DataSource = this.poppelDataset;
            // 
            // product1TableAdapter
            // 
            this.product1TableAdapter.ClearBeforeFill = true;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "Product Code";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "Product Code";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            this.quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "Quantity In Stock";
            this.quantityInStockDataGridViewTextBoxColumn.HeaderText = "Quantity In Stock";
            this.quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit Price";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "Expiry Date";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "Expiry Date";
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Poppel_System.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 573);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCustNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmQuantity);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.btnConfirmOrder);
            this.DoubleBuffered = true;
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateOrder_FormClosed);
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenerate;
        private PoppelDataset poppelDataset;
        private System.Windows.Forms.BindingSource productBindingSource;
        private PoppelDatasetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource product1BindingSource;
        private PoppelDatasetTableAdapters.Product1TableAdapter product1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
    }
}