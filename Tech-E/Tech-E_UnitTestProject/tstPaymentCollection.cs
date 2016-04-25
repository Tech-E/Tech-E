using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tech_E_ClassLibrary;
using System.Collections.Generic;
namespace Tech_E_UnitTestProject
{
    [TestClass]
    public class tstPaymentCollection
    {
        [TestMethod]
        public void PaymentCollectionInstanceOK()
        {
            //create an instance of the class that we want to create 
            clsPaymentCollection AllPayments= new clsPaymentCollection();
            //test to see that it exists
            Assert.IsNotNull(AllPayments);
        }

        [TestMethod]
        public void PaymentListOK()
        {
            //create an instance of the class that we want to create 
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create sometest data to assign to the property
            List<clsPayment> TestList = new List<clsPayment>();
            //add an itm to the list
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //set the properties
            TestItem.PaymentNo = 1;
            TestItem.PaymentMethod = "PAYPAL";
            TestItem.Amount = 50;
            TestItem.Dateadded = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPayments.PaymentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.PaymentList, TestList);
        }

    



        [TestMethod]
        public void PaymentListAndCountOK()
        {
            //create an instance of the class that we want to create 
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create sometest data to assign to the property
            List<clsPayment> TestList = new List<clsPayment>();
            //add an itm to the list
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //set the properties
            TestItem.PaymentNo = 1;
            TestItem.PaymentMethod = "PAYPAL";
            TestItem.Amount = 50;
            TestItem.Dateadded = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPayments.PaymentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.Count, TestList.Count);
        }



    }
}
