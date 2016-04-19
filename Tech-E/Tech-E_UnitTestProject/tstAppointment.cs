using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tech_E_ClassLibrary;

namespace Tech_E_UnitTestProject
{
    [TestClass]
    public class tstAppointment
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
        [TestClass]
        public class tstAppointments
        {

            [TestMethod]
            public void InstanceOK()
            {
                clsAppointments TestAppointments = new clsAppointments();
                Assert.IsNotNull(TestAppointments);
            }


            [TestMethod]
            public void AppointmentsOK()
            {
                clsAppointments TestAppointments = new clsAppointments();
                string TestData = "Loughborough";
                TestAppointments.AppointmentLocation = TestData;
                Assert.AreEqual(TestAppointments.AppointmentLocation, TestData);
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
                Int32 AppointmentID = 21;
                Found = AnAppointment.Find(AppointmentID);
                if (AnAppointment.AppointmentID != 21)
                {
                    OK = false;
                }
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
                Apayment.Dateadded = TestData;
                Assert.AreEqual(Apayment.Dateadded, TestData);
            }
        }
    }
}
