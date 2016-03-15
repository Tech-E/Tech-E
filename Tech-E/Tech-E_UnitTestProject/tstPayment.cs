using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tech_E_ClassLibrary;

namespace Tech_E_UnitTestProject
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the payment class
            clsPayment Apayment = new clsPayment();
            //test to see that exists
            Assert.IsNotNull(Apayment);
        }

        [TestMethod]
        public void PaymentMethod()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //create some test data to assign to the property 
            string SomePaymentMethod = "Paypal";
            //assign the data to the property
            Apayment.PaymentMethod = SomePaymentMethod;
            //test to see that the two values are the same
            Assert.AreEqual(Apayment.PaymentMethod, SomePaymentMethod);
        }
        [TestMethod]
        public void PaymentMethodLessOne()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string SomePaymentMethod = "";
            //invoke the method 
            Ok = Apayment.Valid(SomePaymentMethod);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }
        [TestMethod]
        public void PaymentMethodMin()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string SomePaymentMethod = "P";
            //invoke the method 
            Ok = Apayment.Valid(SomePaymentMethod);
            //test to see that results is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void PaymentMethodMinPlusOne()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string SomePaymentMethod = "Pa";
            //invoke the method 
            Ok = Apayment.Valid(SomePaymentMethod);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void PaymentMethodMaxLessOne()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string SomePaymentMethod = "Paypa";
            //invoke the method 
            Ok = Apayment.Valid(SomePaymentMethod);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void PaymentMethodMax()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string SomePaymentMethod = "Paypal";
            //invoke the method 
            Ok = Apayment.Valid(SomePaymentMethod);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void PaymentMethodMaxPlusOne()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string SomePaymentMethod = "Paypall";
            //invoke the method 
            Ok = Apayment.Valid(SomePaymentMethod);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }
        [TestMethod]
        public void PaymentMethodMid()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string SomePaymentMethod = "Pay";
            //invoke the method 
            Ok = Apayment.Valid(SomePaymentMethod);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void PaymentMethodExtremeMax()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string SomePaymentMethod = "";
            //pad the string with a characters
            SomePaymentMethod = SomePaymentMethod.PadRight(23, 'p');
            //invoke the method 
            Ok = Apayment.Valid(SomePaymentMethod);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }

        [TestMethod]
        public void PaymentDate()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            Apayment.Dateadded = TestData;
            Assert.AreEqual(Apayment.Dateadded, TestData);
        }

        [TestMethod]
        public void PaymentNo()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //create some test data assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            Apayment.PaymentNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Apayment.PaymentNo, TestData);

        }

        [TestMethod]
        public void Amount()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //create some test data assign to the property
            Int32 TestData = 200;
            //assign the data to the property
            Apayment.Amount = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Apayment.Amount, TestData);

        }
        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 PaymentNo = 2;
            //invoke the method
            Found = Apayment.Find(PaymentNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPaymentNoFound()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is Ok 
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 PaymentNo = 32;
            //invoke the meothod
            Found = Apayment.Find(PaymentNo);
            //check the paymentNo
            if (Apayment.PaymentNo != 21)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);

        }
    }
}