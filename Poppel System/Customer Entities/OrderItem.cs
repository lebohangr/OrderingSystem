using System;

namespace Poppel_System.Customer_Entities
{
    public class OrderItem
    {
        public int orderItemID;
        public int orderID;
        public int productCode;
        public int quantity;
        public decimal unitPrice;
    }
}