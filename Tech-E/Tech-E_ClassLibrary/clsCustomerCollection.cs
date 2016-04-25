using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tech_E_ClassLibrary
{
    public class clsCustomerCollection
    {
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
