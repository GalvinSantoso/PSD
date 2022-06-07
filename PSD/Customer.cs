using System;

namespace PSD
{
    public class Customer
    {
        public string customerID { get; set; }
        public string customerName { get; set; }
        public int customerAge { get; set; }
        public string customerPhone { get; set; }
        public string customerAddress { get; set; }
        public int customerBalance { get; set; }
  
        public Customer(string aCustomerID, string aCustomerName, int aCustomerAge, string aCustomerPhone, string aCustomerAddress, int aCustomerBalance)
        {
            this.customerID = aCustomerID;
            this.customerName = aCustomerName;
            this.customerAge = aCustomerAge;    
            this.customerPhone = aCustomerPhone; 
            this.customerAddress = aCustomerAddress;
            this.customerBalance = aCustomerBalance;
        }

        

    }
}