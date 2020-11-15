using System;

namespace Poppel_System.Database_Layer
{
    public class Order
    {
        public int orderID;
        public int custNo;
        public int employeeID;
        public DateTime orderDate;
        public DateTime deliveryDate;
        public enum Status
        {
            PendingPayment,
            Reserved,
            Dispatched,
            Onroute,
            Delivered
        }

    }
}