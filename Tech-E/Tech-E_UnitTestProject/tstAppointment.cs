using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tech_E_ClassLibrary;

namespace Tech_E_UnitTestProject
{
    [TestClass]
    public class tstAppointment
    {
        // Start Lead Programmer nas 09/02/2016

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAppointments TestAppointments = new clsAppointments();
            //test to see that it exits
            Assert.IsNotNull(TestAppointments);
        }

        [TestMethod]
        public void AppointmentID()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //Create some test data to assign to the property
            int Number = 1;
            //assign the data to the property
            AnAppointment.AppointmentID = Number;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.AppointmentID, Number);
        }

        [TestMethod]
        public void AppointmentLocation()
        {
            //create an instance of the class we want to create
            clsAppointments AnAppointment = new clsAppointments();
            //Create some test data to assign to the property
            string AnAppointmentLocation = "Office";
            //assign the data to the property
            AnAppointment.AppointmentLocation = AnAppointmentLocation;
            //test to see that the two values are the same
            Assert.AreEqual(AnAppointment.AppointmentLocation, AnAppointmentLocation);

        }
              
        [TestMethod]
        public void AppointmentDate()
        {
            //create an instance of the paymentmethod
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAppointment.AppointmentDate = TestData;
            Assert.AreEqual(AnAppointment.AppointmentDate, TestData);
        }

        [TestMethod]
        public void AppointmentTime()
        {
            //create an instance of the paymentmethod
            clsAppointments AnAppointment = new clsAppointments();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAppointment.AppointmentTime = TestData;
            Assert.AreEqual(AnAppointment.AppointmentTime, TestData);
        }

        // Finish Lead Programmer 09/02/2016
        [TestClass]
        public class tstAppointments
        {

            
            [TestMethod]
            public void ActivePropertyOK()
            {
                //create and instance of the class we want to create
                clsAppointments AnAppointment = new clsAppointments();
                //create some test data to assign to the property
                Boolean TestData = true;
                AnAppointment.Active = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnAppointment.Active, TestData);
            }


            [TestMethod]
            public void AppointmentsLocationOK()
            {
                clsAppointments TestAppointments = new clsAppointments();
                string TestData = "Loughborough";
                TestAppointments.AppointmentLocation = TestData;
                Assert.AreEqual(TestAppointments.AppointmentLocation, TestData);
            }

            [TestMethod]
            public void AppointmentDatePropertyOK()
            {
                //create and instance of the class we want to create
                clsAppointments AnAppointment = new clsAppointments();
                //create some teest data to assign to the property
                DateTime TestData = DateTime.Now.Date;
                //Assign the Data to the property
                AnAppointment.AppointmentDate = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnAppointment.AppointmentDate, TestData);

            }
            [TestMethod]
            public void AppointmentIDPropertyOK()
            {
                clsAppointments AnAppointment = new clsAppointments();
                Int32 TestData = 1;
                AnAppointment.AppointmentID = TestData;
                Assert.AreEqual(AnAppointment.AppointmentID, TestData);
            }

            [TestMethod]
            public void AppointmentIDExtremeMin()
            {
                clsAppointments TestAppointmentID = new clsAppointments();
                Boolean OK = TestAppointmentID.Valid(-2147483647);
                Assert.IsFalse(OK);
            }

            [TestMethod]
            public void AppointmentIDMinusOne()
            {
                clsAppointments TestAppointmentID = new clsAppointments();
                Boolean OK = TestAppointmentID.Valid(-1);
                Assert.IsFalse(OK);
            }

            [TestMethod]
            public void AppointmentIDMinBoundary()
            {
                clsAppointments TestAppointmentID = new clsAppointments();
                Boolean OK = TestAppointmentID.Valid(1);
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void AppointmentIDMinPlusOne()
            {
                clsAppointments TestAppointmentID = new clsAppointments();
                Boolean OK = TestAppointmentID.Valid(2);
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void AppointmentIDMaxMinusOne()
            {
                clsAppointments TestAppointmentID = new clsAppointments();
                Boolean OK = TestAppointmentID.Valid(2147483646);
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void AppointmentIDMaxBoundary()
            {
                clsAppointments TestAppointmentID = new clsAppointments();
                Boolean OK = TestAppointmentID.Valid(2147483647);
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void AppointmentIDMid()
            {
                clsAppointments TestAppointmentID = new clsAppointments();
                Boolean OK = TestAppointmentID.Valid(1013741824);
                Assert.IsTrue(OK);
            }




            [TestMethod]
            public void AppointmentLocationMinBoundary()
            {
                clsAppointments TestAppointmentLocation = new clsAppointments();
                Boolean OK = TestAppointmentLocation.ValidString("L");
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void AppointmentLocationMinPlusOne()
            {
                clsAppointments TestAppointmentLocation = new clsAppointments();
                Boolean OK = TestAppointmentLocation.ValidString("Lo");
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void AppointmentLocationMaxMinusOne()
            {
                clsAppointments TestAppointmentLocation = new clsAppointments();
                Boolean OK = TestAppointmentLocation.ValidString("LoughboroughLoughboroug");
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void AppointmentLocationBoundary()
            {
                clsAppointments TestAppointmentLocation = new clsAppointments();
                Boolean OK = TestAppointmentLocation.ValidString("LoughboroughLoughborough");
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void AppointmentLocationMid()
            {
                clsAppointments TestAppointmentLocation = new clsAppointments();
                Boolean OK = TestAppointmentLocation.ValidString("LoughboroughLo");
                Assert.IsTrue(OK);
            }

            //APPOINTMENTDATE
            

            [TestMethod]
            public void AppointmentDateMinBoundary()
            {
                //create an instance of the paymentmethod
                clsAppointments AnAppointment = new clsAppointments();
                //boolean variable to store the result of the validation
                Boolean OK = false;
                //create some test data to pass to the method
                string AppointmentLocation = "Loughborough";
                //create a variable to store the test date data
                DateTime TestDate;
                //set todays date
                TestDate = DateTime.Now.Date;
                //convert the date to a string variable
                string AppointmentDate = TestDate.ToString();
                //invoke the method
                OK = AnAppointment.Valid(AppointmentLocation, AppointmentDate);
                //test to see that result is correct
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void AppointmentDateMinPlusOne()
            {
                //create an instance of the paymentmethod
                clsAppointments AnAppointment = new clsAppointments();
                //boolean variable to store the result of the validation
                Boolean OK = false;
                //create some test data to pass to the method
                string AppointmentLocation = "Loughborough";
                //create a variable to store the test date data
                DateTime TestDate;
                //set todays date
                TestDate = DateTime.Now.Date;
                //change the date to whatever the date is less 100 years
                TestDate = TestDate.AddDays(1);
                //convert the date to a string variable
                string AppointmentDate = TestDate.ToString();
                //invoke the method
                OK = AnAppointment.Valid(AppointmentLocation, AppointmentDate);
                //test to see that result is correct
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void AppointmentDateMax()
            {
                //create an instance of the paymentmethod
                clsAppointments AnAppointment = new clsAppointments();
                //boolean variable to store the result of the validation
                Boolean OK = false;
                //create some test data to pass to the method
                string AppointmentLocation = "Loughborough";
                //create a variable to store the test date data
                DateTime TestDate;
                //set todays date
                TestDate = DateTime.Now.Date;
                //change the date to whatever the date is less 100 years
                TestDate = TestDate.AddYears(100);
                //convert the date to a string variable
                string AppointmentDate = TestDate.ToString();
                //invoke the method
                OK = AnAppointment.Valid(AppointmentLocation, AppointmentDate);
                //test to see that result is correct
                Assert.IsTrue(OK);
            }


            [TestMethod]
            public void AppointmentLocationInvalidDataType()
            {
                clsAppointments TestAppointmentLocation = new clsAppointments();
                Boolean OK = TestAppointmentLocation.ValidString(null);
                Assert.IsFalse(OK);
            }

            [TestMethod]
            public void FindMethodOK()
            {
                clsAppointments AnAppointment = new clsAppointments();
                Boolean Found = false;
                Int32 AppointmentID = 2;
                Found = AnAppointment.Find(AppointmentID);
                Assert.IsTrue(Found);
            }                        

            [TestMethod]
            public void TestAppointmentIDFound()
            {
                clsAppointments AnAppointment = new clsAppointments();
                Boolean Found = false;
                Boolean OK = true;
                Int32 AppointmentID = 2;
                Found = AnAppointment.Find(AppointmentID);
                if (AnAppointment.AppointmentID != 2)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void AppointmentLocationFound()
            {
                //create an instance of the class we want to create
                clsAppointments AnAppointment = new clsAppointments();
                //Boolean variable to store the result of the validation
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 AppointmentID = 1;
                //invoke the mothod
                Found = AnAppointment.Find(AppointmentID);
                //chech the address no
                if (AnAppointment.AppointmentLocation != "Office")
                {
                    OK = false;
                }
                //test to see if the result is correct
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void AppointmentDate()
            {
                //create an instance of the paymentmethod
                clsAppointments Apayment = new clsAppointments();
                //create some test data to assign to the property 
                DateTime TestData = DateTime.Now.Date;
                //assign the data to the property
                Apayment.AppointmentDate = TestData;
                Assert.AreEqual(Apayment.AppointmentDate, TestData);
            }
            

            [TestMethod]
            public void AppointmentValidMethodOK()
            {
                //create an instance of the class we want to create
                clsAppointments AnAppointment = new clsAppointments();
                //Boolean variable to store the result of the validation
                Boolean OK = false;
                //create some test data to use with the method
                String AppointmentLocation = "Office";
                //create a variable to store the test date data
                DateTime TestDate;
                //set todays date
                TestDate = DateTime.Now.Date;
                //convert the date to a string variable
                string AppointmentDate = TestDate.ToString();
                //invoke the method
                OK = AnAppointment.Valid(AppointmentLocation, AppointmentDate);
                //test to see if the result is correct
                Assert.IsTrue(OK);
            }
        }
    }
}
