using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tech_E_ClassLibrary
{
    public class clsCustomerCollection
    {

        public clsCustomerCollection()
            {
            
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerNo = 1;
            TestItem.FirstName = "Peter";
            TestItem.LastName = "Anderson";
            TestItem.AddressLine1 = "Test Street";
            TestItem.AddressLine2 = "Test";
            TestItem.Town = "Test";
            TestItem.PostCode = "LE3 0QT";
            TestItem.EmailAddress = "test@email.com";
            TestItem.UserName = "test123";
            TestItem.Password = "password";
            //add the item to the test list
            customerList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsCustomer();
            //set the properties
            TestItem.CustomerNo = 2;
            TestItem.FirstName = "Grizz";
            TestItem.LastName = "Tempz";
            TestItem.AddressLine1 = "Test Street";
            TestItem.AddressLine2 = "Test";
            TestItem.Town = "Test";
            TestItem.PostCode = "LE3 0QT";
            TestItem.EmailAddress = "Baa@Grizz.com";
            TestItem.UserName = "Propa123";
            TestItem.Password = "password";
            //add the item to the test list
            CustomerList.Add(TestItem);
            
        }


        //private data member for the list
        List<clsCustomer> customerList = new List<clsCustomer>();

        public List<clsCustomer> CustomerList 
        { 
            get
            {
                //return the private data
                return customerList;
            } 
            set
            {
                //set the private data
                customerList = value;
            }
        }

        public clsCustomer ThisCustomer { get; set; }

        public int Count 
        { 
            get
            {
                //return the count of the list
                return customerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
    }
}
