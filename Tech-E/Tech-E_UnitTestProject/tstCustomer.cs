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
        public void InstanceOK()

        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exits
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerNo()
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
        public void FirstName()
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
        public void LastName()
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

    }
}
