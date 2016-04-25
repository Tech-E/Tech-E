using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tech_E_ClassLibrary;
using System.Collections.Generic;

namespace Tech_E_UnitTestProject
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void StaffInstanceOk()
        {
            //create an instance
            clsStaffCollection clsstaffcollection = new clsStaffCollection();
            //test to see that exists
            Assert.IsNotNull(clsstaffcollection);
        }


        [TestMethod]
        public void StaffAddressListOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection clsstaffcollection = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestStaffList = new List<clsStaff>();
            // add an item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Staffid = 1;
            TestItem.Staffname = "jefferson";
            TestItem.Age = 20;
            TestItem.Brief = "i am jefferson";
            TestItem.Gender = "man";
            TestItem.Mobilesphone = "083128312321";
            TestItem.Workage = 2;
            TestItem.Position = "staff";
            //add the item to the test list
            TestStaffList.Add(TestItem);
            clsstaffcollection.staffList = TestStaffList;
            Assert.AreEqual(clsstaffcollection.staffList, TestStaffList);
        }


        [TestMethod]
        public void StaffAddMethodOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection clsstaffcollection = new clsStaffCollection();
            //create some test data to assign to the property
            // add an item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Staffid = 1;
            TestItem.Staffname = "jefferson";
            TestItem.Age = 20;
            TestItem.Brief = "i am jefferson";
            TestItem.Gender = "man";
            TestItem.Mobilesphone = "083128312321";
            TestItem.Workage = 2;
            TestItem.Position = "staff";
            //set ThisStaffto the test data
            clsstaffcollection.ThisStaff = TestItem;
            //add the record
            //PrimaryKey = clsstaffcollection.AddStaff(TestItem);
            //set the primary key of the test data
            TestItem.Staffid = PrimaryKey;
            //find the record
            //clsstaffcollection.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(clsstaffcollection.ThisStaff, TestItem);
        }


        [TestMethod]
        public void StaffDeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection clsstaffcollection = new clsStaffCollection();
            //create some test data to assign to the property
            // add an item of test data
            clsStaff TestItem = new clsStaff();
            Boolean Found = false;
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Staffid = 1;
            TestItem.Staffname = "jefferson";
            TestItem.Age = 20;
            TestItem.Brief = "i am jefferson";
            TestItem.Gender = "man";
            TestItem.Mobilesphone = "083128312321";
            TestItem.Workage = 2;
            TestItem.Position = "staff";
            //set ThisStaffto the test data
            clsstaffcollection.ThisStaff = TestItem;
            //delete the record
            //PrimaryKey = clsstaffcollection.Delete(TestItem);
            //set the primary key of the test data
            TestItem.Staffid = PrimaryKey;
            //find the record
            //Found=clsstaffcollection.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void StaffUpdateMethodOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection clsstaffcollection = new clsStaffCollection();
            //create some test data to assign to the property
            // add an item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Staffid = 1;
            TestItem.Staffname = "jefferson";
            TestItem.Age = 20;
            TestItem.Brief = "i am jefferson";
            TestItem.Gender = "man";
            TestItem.Mobilesphone = "083128312321";
            TestItem.Workage = 2;
            TestItem.Position = "staff";
            //set ThisStaffto the test data
            clsstaffcollection.ThisStaff = TestItem;
            //update the record
            //PrimaryKey = clsstaffcollection.Update(TestItem);
            //set the primary key of the test data
            TestItem.Staffid = PrimaryKey;
            //find the record
            //clsstaffcollection.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(clsstaffcollection.ThisStaff, TestItem);
        }

    }
}
