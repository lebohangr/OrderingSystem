using Poppel_System.Database_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poppel_System.Customer_Entities
{
    public class OrderController
    {

        #region Data Members
        PoppelDB poppelDB;
        private Collection<Order> orders;
        #endregion

        #region Property Methods
        public Collection<Order> AllOrders
        {
            get
            {
                return orders;
            }
        }

        #endregion

        #region Constructors
        public OrderController()
        {
            poppelDB = new PoppelDB();
            orders = poppelDB.AllOrders;
        }



        #endregion

        #region CRUD Methods

        public void Add(Order aOrder)
        {
            poppelDB.DatabaseAdd(aOrder);
            orders.Add(aOrder);
        }

       
       /*** public void Edit(Order aOrder)
        {

            int count;
            //Find the entry in the Collection
            count = FindIndex(aOrder);
            //Edit the specific entry found in the collection

           /*** customers[count].Gender = aStudent.Gender;
            customers[count].PopGroup = aStudent.PopGroup;
            customers[count].HomeLanguage = aStudent.HomeLanguage;
            customers[count].SA_Citizenship_Status = aStudent.SA_Citizenship_Status;

            //request a database edit         
            poppelDB.DatabaseEdit(aOrder);
           
        } ***/

        public void Delete(Order aOrder)
        {

            int count;
            //Find the entry in the Collection
            count = FindIndex(aOrder);
            //Remove the specific entry found in the collection
            orders.RemoveAt(count);
            //request a database delete         
            poppelDB.DatabaseDelete(aOrder);

        }

        #endregion

        #region Lookups: Searching index and record
        public int FindIndex(Order order)
        {
            int index = 0;
            bool found = false;
            while (!found && index < orders.Count)
            {
                found = orders[index].orderID == order.orderID;
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

        public Order FindByID(string IDvalue)
        {
            int position = 0;
            bool found = (IDvalue == orders[position].orderID.ToString());
            while (!found && position < orders.Count)
            {
                found = (IDvalue == orders[position].orderID.ToString());
                if (!found)
                {
                    position += 1;
                }
            }
            if (found)
            {
                return orders[position];
            }
            else
            {
                return null;
            }
        }
        #endregion


    }
}
