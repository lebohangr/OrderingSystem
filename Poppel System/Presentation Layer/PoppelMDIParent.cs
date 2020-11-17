using Poppel_System.Database_Layer;
using Poppel_System.Customer_Entities;
using System;
using System.Windows.Forms;

namespace Poppel_System.Presentation_Layer
{
    public partial class PoppelMDIParent : Form
    {
        #region Field/Data Members
        private int childFormNumber = 0;
        public CustomerController customers;
        public CreateCustomer customerForm;
        public ProductController products;
        private SearchCustomer viewCustomersForm;
        private ViewExpiredInventory viewExpiredInventoryForm;
        #endregion


        public PoppelMDIParent()
        {
            InitializeComponent();
            customers = new CustomerController();
            products = new ProductController();
        }

        private void CreateCustomerForm()
        {
            customerForm = new CreateCustomer(customers,this);// 
           // customerForm.Parent = this; // set the MDIParent property of this to ‘this’  
            customerForm.StartPosition = FormStartPosition.CenterScreen;// write the code to set the start position (FormStartPosition) of the form to CenterParent
        }

        private void CreateViewAllCustomersForm()
        {
            viewCustomersForm = new SearchCustomer(customers,this);
            viewCustomersForm.StartPosition = FormStartPosition.CenterScreen;
        }
        public void CreateViewExpiredInventoryForm()
        {
            viewExpiredInventoryForm = new ViewExpiredInventory(products,this);
            viewExpiredInventoryForm.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerForm == null)
            {
                CreateCustomerForm();
            }
            if (customerForm.customerFormClosed)
            {
                CreateCustomerForm();
            }
          
            customerForm.Show();
            this.Enabled = false;
           
        }

        private void viewAllCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewCustomersForm == null)
            {
                CreateViewAllCustomersForm();
            }
            if (viewCustomersForm.viewCustomersFormClosed)
            {
                CreateViewAllCustomersForm();
            }

            viewCustomersForm.Show();
            this.Enabled = false;
        }

        private void removeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpMenu_Click(object sender, EventArgs e)
        {

        }

        private void viewExpiredInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewExpiredInventoryForm == null)
            {
                CreateViewExpiredInventoryForm();
            }
            if (viewExpiredInventoryForm.inventoryFormClosed)
            {
                CreateViewExpiredInventoryForm();
            }

            viewExpiredInventoryForm.Show();
            this.Enabled = false;
        }
    }
}
