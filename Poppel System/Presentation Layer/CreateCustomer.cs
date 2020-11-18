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
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;

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
            aCustomer.companyName = txtCompanyName.Text;
            aCustomer.firstName = txtFirstName.Text;
            aCustomer.lastName = txtLastName.Text;
            aCustomer.phone = txtPhone.Text;
            aCustomer.address1 = txtAddress.Text;
            aCustomer.city = txtCity.Text;
            aCustomer.postalCode = Convert.ToInt32(txtPostalCode.Text);
            return aCustomer;
        }

        private bool ValidateInput() //input validation
        {
            if (txtPhone.Text.Length == 10 && txtPostalCode.Text.Length==4)
            {
                return true;
            } else return false;
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
            Collection<Customer> allCust = customerController.AllCustomers;
            Customer lastCust = allCust[allCust.Count - 1];
            int newCustNum = lastCust.CustNo + 1;
            txtCustNo.Text =  newCustNum.ToString();
        }
        #endregion

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            if (ValidateInput()){
                try
                {
                    customer = PopulateCustomer();
                    customerController.Add(customer);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please try again with different values. There might be a duplication error. Thank You.");
                }
                finally
                {
                    MessageBox.Show("Success!","Customer Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCreateCustomer.Enabled = false;
                    txtAddress.Enabled = false;
                    txtCity.Enabled = false;
                    txtCompanyName.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtPostalCode.Enabled = false;
                    txtPhone.Enabled = false;
                   
                }
            }
        }

        private void btnCreateCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
