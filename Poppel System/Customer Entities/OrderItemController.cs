using Poppel_System.Database_Layer;
using System.Collections.ObjectModel;

namespace Poppel_System.Customer_Entities
{
    public class OrderItemController
    {
        #region Data Members
        PoppelDB poppelDB;
        private Collection<OrderItem> orderItems;
        #endregion

        #region Property Methods
        public Collection<OrderItem> AllOrders
        {
            get
            {
                return orderItems;
            }
        }

        #endregion

        #region Constructors
        public OrderItemController()
        {
            poppelDB = new PoppelDB();
            orderItems = poppelDB.AllOrderItems;
        }



        #endregion

        #region CRUD Methods

        public void Add(OrderItem aOrderItem)
        {
            poppelDB.DatabaseAdd(aOrderItem);
            orderItems.Add(aOrderItem);
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

        public void Delete(OrderItem aOrderItem)
        {

            int count;
            //Find the entry in the Collection
            count = FindIndex(aOrderItem);
            //Remove the specific entry found in the collection
            orderItems.RemoveAt(count);
            //request a database delete         
            poppelDB.DatabaseDelete(aOrderItem);

        }

        #endregion

        #region Lookups: Searching index and record
        public int FindIndex(OrderItem orderItem)
        {
            int index = 0;
            bool found = false;
            while (!found && index < orderItems.Count)
            {
                found = orderItems[index].orderItemID == orderItem.orderItemID;
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

        public OrderItem FindByID(string IDvalue)
        {
            int position = 0;
            bool found = (IDvalue == orderItems[position].orderItemID.ToString());
            while (!found && position < orderItems.Count)
            {
                found = (IDvalue == orderItems[position].orderItemID.ToString());
                if (!found)
                {
                    position += 1;
                }
            }
            if (found)
            {
                return orderItems[position];
            }
            else
            {
                return null;
            }
        }
        #endregion

    }
}
