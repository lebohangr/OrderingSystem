using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poppel_System.Customer_Entities;

namespace Poppel_System.Presentation_Layer
{
    public partial class ViewExpiredInventory : Form
    {
        PoppelMDIParent parent;
        public bool inventoryFormClosed;
        private ProductController productController;
        private PoppelMDIParent poppelMDIParent;

        public ViewExpiredInventory(ProductController aController, PoppelMDIParent parent)
        {
            InitializeComponent();
            this.parent = parent;
            productController = aController;
        }

        private void ViewExpiredInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
            inventoryFormClosed = true;
        }
    }
}
