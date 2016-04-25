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
        clsCustomer thisCustomer = new clsCustomer();


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

        public clsCustomer ThisCustomer 
        { 
            get
            {
                //return the private data
                return thisCustomer;
            }
            set
            {
                //set the private data member
                thisCustomer = value;
            }
        }

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

        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to proccess
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.AddressLine1 = Convert.ToString(DB.DataTable.Rows[Index]["AddressLine1"]);
                ACustomer.AddressLine2 = Convert.ToString(DB.DataTable.Rows[Index]["AddressLine2"]);
                ACustomer.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town/City"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                ACustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                ACustomer.UserName = Convert.ToString(DB.DataTable.Rows[Index]["UserName"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ACustomer.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                //add the record to the private data member
                customerList.Add(ACustomer);
                //point at the next record
                Index++;

            }
        }



        public int Add()
        {
            thisCustomer.CustomerNo = 123;

            return thisCustomer.CustomerNo;
        }
    }
}



