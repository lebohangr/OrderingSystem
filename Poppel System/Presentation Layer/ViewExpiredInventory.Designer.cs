namespace Poppel_System.Presentation_Layer
{
    partial class ViewExpiredInventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poppelDataset = new Poppel_System.PoppelDataset();
            this.expiredProductsTableAdapter = new Poppel_System.PoppelDatasetTableAdapters.ExpiredProductsTableAdapter();
            this.printExpiredProducts = new System.Drawing.Printing.PrintDocument();
            this.printPicture = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expiredProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.expiredDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.warehouseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expiredProductsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(987, 365);
            this.dataGridView1.TabIndex = 12;
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
            // expiredDataGridViewTextBoxColumn
            // 
            this.expiredDataGridViewTextBoxColumn.DataPropertyName = "# Expired";
            this.expiredDataGridViewTextBoxColumn.HeaderText = "# Expired";
            this.expiredDataGridViewTextBoxColumn.Name = "expiredDataGridViewTextBoxColumn";
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            // 
            // warehouseDataGridViewTextBoxColumn
            // 
            this.warehouseDataGridViewTextBoxColumn.DataPropertyName = "Warehouse";
            this.warehouseDataGridViewTextBoxColumn.HeaderText = "Warehouse";
            this.warehouseDataGridViewTextBoxColumn.Name = "warehouseDataGridViewTextBoxColumn";
            // 
            // expiredProductsBindingSource
            // 
            this.expiredProductsBindingSource.DataMember = "ExpiredProducts";
            this.expiredProductsBindingSource.DataSource = this.poppelDataset;
            // 
            // poppelDataset
            // 
            this.poppelDataset.DataSetName = "PoppelDataset";
            this.poppelDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expiredProductsTableAdapter
            // 
            this.expiredProductsTableAdapter.ClearBeforeFill = true;
            // 
            // printExpiredProducts
            // 
            this.printExpiredProducts.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printExpiredProducts_PrintPage);
            // 
            // printPicture
            // 
            this.printPicture.Image = global::Poppel_System.Properties.Resources.defaultprint;
            this.printPicture.Location = new System.Drawing.Point(881, 12);
            this.printPicture.Name = "printPicture";
            this.printPicture.Size = new System.Drawing.Size(45, 45);
            this.printPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printPicture.TabIndex = 13;
            this.printPicture.TabStop = false;
            this.printPicture.Click += new System.EventHandler(this.printPicture_Click);
            this.printPicture.MouseEnter += new System.EventHandler(this.printPicture_MouseEnter);
            this.printPicture.MouseLeave += new System.EventHandler(this.printPicture_MouseLeave);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-4, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(987, 121);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // ViewExpiredInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Poppel_System.Properties.Resources.background31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 573);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.printPicture);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewExpiredInventory";
            this.Text = "Expired Inventory";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewExpiredInventory_FormClosed);
            this.Load += new System.EventHandler(this.ViewExpiredInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expiredProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private PoppelDataset poppelDataset;
        private System.Windows.Forms.BindingSource expiredProductsBindingSource;
        private PoppelDatasetTableAdapters.ExpiredProductsTableAdapter expiredProductsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printExpiredProducts;
        private System.Windows.Forms.PictureBox printPicture;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}