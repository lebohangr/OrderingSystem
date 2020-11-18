using Poppel_System.Customer_Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poppel_System.Presentation_Layer
{
    public partial class CreateOrder : Form
        
    {
        #region Fields
        public bool createOrderFormClosed = false;
        public Product product;
        public OrderItem orderItem;
        public ProductController productController;
        public OrderController orderController;
        public OrderItemController orderItemController;
        public int newOrderID = 0;
        public int newOrderItemID = 0;
        PoppelMDIParent parent;
        #endregion

        public CreateOrder(ProductController productController, OrderController orderController, OrderItemController orderItemController, PoppelMDIParent parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.productController = productController;
            this.orderController = orderController;
            this.orderItemController = orderItemController;
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            this.product1TableAdapter.Fill(this.poppelDataset.Product1);
            this.productTableAdapter.Fill(this.poppelDataset.Product);

            Collection<Order> allOrders =  orderController.AllOrders;
            MessageBox.Show(Convert.ToString(allOrders.Count));
            Order lastOrder = allOrders[allOrders.Count - 2];
            newOrderID = lastOrder.orderID + 1;
            MessageBox.Show(newOrderID.ToString());

            Collection<OrderItem> allOrderItems = orderItemController.AllOrderItems; //you're here
            MessageBox.Show(Convert.ToString(allOrderItems.Count));
            OrderItem lastOrderItem = allOrderItems[allOrderItems.Count - 2];
            newOrderItemID = lastOrderItem.orderItemID + 1;
            MessageBox.Show(newOrderItemID.ToString());

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.productTableAdapter1.FillBy2(this.poppelDataset.Product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void CreateOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            createOrderFormClosed = true;
            parent.Enabled = true;
        }

        private void txtProduct_TextChanged(object sender, EventArgs e) //code to filter datagrid everytime a key is pressed
        {
            
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[1].DataPropertyName + ", System.String) like '%" + txtProduct.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;

        }

        private void txtProduct_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtProduct_Enter(object sender, EventArgs e)
        {
            txtProduct.Clear();
            txtProduct.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        public OrderItem PopulateOrderItem(OrderItem aOrderItem)
        {
            aOrderItem.orderItemID = Convert.ToInt32(newOrderItemID);
            aOrderItem.orderID = Convert.ToInt32(newOrderID);
            aOrderItem.productCode = txtFirstName.Text;
            aOrderItem.quantity = txtLastName.Text;
            aOrderItem.unitPrice = Convert.ToDecimal(txtPhone.Text);
            return aOrderItem;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            int quantity = (int) nmQuantity.Value;
            string a ="";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                a = row.Cells[1].Value.ToString();
            }
            DialogResult dialogResult = MessageBox.Show("Add item: " + a + " to basket?", "Confirm Item", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                OrderItem newOrderItem = new OrderItem();
                PopulateOrderItem(newOrderItem);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
