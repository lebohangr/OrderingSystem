using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poppel_System.Customer_Entities;
using Poppel_System.Properties;

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

        private void ViewExpiredInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poppelDataset.ExpiredProducts' table. You can move, or remove it, as needed.
            this.expiredProductsTableAdapter.GetExpiredProducts(this.poppelDataset.ExpiredProducts);
            printPicture.BackColor = Color.Transparent;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            printPicture.Height = 35;
            printPicture.Width = 35;

            richTextBox1.DeselectAll();
            
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
            richTextBox1.Font = new Font("Comic Sans",16, FontStyle.Bold);
            richTextBox1.AppendText("Poppel" + Environment.NewLine);
            richTextBox1.Font = new Font("Calibri", 12, FontStyle.Bold);
           
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            richTextBox1.AppendText("Product Expiry Log" + Environment.NewLine + Environment.NewLine);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
            richTextBox1.AppendText("Generated On: \t" + System.DateTime.Today + "\t Stock Control Clerk: \t Ryan Danes");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.expiredProductsTableAdapter.FillBy(this.poppelDataset.ExpiredProducts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void printExpiredProducts_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) //handles print event
        {
            //save richedit teext to bitmap
            int DGVOriginalHeight = dataGridView1.Height;
            dataGridView1.Height = (dataGridView1.RowCount * dataGridView1.RowTemplate.Height) + dataGridView1.ColumnHeadersHeight;
            richTextBox1.Update(); // Ensure RTB fully painted
            Bitmap bm = new Bitmap(this.richTextBox1.Width, this.richTextBox1.Height + this.dataGridView1.Height);
            richTextBox1.DrawToBitmap(bm, new Rectangle(0, 0, this.richTextBox1.Width, this.richTextBox1.Height));
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, this.richTextBox1.Height + 1, this.dataGridView1.Width, this.richTextBox1.Height + this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Save("report.png", ImageFormat.Png);
            dataGridView1.Height = DGVOriginalHeight;

            
            Bitmap bmp = new Bitmap(richTextBox1.Width, richTextBox1.Height);
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.CopyFromScreen(richTextBox1.PointToScreen(Point.Empty), Point.Empty, richTextBox1.Size);
            }
            bmp.Save("rich.png", ImageFormat.Png);
        }



        private void printPicture_Click(object sender, EventArgs e)
        {
            printExpiredProducts.Print();
        }

        private void printPicture_MouseEnter(object sender, EventArgs e)
        {
            printPicture.Image = Resources.hightlighted;
            printPicture.Height = 45;
            printPicture.Width = 45;
         //   printPicture.Location = new Point(582, 23);
        }

        private void printPicture_MouseLeave(object sender, EventArgs e)
        {
            printPicture.Image = Resources.defaultprint;
            printPicture.Height = 35;
            printPicture.Width = 35;
           // printPicture.Location = new Point(582, 23);
        }
    }
}
