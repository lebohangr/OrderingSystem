using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        string sql_SELECT1 = "SELECT * FROM Customer";
        string sql_SELECT2 = "SELECT * FROM Order";
        private Collection<Customer> customers;
        private Collection<Order> orders;

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

        #endregion

        #region Constructor
        public PoppelDB() : base()
        {
            customers = new Collection<Customer>();
            orders = new Collection<Order>();
            ReadDataFromTable(sql_SELECT1, table1);
            ReadDataFromTable(sql_SELECT2, table2);

        }

        

        #endregion

        #region Data reader 

        private void FillCustomers(SqlDataReader reader, string dataTable, Collection<Customer> customers) //need to implement
        {
            Customer customer;
            /***
            while (reader.Read())
            {
                customer = new Customer();
                customer.StudentId = reader.GetInt32(0);
                customer.Gender = reader.GetString(1).Trim();
                customer.PopGroup = reader.GetString(2).Trim();
                customer.HomeLanguage = reader.GetString(3).Trim();
                customer.SA_Citizenship_Status = reader.GetString(4).Trim();
                customer.Foreign_Country = reader.GetString(5).Trim();
                customers.Add(customer); //add student to the collection - needs to be completed
            }
            ***/
        }

        private void FillOrders(SqlDataReader reader, string table, Collection<Order> orders) //need to implement
        {
            Order order;
            //4.1.2	Using the while loop, we will read through the collection as follows:
            /***
            while (reader.Read())
            {
                order = new Customer();
                order.StudentId = reader.GetInt32(0);
                order.Gender = reader.GetString(1).Trim();
                order.PopGroup = reader.GetString(2).Trim();
                order.HomeLanguage = reader.GetString(3).Trim();
                order.SA_Citizenship_Status = reader.GetString(4).Trim();
                order.Foreign_Country = reader.GetString(5).Trim();
                order.Add(customer); //add student to the collection - needs to be completed
            }
            ***/
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
                else if (reader.HasRows & table.Equals("Customers"))
                {
                    FillOrders(reader, table, orders);
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
            /***
            aStr = tempStud.StudentId + ", ' " + tempStud.Gender + " ' ," +
             " ' " + tempStud.PopGroup + " ' ," +
             " ' " + (tempStud.HomeLanguage).Trim() + " ' , " +
                              " ' " + tempStud.SA_Citizenship_Status + " ' ";
            ***/
            return aStr;
            
        }

        private string GetValueString(Order tempOrder) //need to implement
        {
            string aStr = "";
            /***
            aStr = tempStud.StudentId + ", ' " + tempStud.Gender + " ' ," +
             " ' " + tempStud.PopGroup + " ' ," +
             " ' " + (tempStud.HomeLanguage).Trim() + " ' , " +
                              " ' " + tempStud.SA_Citizenship_Status + " ' ";
            ***/
            return aStr;
        }

        public void DatabaseAdd(Customer tempCust)
        {

            string strSQL = "";
            strSQL = "INSERT into Student(StudentId, Gender, PopGroup, [Home Language], [SA Citizenship Status])" + //implement for customer
                "VALUES(" + GetValueString(tempCust) + ")";

            UpdateDataSource(new SqlCommand(strSQL, cnMain));
           
        }

        public void DatabaseAdd(Order tempOrder)
        {

            string strSQL = "";
            strSQL = "INSERT into Student(StudentId, Gender, PopGroup, [Home Language], [SA Citizenship Status])" + //implement for order
                "VALUES(" + GetValueString(tempOrder) + ")";

            UpdateDataSource(new SqlCommand(strSQL, cnMain));

        }

       

        public void DatabaseEdit(Customer tempCust) //need to implement
        {
            string sqlString = "";

            //Build SQL string for the Update command

           /*** sqlString = "Update Student Set Gender = '" + tempStudent.Gender.Trim() + "'," + //implement for customer && order
                              "PopGroup = '" + tempStudent.PopGroup.Trim() + "'," +
                              "[Home Language] = '" + tempStudent.HomeLanguage.Trim() + "'," +
                              "[SA Citizenship Status] = '" + tempStudent.SA_Citizenship_Status.Trim() + "'" +
                               "WHERE (StudentId = '" + tempStudent.StudentId + "')";
          ***/

            //Create new SQL Command & call the UpdateDataSource method to execute the update command 
            UpdateDataSource(new SqlCommand(sqlString, cnMain));
           
        }

        public void DatabaseEdit(Order aOrder) //need to imlement
        {
            string sqlString = "";

            //Build SQL string for the Update command

            /*** sqlString = "Update Student Set Gender = '" + tempStudent.Gender.Trim() + "'," + //implement for customer && order
                               "PopGroup = '" + tempStudent.PopGroup.Trim() + "'," +
                               "[Home Language] = '" + tempStudent.HomeLanguage.Trim() + "'," +
                               "[SA Citizenship Status] = '" + tempStudent.SA_Citizenship_Status.Trim() + "'" +
                                "WHERE (StudentId = '" + tempStudent.StudentId + "')";
           ***/

            //Create new SQL Command & call the UpdateDataSource method to execute the update command 
            UpdateDataSource(new SqlCommand(sqlString, cnMain));
        }


        public void DatabaseDelete(Customer tempCust)
        {
            string sqlString = "";
            sqlString = "Delete FROM Customer WHERE (CustomerId = '" + tempCust.CustNo + "')";
            UpdateDataSource(new SqlCommand(sqlString, cnMain));

        }

        public void DatabaseDelete(Order tempOrder)
        {
            string sqlString = "";
            sqlString = "Delete FROM Order WHERE (OrderID = '" + tempOrder.orderID + "')";
            UpdateDataSource(new SqlCommand(sqlString, cnMain));

        }

        #endregion
    }
}
