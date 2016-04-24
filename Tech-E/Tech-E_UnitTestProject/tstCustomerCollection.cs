using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tech_E_ClassLibrary;
using System.Collections.Generic;

namespace Tech_E_UnitTestProject
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void CustCollectionInstanceOK()
        {
            //create an instance of the class that we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustCustomerListOK()
        {
            //create an instance of the class that we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create sometest data to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an itm to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set the properties
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
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void CustThisCustomerOK()
        {
            //create an instance of the class that we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create sometest data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerNo = 1;
            TestCustomer.FirstName = "Peter";
            TestCustomer.LastName = "Anderson";
            TestCustomer.AddressLine1 = "Test Street";
            TestCustomer.AddressLine2 = "Test";
            TestCustomer.Town = "Test";
            TestCustomer.PostCode = "LE3 0QT";
            TestCustomer.EmailAddress = "test@email.com";
            TestCustomer.UserName = "test123";
            TestCustomer.Password = "password";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void CustCountOK()
        {
            //create an instance of the class that we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create sometest data to assign to the property
            Int32 SomeCount = 0;
            //assign the Data to the property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

    }
}
