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
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll")
            
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
