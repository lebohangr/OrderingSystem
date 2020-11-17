namespace Poppel_System.Customer_Entities
{
    public class Customer
    {
        public int CustNo;
        public string companyName;
        public string firstName;
        public string lastName;
        public string phone;
        public string address1;
        public string city;
        public int postalCode;
        public decimal creditLimit;
        public string creditStatus;
        public bool blacklisted;

        #region Constructors
        public Customer()
        {
            CustNo = 0;
            companyName = "";
            firstName = "";
            lastName = "";
            phone = "";
            address1 = "";
            city = "";
            postalCode = 0;
            creditLimit = 2000;
            creditStatus = "Good";
            blacklisted = false;
        }

        public Customer(int cust, string compName, string fname, string lname, string pnum, string addy, string city, int postcode, decimal climit, string cstatus,bool blist)
        {
            CustNo = cust;
            companyName = compName;
            firstName = fname;
            lastName = lname;
            phone = pnum;
            address1 = addy;
            this.city = city;
            postalCode = postcode;
            creditLimit = climit;
            creditStatus = cstatus;
            blacklisted = blist;
        }
        #endregion
    }
}