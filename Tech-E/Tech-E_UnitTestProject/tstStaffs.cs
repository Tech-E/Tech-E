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








    }
}
