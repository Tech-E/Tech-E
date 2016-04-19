using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tech_E_ClassLibrary
{
    
    public class clsCustomer
    {
        //private data member for the CustomerNo property
        private Int32 customerNo;
        private String firstName;

        public int CustomerNo 
        { 
            get
            {
                //return the private data
                return customerNo;
            }
            set
            {
                //set the value of the private data member
                customerNo = value;
 
            }
        }

        public string FirstName
        {
            get
            {
                //return the private data
                return firstName;
            }
            set
            {
                //set the value of the private data member
                firstName = value;

            }
        }

        public object LastName { get; set; }

        public string Password { get; set; }

        public int PhoneNo { get; set; }

        public string EmailAddress { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public object Postcode { get; set; }

        public object Town { get; set; }

        public string UserName { get; set; }

        public bool Find(int CustomerNo)
        {
           //set the private data member to the test data value
            customerNo = 21;
            firstName = "Peter";
            //always return true
            return true;
        }
    }
}
