using System;

namespace Poppel_System.Customer_Entities
{
    public class Order
    {
        public int orderID;
        public int custNo;
        public int employeeID;
        public DateTime orderDate;
        public DateTime deliveryDate;
        public string status;
        public enum Status
        {
            PendingPayment,
            Reserved,
            Dispatched,
            Delivered
        }

    }
}