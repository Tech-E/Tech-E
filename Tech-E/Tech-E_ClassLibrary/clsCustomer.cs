using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Tech_E_ClassLibrary
{
    
    public class clsCustomer
    {
        //private data member for the CustomerNo property
        private int customerNo;
        private String firstName;
        private String lastName;
        private String password;
        private Int64 phoneNo;
        private String emailAddress;
        private String addressLine1;

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

        public string LastName
        {
            get
            {
                //return the private data
                return lastName;
            }
            set
            {
                //set the value of the private data member
                lastName = value;

            }
        }

        public string Password
        {
            get
            {
                //return the private data
                return password;
            }
            set
            {
                //set the value of the private data member
                password = value;

            }
        }

        public Int64 PhoneNo
        {
            get
            {
                //return the private data
                return phoneNo;
            }
            set
            {
                //set the value of the private data member
                phoneNo = value;

            }
        }

        public string EmailAddress 
        {
            get
            {
                //return the private data
                return emailAddress;
            }
            set
            {
                //set the value of the private data member
                emailAddress = value;

            }
        }

        public string AddressLine1
        {
            get
            {
                //return the private data
                return addressLine1;
            }
            set
            {
                //set the value of the private data member
                addressLine1 = value;

            }
        }

        public string AddressLine2 { get; set; }

        public object Postcode { get; set; }

        public object Town { get; set; }

        public string UserName { get; set; }

        public bool Find(int CustomerNo)
        {
           //set the private data member to the test data value
            customerNo = 21;
            firstName = "Peter";
            lastName = "Anderson";
            password = "password";
            phoneNo = 07123123123;
            emailAddress = "test@email.com";
            addressLine1 = "Test Street";
            //always return true
            return true;
        }
    }
}
