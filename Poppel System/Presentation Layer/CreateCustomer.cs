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
    public partial class CreateCustomer : Form
    {
       
        public CustomerController customerController;
        public bool customerFormClosed = false;
        public CreateCustomer(CustomerController controller)
        {
            customerController = controller;
            InitializeComponent();
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateCustomer_Activated(object sender, EventArgs e)
        {
            
        }

        private void CreateCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            customerFormClosed = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
