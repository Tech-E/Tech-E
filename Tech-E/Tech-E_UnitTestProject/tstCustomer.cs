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
            Int32 Number = 1;
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
            String PhoneNumber = "07123123123";
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
            ACustomer.PostCode = APostcode;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PostCode, APostcode);

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
        public void CustFindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
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
            if (ACustomer.PhoneNo != "07123123123")
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
            if (ACustomer.AddressLine2 != "Test")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustPostCodeFound()
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
            if (ACustomer.PostCode != "T3ST P0ST")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustTownFound()
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
            if (ACustomer.Town != "Test")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustUserNameFound()
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
            if (ACustomer.UserName != "TestUserName")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test Town";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town, 
                                 PostCode,EmailAddress,UserName,Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustFirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustFirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "a";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustFirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "aa";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustFirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            String LastName = "Anderson";
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustFirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            String LastName = "Anderson";
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustFirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');
            String LastName = "Anderson";
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "";
            FirstName = FirstName.PadRight(51, 'a');
            String LastName = "Anderson";
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustFirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');
            String LastName = "Anderson";
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustLastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "";
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustLastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "a";
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustLastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "aa";
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustLastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";  
            String LastName = "";
            LastName = LastName.PadRight(49, 'a');
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustLastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "";
            LastName = LastName.PadRight(50, 'a');
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustlastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "";
            LastName = LastName.PadRight(25, 'a');
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustLastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "";
            LastName = LastName.PadRight(51, 'a');
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustLastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            LastName = LastName.PadRight(500, 'a');
            String AddressLine1 = "Test Street ";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustAddressLine1NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustAddressLine1NameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "a";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustAddressLine1MinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "aa";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustAddressLine1NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "";
            AddressLine1 = AddressLine1.PadRight(49, 'a');
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustAddressLine1Max()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "";
            AddressLine1 = AddressLine1.PadRight(50, 'a');
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustAddressLine1Mid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "";
            AddressLine1 = AddressLine1.PadRight(25, 'a');
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustAddressLine1MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "";
            AddressLine1 = AddressLine1.PadRight(51, 'a');
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustAddressLine1ExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "";
            AddressLine1 = AddressLine1.PadRight(500, 'a');
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustAddressLine2MinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustAddressLine2Min()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "a";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustAddressLine2MinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "aa";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustAddressLine2MaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "";
            AddressLine2 = AddressLine2.PadRight(49, 'a');
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustAddressLine2Max()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "";
            AddressLine2 = AddressLine2.PadRight(50, 'a');
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustAddressLine2Mid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "";
            AddressLine2 = AddressLine2.PadRight(25, 'a');
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustAddressLine2MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "";
            AddressLine2 = AddressLine2.PadRight(51, 'a');
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustAddressLine2ExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "";
            AddressLine2 = AddressLine2.PadRight(500, 'a');
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustTownMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustTownMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "a";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustTownMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "aa";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustTownNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test"; 
            String Town = "";
            Town = Town.PadRight(49, 'a');
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustTownMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "";
            Town = Town.PadRight(50, 'a');
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustTownMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "";
            Town = Town.PadRight(25, 'a');
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustTownMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "";
            Town = Town.PadRight(51, 'a');
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustTownExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "";
            Town = Town.PadRight(500, 'a');
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustPostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustPostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "a";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustPostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "aa";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustPostCodeNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "aaaaaaaa";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustPostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "aaaaaaaaa";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustPostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "aaaaa";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustPostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "aaaaaaaaaa";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustPostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "";
            PostCode = PostCode.PadRight(500, 'a');
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustEmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustEmailAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "a";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustEmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "aa";
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustEmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(49, 'a');
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustEmailAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(50, 'a');
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustEmailAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(25, 'a');
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustEmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(51, 'a');
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustEmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(500, 'a');
            String UserName = "test123";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustUserNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustUserNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "aaaaaaaa";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustUserNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "aaaaaaaaa";
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustUserNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "";
            UserName = UserName.PadRight(49, 'a');
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustUserNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "";
            UserName = UserName.PadRight(50, 'a');
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustUserNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "";
            UserName = UserName.PadRight(25, 'a');
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustUserNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "";
            UserName = UserName.PadRight(51, 'a');
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CustUserNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String FirstName = "Peter";
            String LastName = "Anderson";
            String AddressLine1 = "Test Street";
            String AddressLine2 = "Test";
            String Town = "Test";
            String PostCode = "LE3 0QT";
            String EmailAddress = "test@email.com";
            String UserName = "test123";
            UserName = UserName.PadRight(500, 'a');
            String Password = "password";
            //invoke the mothod
            OK = ACustomer.Valid(FirstName, LastName, AddressLine1, AddressLine2, Town,
                                 PostCode, EmailAddress, UserName, Password);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }
    }
}
        
 
