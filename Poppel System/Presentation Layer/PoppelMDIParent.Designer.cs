namespace Poppel_System.Presentation_Layer
{
    partial class PoppelMDIParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoppelMDIParent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blacklistCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExpiredInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(982, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.viewAllCustomersToolStripMenuItem,
            this.blacklistCustomerToolStripMenuItem,
            this.removeCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewCustomerToolStripMenuItem.Image")));
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.addNewCustomerToolStripMenuItem.Text = "Create new customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // viewAllCustomersToolStripMenuItem
            // 
            this.viewAllCustomersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewAllCustomersToolStripMenuItem.Image")));
            this.viewAllCustomersToolStripMenuItem.Name = "viewAllCustomersToolStripMenuItem";
            this.viewAllCustomersToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.viewAllCustomersToolStripMenuItem.Text = "View all customers";
            this.viewAllCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewAllCustomersToolStripMenuItem_Click);
            // 
            // blacklistCustomerToolStripMenuItem
            // 
            this.blacklistCustomerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("blacklistCustomerToolStripMenuItem.Image")));
            this.blacklistCustomerToolStripMenuItem.Name = "blacklistCustomerToolStripMenuItem";
            this.blacklistCustomerToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.blacklistCustomerToolStripMenuItem.Text = "Blacklist";
            // 
            // removeCustomerToolStripMenuItem
            // 
            this.removeCustomerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeCustomerToolStripMenuItem.Image")));
            this.removeCustomerToolStripMenuItem.Name = "removeCustomerToolStripMenuItem";
            this.removeCustomerToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.removeCustomerToolStripMenuItem.Text = "Remove";
            this.removeCustomerToolStripMenuItem.Click += new System.EventHandler(this.removeCustomerToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewOrderToolStripMenuItem,
            this.viewAllOrdersToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // createNewOrderToolStripMenuItem
            // 
            this.createNewOrderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewOrderToolStripMenuItem.Image")));
            this.createNewOrderToolStripMenuItem.Name = "createNewOrderToolStripMenuItem";
            this.createNewOrderToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.createNewOrderToolStripMenuItem.Text = "Create new order";
            // 
            // viewAllOrdersToolStripMenuItem
            // 
            this.viewAllOrdersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewAllOrdersToolStripMenuItem.Image")));
            this.viewAllOrdersToolStripMenuItem.Name = "viewAllOrdersToolStripMenuItem";
            this.viewAllOrdersToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.viewAllOrdersToolStripMenuItem.Text = "View all orders";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewExpiredInventoryToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // viewExpiredInventoryToolStripMenuItem
            // 
            this.viewExpiredInventoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewExpiredInventoryToolStripMenuItem.Image")));
            this.viewExpiredInventoryToolStripMenuItem.Name = "viewExpiredInventoryToolStripMenuItem";
            this.viewExpiredInventoryToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.viewExpiredInventoryToolStripMenuItem.Text = "View Expired Inventory";
            // 
            // PoppelMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Poppel_System.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 573);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PoppelMDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.AutoSizeChanged += new System.EventHandler(this.PoppelMDIParent_AutoSizeChanged);
            this.Load += new System.EventHandler(this.PoppelMDIParent_Load);
            this.Resize += new System.EventHandler(this.PoppelMDIParent_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blacklistCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewExpiredInventoryToolStripMenuItem;
    }
}



