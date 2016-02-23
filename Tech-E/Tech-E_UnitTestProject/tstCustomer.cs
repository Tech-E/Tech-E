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
            int PhoneNumber = 1;
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
            string AAddressLine2 = "1 Fake Lane";
            //assign the data to the property
            ACustomer.AddressLine2 = AAddressLine2;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.AddressLine2, AAddressLine2);

        }

    }
}
