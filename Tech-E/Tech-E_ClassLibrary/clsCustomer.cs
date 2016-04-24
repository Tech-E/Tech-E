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
        private String lastName;
        private String password;
        private String phoneNo;
        private String emailAddress;
        private String addressLine1;
        private String addressLine2;
        private String postCode;
        private String town;
        private String userName;

        public Int32 CustomerNo
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

        public String PhoneNo
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

        public string AddressLine2
        {
            get
            {
                //return the private data
                return addressLine2;
            }
            set
            {
                //set the value of the private data member
                addressLine2 = value;

            }
        }

        public String PostCode
        {
            get
            {
                //return the private data
                return postCode;
            }
            set
            {
                //set the value of the private data member
                postCode = value;

            }
        }

        public String Town
        {
            get
            {
                //return the private data
                return town;
            }
            set
            {
                //set the value of the private data member
                town = value;

            }
        }

        public string UserName
        {
            get
            {
                //return the private data
                return userName;
            }
            set
            {
                //set the value of the private data member
                userName = value;

            }
        }

        public bool Find(Int32 CustomerNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer no to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            //Execute the stored Procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found (there should be one or zero!)
            if (DB.Count == 1)
            {
                //set the private data member to the test data value
                customerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                firstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                lastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                password = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                phoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                emailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                addressLine1 = Convert.ToString(DB.DataTable.Rows[0]["AddressLine1"]);
                addressLine2 = Convert.ToString(DB.DataTable.Rows[0]["AddressLine2"]);
                postCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                town = Convert.ToString(DB.DataTable.Rows[0]["Town/City"]);
                userName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public bool Valid(string FirstName, string LastName, string AddressLine1, string AddressLine2, string Town, string PostCode, string EmailAddress, string UserName, string Password)
        {
            //create a Boolean variable to flag the error
            Boolean OK = true;
            //if the FirstName is Blank
            if (FirstName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the first name is greater than 50 characters
            if(FirstName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the last name is blank
            if(LastName.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the last name is greater than 50 characters
            if (LastName.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the last name is blank
            if (AddressLine1.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the last name is greater than 50 characters
            if (AddressLine1.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the last name is blank
            if (AddressLine2.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the last name is greater than 50 characters
            if (AddressLine2.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the last name is blank
            if (Town.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the last name is greater than 50 characters
            if (Town.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }
           
            //return the value Ok
            return OK;


        }
    }
}
