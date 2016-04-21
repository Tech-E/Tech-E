using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tech_E_UnitTestProject
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void ProductInstanceOK()
        {
            //create an instance of the product class
            clsProduct TestProduct = new clsProduct();
            //test to see that exists
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
        public void ProductNo()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create some test data to assign to the property
            int ProductNumber = 1;
            //assign the data to the property
            AProduct.ProductNo = ProductNumber;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductNo, ProductNumber);
        }

        [TestMethod]
        public void ProductName()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create some test data to assign to the property
            string AProductName = "Monitor";
            //assign the data to the property
            AProduct.ProductName = AProductName;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductName, AProductName);
        }
              

        [TestMethod]
        public void ProductDescription()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create test data 
            string AProductDescription = "24 Inch Monitor...";
            //assign the data to the property
            AProduct.ProductDescription = AProductDescription;
            //two values are the same
            Assert.AreEqual(AProduct.ProductDescription, AProductDescription);
        }

        [TestMethod]
        public void ProductPrice()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create test data 
            decimal AProductPrice = 109;
            //assign the data to the property
            AProduct.ProductPrice = AProductPrice;
            //two values are the same
            Assert.AreEqual(AProduct.ProductPrice, AProductPrice);
        }

        [TestMethod]
        public void ProductManufacturer()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create test data 
            string AProductManufacturer = "Dell";
            //assign the data to the property
            AProduct.ProductManufacturer = AProductManufacturer;
            //two values are the same
            Assert.AreEqual(AProduct.ProductManufacturer, AProductManufacturer);
        }


        [TestMethod]
        public void ProductsInStock()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create test data 
            int AStock = 1;
            //assign the data to the property
            AProduct.ProductsInStock = AStock;
            //two values are the same
            Assert.AreEqual(AProduct.ProductsInStock, AStock);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductNo = 1;            
            //invoke the method
            Found = AProduct.Find(ProductNo);
            //test to see that the result is correct            
            Assert.IsTrue(Found);
        }
        

        [TestMethod]
        public void TestProductNoFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 15;
            //invoke the method
            Found = AProduct.Find(ProductNo);
            //check the product no
            if (Convert.ToInt32(AProduct.ProductNo) != 15)
            {
                OK = false;
            }
            //test to see that result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 15;
            //invoke the mothod
            Found = AProduct.Find(ProductNo);
            //chech the product name
            if (AProduct.ProductName != "Test Name")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 15;
            //invoke the mothod
            Found = AProduct.Find(ProductNo);
            //chech the address no
            if (AProduct.ProductDescription != "Mechanical Keyboard")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductPriceFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 15;
            //invoke the mothod
            Found = AProduct.Find(ProductNo);
            //chech the address no
            if (AProduct.ProductPrice != 11)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
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
