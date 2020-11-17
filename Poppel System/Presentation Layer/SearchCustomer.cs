using Poppel_System.Database_Layer;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Poppel_System.Customer_Entities;

namespace Poppel_System.Presentation_Layer
{
    public partial class SearchCustomer : Form
    {
        #region Fields
        public bool viewCustomersFormClosed;
        CustomerController customerController;
        PoppelMDIParent parent;
        Collection<Customer> customers;
        ListViewItem customerDetails;
        #endregion

        #region Constructors
        public SearchCustomer(CustomerController controller, PoppelMDIParent parent)
        {
            InitializeComponent();
            customerController = controller;
            this.parent = parent;

        }
        #endregion

        #region ListView for customers
        public void setUpCustomerListView() //sets up the listview
        {
            Collection<Customer> customers = null;
            customers = customerController.AllCustomers;
            customersListview.Clear();
            customersListview.Columns.Add( "CustNo", 80, HorizontalAlignment.Left);
            customersListview.Columns.Add( "Customer Name", 200, HorizontalAlignment.Left);
            customersListview.Columns.Add( "First Name", 80, HorizontalAlignment.Left);
            customersListview.Columns.Add( "Last Name", 80, HorizontalAlignment.Left);
            customersListview.Columns.Add("Phone", 150, HorizontalAlignment.Left);
            customersListview.Columns.Add( "Address 1", 150, HorizontalAlignment.Left);
            customersListview.Columns.Add( "City", 150, HorizontalAlignment.Left);
            customersListview.Columns.Add( "Postal Code", 80, HorizontalAlignment.Left);
            customersListview.Columns.Add( "Credit Limit", 80, HorizontalAlignment.Left);
            customersListview.Columns.Add( "Credit Status", 80, HorizontalAlignment.Left);
            customersListview.Columns.Add( "Blacklisted?", 80, HorizontalAlignment.Left);

               foreach (Customer customer in customers)
               {
                   customerDetails = new ListViewItem();
                   customerDetails.Text = customer.CustNo.ToString();
                   customerDetails.SubItems.Add(customer.companyName);
                   customerDetails.SubItems.Add(customer.firstName);
                   customerDetails.SubItems.Add(customer.lastName);
                   customerDetails.SubItems.Add(customer.phone);
                   customerDetails.SubItems.Add(customer.address1);
                   customerDetails.SubItems.Add(customer.city);
                   customerDetails.SubItems.Add(customer.postalCode.ToString());                
                   customerDetails.SubItems.Add(customer.creditLimit.ToString());
                   customerDetails.SubItems.Add(customer.creditStatus);
                   customerDetails.SubItems.Add(customer.blacklisted.ToString());

                   customersListview.Items.Add(customerDetails);
               }
            customersListview.GridLines = true;
            
        }
        #endregion

        #region Methods
        private void FilterItems() //filters the listview by the any field
        {
            if (txtSearch.Text == "")
            {
                setUpCustomerListView();
                return;
            }
            foreach (ListViewItem item in customersListview.Items)
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    if (subitem.Text.Equals(txtSearch.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                        break;
                    }
            var list = customersListview.Items
                                .Cast<ListViewItem>()
                                .Where(
                                    x => x.SubItems
                                          .Cast<ListViewItem.ListViewSubItem>()
                                          .Any(y => y.Text.Contains(txtSearch.Text)))
                                .ToArray();
            customersListview.Items.Clear();
            customersListview.Items.AddRange(list);
        }
        #endregion

        #region Events
        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            customersListview.View = View.Details; //stating how the list view should display the information
            setUpCustomerListView();
        }

        private void ViewCustomers_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewCustomersFormClosed = true;
            parent.Enabled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterItems();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            txtSearch.Clear();
        }

        private void ViewCustomers_Activated(object sender, EventArgs e)
        {
            customersListview.View = View.Details;
            setUpCustomerListView();
        }
        #endregion
    }
}
