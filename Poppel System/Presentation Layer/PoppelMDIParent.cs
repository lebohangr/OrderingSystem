using Poppel_System.Customer_Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Poppel_System.Presentation_Layer
{
    public partial class PoppelMDIParent : Form
    {
        #region Field/Data Members
        private int childFormNumber = 0;
        public CustomerController customers;
        public CreateCustomer customerForm;
        private ViewCustomers viewCustomersForm;
        #endregion


        public PoppelMDIParent()
        {
            InitializeComponent();
            customers = new CustomerController();
           

        }

        private void CreateCustomerForm()
        {
            customerForm = new CreateCustomer(customers);// 
           // customerForm.MdiParent = this; // set the MDIParent property of this to ‘this’  
            customerForm.StartPosition = FormStartPosition.CenterParent;// write the code to set the start position (FormStartPosition) of the form to CenterParent
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

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
           
        }

        private void removeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpMenu_Click(object sender, EventArgs e)
        {

        }

        private void expiredProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PoppelMDIParent_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
            
        }

        private void PoppelMDIParent_Resize(object sender, EventArgs e)
        {
            
        }

        private void PoppelMDIParent_AutoSizeChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
        }

        private void CreateViewAllCustomersForm()
        {
            viewCustomersForm = new ViewCustomers(customers);
            viewCustomersForm.StartPosition = FormStartPosition.CenterParent;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
