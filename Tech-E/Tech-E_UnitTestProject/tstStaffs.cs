using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tech_E_ClassLibrary;

namespace Tech_E_UnitTestProject
{
    [TestClass]
    public class tstStaffs
    {
        [TestMethod]
        public void StaffInstanceOk()
        {
            //create an instance
            clsStaff clsstaff = new clsStaff();
            //test to see that exists
            Assert.IsNotNull(clsstaff);
        }

        [TestMethod]
        public void Staffstaffid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            int Number = 1;
            //assign the data to the property
            AStaff.staffid = Number;
            //two values are the same
            Assert.AreEqual(AStaff.staffid, Number);

        }


        [TestMethod]
        public void StaffName()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            string AName = "ShiRan";
            //assign the data to the property
            AStaff.Name = AName;
            //two values are the same
            Assert.AreEqual(AStaff.Name, AName);

        }

        [TestMethod]
        public void Staffage()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            int Aage = 23;
            //assign the data to the property
            AStaff.age = Aage;
            //two values are the same
            Assert.AreEqual(AStaff.age, Aage);

        }

        [TestMethod]
        public void Staffbrief()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            string Abrief = "i am shiran lin...";
            //assign the data to the property
            AStaff.brief = Abrief;
            //two values are the same
            Assert.AreEqual(AStaff.brief, Abrief);

        }

        [TestMethod]
        public void Staffgender()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            string Agender = "gentleman";
            //assign the data to the property
            AStaff.gender = Agender;
            //two values are the same
            Assert.AreEqual(AStaff.gender, Agender);

        }


        [TestMethod]
        public void Staffmobilesphone()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            string Amobilesphone = "07832223456";
            //assign the data to the property
            AStaff.mobilesphone = Amobilesphone;
            //two values are the same
            Assert.AreEqual(AStaff.mobilesphone, Amobilesphone);

        }


        [TestMethod]
        public void Staffworkage()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            int Aworkage = 2;
            //assign the data to the property
            AStaff.workage = Aworkage;
            //two values are the same
            Assert.AreEqual(AStaff.workage, Aworkage);

        }

        [TestMethod]
        public void Staffposition()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            string Aposition = "manager";
            //assign the data to the property
            AStaff.position = Aposition;
            //two values are the same
            Assert.AreEqual(AStaff.position, Aposition);

        }



    }
}
