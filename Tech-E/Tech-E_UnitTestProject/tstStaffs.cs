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
        public void StaffstaffidPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            int Number = 1;
            //assign the data to the property
            AStaff.Staffid = Number;
            //two values are the same
            Assert.AreEqual(AStaff.Staffid, Number);

        }


        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            string AName = "ShiRan";
            //assign the data to the property
            AStaff.Staffname = AName;
            //two values are the same
            Assert.AreEqual(AStaff.Staffname, AName);

        }


        [TestMethod]
        public void StaffNameLessOne()
        {
            //create an instance of the staffname
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }

        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the staffname
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "J";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the staffname
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Je";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the staffname
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jeffe";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffNameMethodMax()
        {
            //create an instance of the staffname
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jeffer";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the staffname
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jeffers";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffNameMethodMid()
        {
            //create an instance of the staffname
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jef";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the staffname
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "";
            //pad the string with a characters
            StaffNameValid = StaffNameValid.PadRight(25, 'J');
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }


        [TestMethod]
        public void StaffagePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            int Aage = 23;
            //assign the data to the property
            AStaff.Age = Aage;
            //two values are the same
            Assert.AreEqual(AStaff.Age, Aage);

        }

        [TestMethod]
        public void StaffbriefPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            string Abrief = "i am shiran lin...";
            //assign the data to the property
            AStaff.Brief = Abrief;
            //two values are the same
            Assert.AreEqual(AStaff.Brief, Abrief);
        }


        [TestMethod]
        public void StaffbriefLessOne()
        {
            //create an instance of the Staffbrief
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }

        [TestMethod]
        public void StaffbriefMin()
        {
            //create an instance of the Staffbrief
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void StaffbriefMinPlusOne()
        {
            //create an instance of the Staffbrief
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i ";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffbriefMaxLessOne()
        {
            //create an instance of the Staffbrief
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am ";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffbriefMethodMax()
        {
            //create an instance of the Staffbrief
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am j";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffbriefMaxPlusOne()
        {
            //create an instance of the Staffbrief
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am je";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffbriefMethodMid()
        {
            //create an instance of the Staffbrief
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i a";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffbriefExtremeMax()
        {
            //create an instance of the Staffbrief
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "";
            //pad the string with a characters
            BriefValid = BriefValid.PadRight(51, 'I');
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }


        [TestMethod]
        public void StaffgenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            string Agender = "gentleman";
            //assign the data to the property
            AStaff.Gender = Agender;
            //two values are the same
            Assert.AreEqual(AStaff.Gender, Agender);

        }


        [TestMethod]
        public void StaffgenderLessOne()
        {
            //create an instance of the Staffgender
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }

        [TestMethod]
        public void StaffgenderMin()
        {
            //create an instance of the Staffgender
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "w";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void StaffgenderMinPlusOne()
        {
            //create an instance of the Staffgender
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "wo";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffgenderMaxLessOne()
        {
            //create an instance of the Staffgender
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "woman";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffgenderMethodMax()
        {
            //create an instance of the Staffgender
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "woman ";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffgenderMaxPlusOne()
        {
            //create an instance of the Staffgender
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "woman  ";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffgenderMethodMid()
        {
            //create an instance of the Staffgender
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "wom";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffgenderExtremeMax()
        {
            //create an instance of the Staffgender
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "";
            //pad the string with a characters
            GenderValid = GenderValid.PadRight(8, 'w');
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }


        [TestMethod]
        public void StaffmobilesphonePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            string Amobilesphone = "07832223456";
            //assign the data to the property
            AStaff.Mobilesphone = Amobilesphone;
            //two values are the same
            Assert.AreEqual(AStaff.Mobilesphone, Amobilesphone);

        }

        [TestMethod]
        public void StaffmobilesphoneLessOne()
        {
            //create an instance of the Staffmobilesphone
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }

        [TestMethod]
        public void StaffmobilesphoneMin()
        {
            //create an instance of the Staffmobilesphone
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "0";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void StaffmobilesphoneMinPlusOne()
        {
            //create an instance of the Staffmobilesphone
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffmobilesphoneMaxLessOne()
        {
            //create an instance of the Staffmobilesphone
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffmobilesphoneMethodMax()
        {
            //create an instance of the Staffmobilesphone
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "078333";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffmobilesphoneMaxPlusOne()
        {
            //create an instance of the Staffmobilesphone
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "0783332";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffmobilesphoneMethodMid()
        {
            //create an instance of the Staffmobilesphone
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "078";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffmobilesphoneExtremeMax()
        {
            //create an instance of the Staffmobilesphone
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "";
            //pad the string with a characters
            MobilesphoneValid = MobilesphoneValid.PadRight(12, '0');
            string PositionValid = "manager";
            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }

        [TestMethod]
        public void StaffworkagePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            int Aworkage = 2;
            //assign the data to the property
            AStaff.Workage = Aworkage;
            //two values are the same
            Assert.AreEqual(AStaff.Workage, Aworkage);

        }

        [TestMethod]
        public void StaffworkageLessOne()
        {
            //create an instance of the Staffworkage
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }

        [TestMethod]
        public void StaffworkageMin()
        {
            //create an instance of the staffname
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the Staffworkage
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            int workage = 1;
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid, workage);
            //test to see that results is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void StaffworkageMinPlusOne()
        {
            //create an instance of the Staffworkage
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            int workage = 2;
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid, workage);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffworkageMaxLessOne()
        {
            //create an instance of the Staffworkage
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            int workage = 3;
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid, workage);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffworkageMethodMax()
        {
            //create an instance of the Staffworkage
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            int workage = 4;
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid, workage);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffworkageMaxPlusOne()
        {
            //create an instance of the Staffworkage
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            int workage = 5;
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid, workage);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffworkageMethodMid()
        {
            //create an instance of the Staffworkage
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            int workage = 6;
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid, workage);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffworkageExtremeMax()
        {
            //create an instance of the Staffworkage
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            int workage = 50;
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid, workage);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }


        [TestMethod]
        public void StaffpositionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Create test data 
            string Aposition = "manager";
            //assign the data to the property
            AStaff.Position = Aposition;
            //two values are the same
            Assert.AreEqual(AStaff.Position, Aposition);

        }



        [TestMethod]
        public void StaffpositionLessOne()
        {
            //create an instance of the Staffposition
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }

        [TestMethod]
        public void StaffpositionMin()
        {
            //create an instance of the Staffposition
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "m";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void StaffpositionMinPlusOne()
        {
            //create an instance of the Staffposition
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "ma";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffpositionMaxLessOne()
        {
            //create an instance of the Staffposition
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manag";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffpositionMethodMax()
        {
            //create an instance of the Staffposition
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manage";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffpositionMaxPlusOne()
        {
            //create an instance of the Staffposition
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jeffers";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "manager";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffpositionMethodMid()
        {
            //create an instance of the Staffposition
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "man";

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void StaffpositionExtremeMax()
        {
            //create an instance of the Staffposition
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Ok = false;
            //some string test data to assign the property
            string StaffNameValid = "Jefferson";
            string BriefValid = "i am jefferson";
            string GenderValid = "man";
            string MobilesphoneValid = "07833324651";
            string PositionValid = "";
            //pad the string with a characters
            PositionValid = PositionValid.PadRight(11, 'm');

            //invoke the method 
            Ok = AStaff.Valid(StaffNameValid, BriefValid, GenderValid, MobilesphoneValid, PositionValid);
            //test to see that results is correct
            Assert.IsFalse(Ok);

        }






    }
}
