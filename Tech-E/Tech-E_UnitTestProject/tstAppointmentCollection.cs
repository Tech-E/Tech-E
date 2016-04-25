using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tech_E_ClassLibrary;
using System.Collections.Generic;

namespace Tech_E_UnitTestProject
{
    [TestClass]
    public class tstAppointmentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAppointmentCollection AllProducts = new clsAppointmentCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAppointments);
        }

        [TestMethod]
        public void AppointmentListOK()
        {
            //create an instance of the class we want to create
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsAppointments> TestList = new List<clsAppointments>();
            //add an item to the list
            //create the item of the test data
            clsAppointments TestItem = new clsAppointments();
            //set its properties
            TestItem.AppointmentID = 1;
            TestItem.AppointmentLocation = "Office";
            TestItem.AppointmentDate = DateTime.Now;
            TestItem.AppointmentTime = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAppointments.AppointmentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.AppointmentList, TestList);
        }

        /*[TestMethod]
        public void CountProductOK()
        {
            //create an instance of the class that we want to create 
            clsProductCollection AllProducts = new clsProductCollection();
            //create sometest data to assign to the property
            Int32 SomeCount = 0;
            //assign the Data to the property
            AllProducts.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisAppointmentPropertyOK()
        {
            //create an instance of the class that we want to create 
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //create sometest data to assign to the property
            clsAppointments TestAppointment = new clsAppointments();
            //set the properties of the test object
            TestAppointment.AppointmentID = 1;
            TestAppointment.AppointmentLocation = "Office";
            TestAppointment.AppointmentDate = DateTime.Now;
            TestAppointment.AppointmentTime = DateTime.Now;
            //assign the data to the property
            AllAppointments.ThisAppointment = TestAppointment;
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.ThisAppointment, TestAppointment);
        }

        [TestMethod]
        public void AppointmentListAndCountOK()
        {
            //create an instance of the class that we want to create 
            clsAppointmentCollection AllAppointments = new clsAppointmentCollection();
            //create sometest data to assign to the property
            List<clsAppointments> TestList = new List<clsAppointments>();
            //add an itm to the list
            //create the item of test data
            clsAppointments TestItem = new clsAppointments();
            //set the properties
            TestItem.AppointmentID = 1;
            TestItem.AppointmentLocation = "Office";
            TestItem.AppointmentDate = DateTime.Now;
            TestItem.AppointmentTime = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAppointments.AppointmentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.Count, TestList.Count);
        }

        /*[TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, 2);
        }*/


        public object AllAppointments { get; set; }
    }
}