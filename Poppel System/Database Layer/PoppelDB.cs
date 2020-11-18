using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poppel_System.Customer_Entities;

namespace Poppel_System.Database_Layer
{
    class PoppelDB:DB
    {
        #region Fields
        /*
         1.1	A variable table1 initialised to Student;
         1.2	A variable sql_SELECT1 whose purpose is to query Table 1 and therefore initialised as follows:    
                   sql_SELECT1 = "SELECT * FROM " + table1;
         1.3	Declare a collection of students – see previous workshop on how to declare a collection. 
                Import the necessary namespaces if necessary.
         */
        string table1 = "Customers";
        string table2 = "Orders";
        string table3 = "Products";
        string table4 = "OrderItems";
        string sql_SELECT1 = "SELECT * FROM Customer";
        string sql_SELECT2 = "SELECT * FROM Order";
        string sql_SELECT3 = "SELECT * FROM Product";
        string sql_SELECT4 = "SELECT * FROM OrderItem";
        private Collection<Customer> customers;
        private Collection<Order> orders;
        private Collection<Product> products;
        private Collection<OrderItem> orderItems;

        #endregion

        #region Property methods
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }

        public Collection<Order> AllOrders
        {
            get
            {
                return orders;
            }
        }

        public Collection<Product> AllProducts        {
            get
            {
                return products;
            }
        }
        public Collection<OrderItem> AllOrderItems
        {
            get
            {
                return orderItems;
            }
        }
        #endregion

        #region Constructor
        public PoppelDB() : base()
        {
            customers = new Collection<Customer>();
            orders = new Collection<Order>();
            products = new Collection<Product>();
            orderItems = new Collection<OrderItem>();
            ReadDataFromTable(sql_SELECT1, table1);
         /***   ReadDataFromTable(sql_SELECT2, table2);
            ReadDataFromTable(sql_SELECT3, table3);
            ReadDataFromTable(sql_SELECT4, table4);
            ***/
        }

        

        #endregion

        #region Data reader 

        private void FillCustomers(SqlDataReader reader, string dataTable, Collection<Customer> customers) //need to implement
        {
            Customer customer;
            
            while (reader.Read())
            {
                customer = new Customer();
                customer.CustNo = reader.GetInt32(0);
                customer.companyName = reader.GetString(1).Trim();
                customer.firstName = reader.GetString(2).Trim();
                customer.lastName = reader.GetString(3).Trim();
                customer.phone = reader.GetString(4).Trim();
                customer.address1 = reader.GetString(5).Trim();
                customer.city = reader.GetString(6).Trim();
                customer.postalCode = reader.GetInt32(7);
                customer.creditLimit = reader.GetDecimal(8);
                customer.creditStatus = reader.GetString(9).Trim();
                customer.blacklisted = reader.GetBoolean(10);
                customers.Add(customer); //add student to the collection - needs to be completed
            }
            
        }

        private void FillOrders(SqlDataReader reader, string table, Collection<Order> orders) //need to implement
        {
            Order order;
            //4.1.2	Using the while loop, we will read through the collection as follows:
            
            while (reader.Read())
            {
                order = new Order();
                order.orderID = reader.GetInt32(0);
                order.custNo = reader.GetInt32(1);
                order.employeeID = reader.GetInt32(2);
                order.orderDate = reader.GetDateTime(3);
                order.deliveryDate = reader.GetDateTime(4);
                order.status = reader.GetString(5).Trim();
                orders.Add(order); //add order to the collection - needs to be completed
            }
            
        }

        private void FillProducts(SqlDataReader reader, string table, Collection<Product> products) //need to implement
        {
            Product product;
            //4.1.2	Using the while loop, we will read through the collection as follows:
            while (reader.Read())
            {
                product = new Product();
                product.productCode = reader.GetInt32(0);
                product.warehouseID = reader.GetInt32(1);
                product.supplierID = reader.GetInt32(2);
                product.name = reader.GetString(3).Trim();
                product.pdtDescription = reader.GetString(4).Trim();
                product.quantityinStock = reader.GetInt32(5);
                product.unitPrice = reader.GetDecimal(6);
                product.expiryDate = reader.GetDateTime(7);
                products.Add(product); //add product to the collection - needs to be completed 
            }
        }

