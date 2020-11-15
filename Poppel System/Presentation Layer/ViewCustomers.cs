using Poppel_System.Customer_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poppel_System.Presentation_Layer
{
    public partial class ViewCustomers : Form
    {
        public bool viewCustomersFormClosed;
        CustomerController customerController;

        public ViewCustomers(CustomerController controller)
        {
            InitializeComponent();
            customerController = controller;

        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {

        }

        private void ViewCustomers_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewCustomersFormClosed = true;
        }
    }
}
