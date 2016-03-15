using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tech_E_UnitTestProject
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsProduct TestProduct = new clsProduct();
            Assert.IsNotNull(TestProduct);
        }

        [TestMethod]
        public void ProductOK()
        {
            clsProduct TestProduct = new clsProduct();
            string TestData = "Keyboards";
            TestProduct.Product = TestData;
            Assert.AreEqual(TestProduct.Product, TestData);
        }


        [TestMethod]
        public void ProductNoExtremeMin()
        {
            clsProduct TestProductNo = new clsProduct();
            Boolean OK = TestProductNo.Valid(-2147483647);
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductNoMinusOne()
        {
            clsProduct TestProductNo = new clsProduct();
            Boolean OK = TestProductNo.Valid(-1);
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductNoMinBoundary()
        {
            clsProduct TestProductNo = new clsProduct();
            Boolean OK = TestProductNo.Valid(1);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNoMinPlusOne()
        {
            clsProduct TestProductNo = new clsProduct();
            Boolean OK = TestProductNo.Valid(2);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNoMaxMinusOne()
        {
            clsProduct TestProductNo = new clsProduct();
            Boolean OK = TestProductNo.Valid(2147483646);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNoMaxBoundary()
        {
            clsProduct TestProductNo = new clsProduct();
            Boolean OK = TestProductNo.Valid(2147483647);
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNoMid()
        {
            clsProduct TestProductNo = new clsProduct();
            Boolean OK = TestProductNo.Valid(1013741824);
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ProductNameMinBoundary()
        {
            clsProduct TestProductName = new clsProduct();
            Boolean OK = TestProductName.ValidString("K");
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            clsProduct TestProductName = new clsProduct();
            Boolean OK = TestProductName.ValidString("Ke");
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMaxMinusOne()
        {
            clsProduct TestProductName = new clsProduct();
            Boolean OK = TestProductName.ValidString("Keyboards1234567890");
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMaxBoundary()
        {
            clsProduct TestProductName = new clsProduct();
            Boolean OK = TestProductName.ValidString("Keyboards12345678912");
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMid()
        {
            clsProduct TestProductName = new clsProduct();
            Boolean OK = TestProductName.ValidString("Keyboards1");
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameInvalidDataType()
        {
            clsProduct TestProductName = new clsProduct();
            Boolean OK = TestProductName.ValidString(null);
            Assert.IsFalse(OK);
        }
    }
}