        private void FillOrderItems(SqlDataReader reader, string table, Collection<OrderItem> orderItems) //need to implement
        {
            OrderItem orderItem;
            //4.1.2	Using the while loop, we will read through the collection as follows:
            while (reader.Read())
            {
                orderItem = new OrderItem();
                orderItem.orderItemID = reader.GetInt32(0);
                orderItem.orderID = reader.GetInt32(1);
                orderItem.productCode = reader.GetInt32(2);
                orderItem.quantity = reader.GetInt32(3);
                orderItem.unitPrice = reader.GetDecimal(4);
                orderItems.Add(orderItem); //add product to the collection - needs to be completed 
            }
        }


        private string ReadDataFromTable(string selectString, string table)
        {
            
            SqlDataReader reader;
            SqlCommand command;

            try
            {
                command = new SqlCommand(selectString, cnMain);

                cnMain.Open();

                command.CommandType = CommandType.Text; 
                reader = command.ExecuteReader();           
                if (reader.HasRows & table.Equals("Customers"))
                {
                    FillCustomers(reader, table, customers);
                }
                
                else if (reader.HasRows & table.Equals("Orders"))
                {
                    FillOrders(reader, table, orders);
                    MessageBox.Show("I order!");
                }
                else if (reader.HasRows & table.Equals("Products"))
                {
                    FillProducts(reader, table, products);
                    MessageBox.Show("I product!");
                }
                else if (reader.HasRows & table.Equals("OrderItems"))
                {
                    FillOrderItems(reader, table, orderItems);
                    MessageBox.Show("I item!");
                }
                
                reader.Close(); 

                cnMain.Close(); 
                return "success";


            }
            catch (Exception ex)
            {
                return (ex.ToString());
            }



        }

        

        #endregion

        #region CRUD Methods       

        public string GetValueString(Customer tempCust) //need to implement
        {
            
            string aStr = "";
            aStr = tempCust.CustNo + ", ' " + tempCust.companyName + " ' ," +
             " ' " + (tempCust.firstName).Trim() + " ' ," +
             " ' " + (tempCust.lastName).Trim() + " ' , " +
             " ' " + tempCust.phone + " ' ," +
             " ' " + (tempCust.address1).Trim() + " ' ,"+
             " ' " + (tempCust.city).Trim() + " '," + 
             " ' " + (tempCust.postalCode) + " ', " + 
             " ' " + (tempCust.creditLimit) + " ' ," +
             " ' " + (tempCust.creditStatus).Trim() + " ', "+
             " ' " + (tempCust.blacklisted) + " ' ";
            return aStr;
            
        }

        private string GetValueString(Order tempOrder) //need to implement
        {
            string aStr = "";

            aStr = tempOrder.orderID + ", ' " + tempOrder.custNo + " ' ," +
             " ' " + tempOrder.employeeID + " ' ," +
             " ' " + (tempOrder.orderDate) + " ' , " +
                              " ' " + tempOrder.deliveryDate + " ', " + (tempOrder.status).Trim();
            return aStr;
        }

        private string GetValueString(OrderItem tempOrderItem) //need to implement
        {
            string aStr = "";

            aStr = tempOrderItem.orderItemID + ", ' " + tempOrderItem.orderID + " ' ," +
             " ' " + tempOrderItem.productCode + " ' ," +
             " ' " + (tempOrderItem.quantity) + " ' , " +
                              " ' ," + tempOrderItem.unitPrice;
            return aStr;
        }

        private string GetValueString(Product tempProduct) //need to implement
        {
            string aStr = "";

            aStr = tempProduct.productCode + ", ' " + tempProduct.warehouseID + " ' ," +
             " ' " + tempProduct.supplierID + " ' ," +
             " ' " + (tempProduct.name).Trim() + " ' , " +
                              " ' " + tempProduct.pdtDescription + " ' " + tempProduct.quantityinStock + " ' ,"
                              + tempProduct.unitPrice + " ' ," + tempProduct.expiryDate + " ' ";
            return aStr;
        }

            public void DatabaseAdd(Customer tempCust)
        {

            string strSQL = "";
            strSQL = "INSERT into Customer(CustNo, CompanyName, FirstName, LastName, Phone, Address_1, City, PostalCode, CreditLimit, CreditStatus, Blacklisted)" + //implement for customer
                "VALUES(" + GetValueString(tempCust) + ")";

            UpdateDataSource(new SqlCommand(strSQL, cnMain));
           
        }

