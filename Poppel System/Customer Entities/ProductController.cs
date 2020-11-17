using Poppel_System.Database_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poppel_System.Customer_Entities
{
    public class ProductController
    {
        #region Data Members
        PoppelDB poppelDB;
        private Collection<Product> products;
        #endregion

        #region Property Methods
        public Collection<Product> AllProducts
        {
            get
            {
                return products;
            }
        }

        #endregion

        #region Constructors
        public ProductController()
        {
            poppelDB = new PoppelDB();
            products = poppelDB.AllProducts;
        }
        #endregion

        #region CRUD Methods
        public void Edit(Product aProduct)
        {

            int count;
            //Find the entry in the Collection
            count = FindIndex(aProduct);
            //Edit the specific entry found in the collection

             products[count].quantityinStock = aProduct.quantityinStock;
            
            //request a database edit         
            poppelDB.DatabaseEdit(aProduct);

        }

        #endregion

        #region Lookups: Searching index and record
        public int FindIndex(Product aProduct)
        {
            int index = 0;
            bool found = false;
            while (!found && index < products.Count)
            {
                found = products[index].productCode == aProduct.productCode;
                if (!found)
                {
                    index++;
                }
            }
            if (found)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }

        public Product FindByID(string IDvalue)
        {
            int position = 0;
            bool found = (IDvalue == products[position].productCode.ToString());
            while (!found && position < products.Count)
            {
                found = (IDvalue == products[position].productCode.ToString());
                if (!found)
                {
                    position += 1;
                }
            }
            if (found)
            {
                return products[position];
            }
            else
            {
                return null;
            }
        }
        #endregion


    }
}
