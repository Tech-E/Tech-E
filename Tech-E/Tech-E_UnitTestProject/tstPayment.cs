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
            Int32 PaymentNo = 222;
            //invoke the method
            Found = Apayment.Find(PaymentNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "25";
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void PaymentNoMinLessOne()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "fg"; // this should trigger a error
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void PaymentNoMin()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "q";
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void PaymentNoMinPlusOne()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "qa";
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void PaymentNoMaxLessOne()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "qarti";
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void PaymentNoMax()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "qartil";
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void PaymentNoMid()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "qar";
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void PaymentNoMaxPlusOne()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "qartil"; //this should fail
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void PaymentNoExtremeMax()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = ""; //this should fail
            PaymentNo = PaymentNo.PadRight(1, 'q');
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            string DateAdded = DateTime.Now.Date.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "25";
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //set todays date
            TestDate = DateTime.Now.Date;
            //convert the date to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "25";
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //set todays date
            TestDate = DateTime.Now.Date;
            //convert the date to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "25";
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //set todays date
            TestDate = DateTime.Now.Date;
            //convert the date to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "25";
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //set todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(1);
            //convert the date to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "25";
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //set todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the paymentmethod
            clsPayment Apayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to pass to the method
            string PaymentNo = "25";
            string Amount = "69.99";
            string PaymentMethod = "Debit Card";
            //set data added to a non value
            string DateAdded = "";
            //invoke the method
            OK = Apayment.Valid(PaymentNo, Amount, PaymentMethod, DateAdded);
            //test to see that result is correct
            Assert.IsTrue(OK);
        }
    }
}