        public void DatabaseAdd(Order tempOrder)
        {

            string strSQL = "";
            strSQL = "INSERT into Order(OrderID, CustNo, EmployeeID, OrderDate, DeliveryDate, Status)" + //implement for order
                "VALUES(" + GetValueString(tempOrder) + ")";

            UpdateDataSource(new SqlCommand(strSQL, cnMain));

        }

        public void DatabaseAdd(OrderItem tempOrderItem)
        {

            string strSQL = "";
            strSQL = "INSERT into OrderItem(OrderItemID, OrderID, ProductCode, Quantity, UnitPrice)" + //implement for order
                "VALUES(" + GetValueString(tempOrderItem) + ")";

            UpdateDataSource(new SqlCommand(strSQL, cnMain));

        }


        /***
        public void DatabaseEdit(Customer tempCust) //need to implement
        {
            string sqlString = "";

            //Build SQL string for the Update command

           /*** sqlString = "Update Student Set Gender = '" + tempStudent.Gender.Trim() + "'," + //implement for customer && order
                              "PopGroup = '" + tempStudent.PopGroup.Trim() + "'," +
                              "[Home Language] = '" + tempStudent.HomeLanguage.Trim() + "'," +
                              "[SA Citizenship Status] = '" + tempStudent.SA_Citizenship_Status.Trim() + "'" +
                               "WHERE (StudentId = '" + tempStudent.StudentId + "')";
         

            //Create new SQL Command & call the UpdateDataSource method to execute the update command 
            UpdateDataSource(new SqlCommand(sqlString, cnMain));
           
        }
    ***/

        /***
    public void DatabaseEdit(Order tempOrder) //need to imlement
    {
        string sqlString = "";

        //Build SQL string for the Update command

        /*** sqlString = "Update Student Set Gender = '" + tempStudent.Gender.Trim() + "'," + //implement for customer && order
                           "PopGroup = '" + tempStudent.PopGroup.Trim() + "'," +
                           "[Home Language] = '" + tempStudent.HomeLanguage.Trim() + "'," +
                           "[SA Citizenship Status] = '" + tempStudent.SA_Citizenship_Status.Trim() + "'" +
                            "WHERE (StudentId = '" + tempStudent.StudentId + "')";


        //Create new SQL Command & call the UpdateDataSource method to execute the update command 
        UpdateDataSource(new SqlCommand(sqlString, cnMain));
    }***/

        public void DatabaseEdit(Product tempProduct) //need to imlement
        {
            string sqlString = "";

            //Build SQL string for the Update command

            sqlString = "Update Product Set ProductCode = '" + tempProduct.productCode + "'," + //implement for customer && order
                               "WarehouseID = '" + tempProduct.warehouseID + "'," +
                               "SupplierID = '" + tempProduct.supplierID + "'," +
                               "Name = '" + tempProduct.name.Trim() + "'," +
                               "PdtDescription = '" + tempProduct.pdtDescription + "'," +
                               "QuantityInStock = '" + tempProduct.quantityinStock + "'," +
                               "UnitPrice = '" + tempProduct.unitPrice + "'," +
                               "ExpiryDate = '" + tempProduct.expiryDate + "'" +
                                "WHERE (ProductCode = '" + tempProduct.productCode + "')";
           

            //Create new SQL Command & call the UpdateDataSource method to execute the update command 
            UpdateDataSource(new SqlCommand(sqlString, cnMain));
        }

        public void DatabaseDelete(Customer tempCust)
        {
            string sqlString = "";
            sqlString = "Delete FROM Customer WHERE (CustNo = '" + tempCust.CustNo + "')";
            UpdateDataSource(new SqlCommand(sqlString, cnMain));

        }

        public void DatabaseDelete(Order tempOrder)
        {
            string sqlString = "";
            sqlString = "Delete FROM Order WHERE (OrderID = '" + tempOrder.orderID + "')";
            UpdateDataSource(new SqlCommand(sqlString, cnMain));

        }
        public void DatabaseDelete(OrderItem tempOrderItem)
        {
            string sqlString = "";
            sqlString = "Delete FROM OrderItem WHERE (OrderItemID = '" + tempOrderItem.orderItemID + "')";
            UpdateDataSource(new SqlCommand(sqlString, cnMain));

        }


        #endregion
    }
}
