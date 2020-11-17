using Poppel_System.Database_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poppel_System.Customer_Entities
{
    public class CustomerController
    {

        #region Data Members
        PoppelDB poppelDB;
        private Collection<Customer> customers;
        #endregion

        #region Property Methods
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }

        #endregion

        #region Constructors
        public CustomerController()
        {
            poppelDB = new PoppelDB();
            customers = poppelDB.AllCustomers;
        }



        #endregion

        #region CRUD Methods

        public void Add(Customer aCustomer)
        {
            poppelDB.DatabaseAdd(aCustomer);
            customers.Add(aCustomer);
        }
        
       /*** public void Edit(Customer aCustomer)
        {

            int count;
            //Find the entry in the Collection
            count = FindIndex(aCustomer);
            //Edit the specific entry found in the collection

           /*** customers[count].Gender = aStudent.Gender;
            customers[count].PopGroup = aStudent.PopGroup;
            customers[count].HomeLanguage = aStudent.HomeLanguage;
            customers[count].SA_Citizenship_Status = aStudent.SA_Citizenship_Status;

            //request a database edit         
            poppelDB.DatabaseEdit(aCustomer);
           
        }***/

        public void Delete(Customer aCustomer)
        {

            int count;
            //Find the entry in the Collection
            count = FindIndex(aCustomer);
            //Remove the specific entry found in the collection
            customers.RemoveAt(count);
            //request a database delete         
            poppelDB.DatabaseDelete(aCustomer);

        }

        #endregion

        #region Lookups: Searching index and record
        public int FindIndex(Customer customer)
        {
            int index = 0;
            bool found = false;
            while (!found && index < customers.Count)
            {
                found = customers[index].CustNo == customer.CustNo;
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

        public Customer FindByID(string IDvalue)
        {
            int position = 0;
            bool found = (IDvalue == customers[position].CustNo.ToString());
            while (!found && position < customers.Count)
            {
                found = (IDvalue == customers[position].CustNo.ToString());
                if (!found)
                {
                    position += 1;
                }
            }
            if (found)
            {
                return customers[position];
            }
            else
            {
                return null;
            }
        }
        #endregion


    }
}
