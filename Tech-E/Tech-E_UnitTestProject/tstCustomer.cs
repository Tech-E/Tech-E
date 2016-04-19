using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tech_E_ClassLibrary;

namespace Tech_E_UnitTestProject
{
    [TestClass]
    public class tstCustomer
    {
        // Start Lead Programmer 09/02/2016
        [TestMethod]
        public void CustInstanceOK()

        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exits
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustCustomerNo()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            int Number = 1;
            //assign the data to the property
            ACustomer.CustomerNo = Number;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerNo, Number);

        }

        [TestMethod]
        public void CustFirstName()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string AFirstName = "Peter";
            //assign the data to the property
            ACustomer.FirstName = AFirstName;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, AFirstName);
        }

        [TestMethod]
        public void CustLastName()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string ALastName = "Peter";
            //assign the data to the property
            ACustomer.LastName = ALastName;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.LastName, ALastName);

        }
        // Finish Lead Programmer 09/02/2016

        [TestMethod]
        public void CustPassword()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string APassword = "Peter";
            //assign the data to the property
            ACustomer.Password = APassword;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Password, APassword);
        }

        [TestMethod]
        public void CustPhoneNo()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            Int64 PhoneNumber = 1;
            //assign the data to the property
            ACustomer.PhoneNo = PhoneNumber;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNo, PhoneNumber);

        }

        [TestMethod]
        public void CustEmailAddress()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string AEmailAddress = "Peter@Peter.co.uk";
            //assign the data to the property
            ACustomer.EmailAddress = AEmailAddress;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.EmailAddress, AEmailAddress);

        }

        [TestMethod]
        public void CustAddressLine1()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string AAddressLine1 = "1 Fake Lane";
            //assign the data to the property
            ACustomer.AddressLine1 = AAddressLine1;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.AddressLine1, AAddressLine1);

        }

        [TestMethod]
        public void CustAddressLine2()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string AAddressLine2 = "Thamesmead";
            //assign the data to the property
            ACustomer.AddressLine2 = AAddressLine2;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.AddressLine2, AAddressLine2);

        }

        [TestMethod]
        public void CustPostCode()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string APostcode = "SE28 8EU";
            //assign the data to the property
            ACustomer.Postcode = APostcode;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Postcode, APostcode);

        }


        [TestMethod]
        public void CustTown ()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string ATown = "London";
            //assign the data to the property
            ACustomer.Town = ATown;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Town, ATown);

        }

        [TestMethod]
        public void CustUserName()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string AUserName = "topdog5000";
            //assign the data to the property
            ACustomer.UserName = AUserName;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.UserName, AUserName);

        }

        [TestMethod]
        public void CustFindMethod()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the mothod
            Found = ACustomer.Find(CustomerNo);
            //test to see if the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void CustCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the mothod
            Found = ACustomer.Find(CustomerNo);
            //chech the address no
            if (ACustomer.CustomerNo != 21)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the mothod
            Found = ACustomer.Find(CustomerNo);
            //chech the address no
            if (ACustomer.FirstName != "Peter")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the mothod
            Found = ACustomer.Find(CustomerNo);
            //chech the address no
            if (ACustomer.LastName != "Anderson")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the mothod
            Found = ACustomer.Find(CustomerNo);
            //chech the address no
            if (ACustomer.Password != "password")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the mothod
            Found = ACustomer.Find(CustomerNo);
            //chech the address no
            if (ACustomer.PhoneNo != 07123123123)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustEmailAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the mothod
            Found = ACustomer.Find(CustomerNo);
            //chech the address no
            if (ACustomer.EmailAddress != "test@email.com")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustAddressLine1Found()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the mothod
            Found = ACustomer.Find(CustomerNo);
            //chech the address no
            if (ACustomer.AddressLine1 != "Test Street")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustAddressLine2Found()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the mothod
            Found = ACustomer.Find(CustomerNo);
            //chech the address no
            if (ACustomer.AddressLine2 != "Test Street")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
    }
}
