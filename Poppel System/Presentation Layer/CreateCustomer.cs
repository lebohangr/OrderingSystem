using Poppel_System.Database_Layer;
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
    public partial class CreateCustomer : Form
    {
        #region Fields
        PoppelMDIParent parent;
        Customer customer;
        public CustomerController customerController;
        public bool customerFormClosed = false;
        #endregion

        #region Constructors
        public CreateCustomer(CustomerController controller, PoppelMDIParent parent)
        {
            customerController = controller;
            InitializeComponent();
            this.parent = parent;
        }
        #endregion

        #region Methods
        public Customer PopulateCustomer()
        {
            Customer aCustomer = new Customer();
            aCustomer.CustNo = Convert.ToInt32(txtCustNo.Text);
            aCustomer.companyName = txtCustName.Text;
            aCustomer.firstName = txtFirstName.Text;
            aCustomer.lastName = txtLastName.Text;
            aCustomer.phone = txtPhone.Text;
            aCustomer.address1 = txtAddress.Text;
            aCustomer.city = txtCity.Text;
            aCustomer.postalCode = Convert.ToInt32(txtPostalCode.Text);
            return aCustomer;
        }
        #endregion

        #region Events
        private void CreateCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            customerFormClosed = true;
            parent.Enabled = true;
        }

        private void txtCustNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
          //  txtCustNo.Text = 
        }
        #endregion

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
           // if (txtPostalCode)
            PopulateCustomer();
        }
    }
}
