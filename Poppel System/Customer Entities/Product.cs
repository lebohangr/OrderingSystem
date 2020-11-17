using System;

namespace Poppel_System.Customer_Entities
{
    public class Product
    {
        public int productCode;
        public int warehouseID;
        public int supplierID;
        public string name;
        public string pdtDescription;
        public int quantityinStock;
        public decimal unitPrice;
        public DateTime expiryDate;
    }
}