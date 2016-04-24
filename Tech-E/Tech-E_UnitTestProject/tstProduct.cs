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
            int ProductNumber = 2;
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
        public void ProductType()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create some test data to assign to the property
            string AProductType = "Mouse";
            //assign the data to the property
            AProduct.ProductType = AProductType;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductType, AProductType);
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
            Int32 ProductNo = 2;            
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
            Int32 ProductNo = 2;
            //invoke the method
            Found = AProduct.Find(ProductNo);
            //check the product no
            if (Convert.ToInt32(AProduct.ProductNo) != 2)
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
            Int32 ProductNo = 2;
            //invoke the mothod
            Found = AProduct.Find(ProductNo);
            //check the product name
            if (AProduct.ProductName != "Acer Monitor")
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
            Int32 ProductNo = 1;
            //invoke the method
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
            int ProductNo = 2;
            //invoke the mothod
            Found = AProduct.Find(ProductNo);
            //chech the address no
            if (AProduct.ProductPrice != 99)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        
        [TestMethod]
        public void TestProductManufacturerFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 2;
            //invoke the mothod
            Found = AProduct.Find(ProductNo);
            //chech the address no
            if (AProduct.ProductManufacturer != "Acer")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductsInStockFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 1;
            //invoke the mothod
            Found = AProduct.Find(ProductNo);
            //chech the address no
            if (AProduct.ProductsInStock != 8)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductValidMethodOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "AJazz Keyboard";
            String ProductType = "Keyboard";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the method
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        //PRODUCTNAME MIN/MAX TESTING ETC
        //PRODUCTNAME MIN/MAX TESTING ETC

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            String ProductType = "Keyboard";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductNameMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "A";
            String ProductType = "Keyboard";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMinPlus()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "Aa";
            String ProductType = "Keyboard";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            ProductName = ProductName.PadRight(49, 'a');
            String ProductType = "Keyboard";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            ProductName = ProductName.PadRight(50, 'a');
            String ProductType = "Keyboard";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            ProductName = ProductName.PadRight(25, 'a');
            String ProductType = "Keyboard";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            ProductName = ProductName.PadRight(51, 'a');
            String ProductType = "Keyboard";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            ProductName = ProductName.PadRight(500, 'a');
            String ProductType = "Keyboard";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }


        //PRODUCTTYPE MIN/MAX TESTING ETC
        //PRODUCTTYPE MIN/MAX TESTING ETC

        [TestMethod]
        public void ProductTypeMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            String ProductType = "";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductTypeMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "AJazz Keyboard";
            String ProductType = "K";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductTypeMinPlus()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "Aa";
            String ProductType = "K";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductTypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "AJazz";            
            String ProductType = "";
            ProductType = ProductType.PadRight(49, 'k');
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductTypeMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "AJazz";
            String ProductType = "";
            ProductType = ProductType.PadRight(50, 'k');
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductTypeMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "AJazz";            
            String ProductType = "Keyboard";
            ProductType = ProductType.PadRight(25, 'k');
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductTypeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            String ProductType = "";
            ProductType = ProductType.PadRight(51, 'k');
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductTypeExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            String ProductType = "";
            ProductType = ProductType.PadRight(500, 'k');
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        //PRODUCTDESCRIPTION MIN/MAX TESTING ETC
        //PRODUCTDESCRIPTION MIN/MAX TESTING ETC

        [TestMethod]
        public void ProductDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            String ProductType = "";
            String ProductDescription = "";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductDescriptioneMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "AJazz Keyboard";
            String ProductType = "K";
            String ProductDescription = "M";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductDescriptionMinPlus()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "Aa";
            String ProductType = "K";
            String ProductDescription = "Me";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "AJazz";
            String ProductType = "Keyboard";            
            String ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(299, 'm');
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductDescriptionMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "AJazz";
            String ProductType = "Keyboard";            
            String ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(300, 'm');
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductDescriptionMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "AJazz";
            String ProductType = "Keyboard";            
            String ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(25, 'k');
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductDescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            String ProductType = "";            
            String ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(51, 'k');
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductDescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            String ProductType = "";            
            String ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(500, 'k');
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        //PRODUCTTYPE MIN/MAX TESTING ETC
        //PRODUCTTYPE MIN/MAX TESTING ETC

        [TestMethod]
        public void ProductPriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            String ProductType = "";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = -1;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductPriceMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "AJazz Keyboard";
            String ProductType = "K";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 1;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductPriceMinPlus()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "Aa";
            String ProductType = "K";
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 2;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductPriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "AJazz";
            String ProductType = "";
            ProductType = ProductType.PadRight(49, 'k');
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 66666;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductPriceMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "AJazz";
            String ProductType = "";
            ProductType = ProductType.PadRight(50, 'k');
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductPriceMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "AJazz";
            String ProductType = "Keyboard";
            ProductType = ProductType.PadRight(25, 'k');
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductPriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            String ProductType = "";
            ProductType = ProductType.PadRight(51, 'k');
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ProductPriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to use with the method
            String ProductName = "";
            String ProductType = "";
            ProductType = ProductType.PadRight(500, 'k');
            String ProductDescription = "Mechanical Keyboard";
            Decimal ProductPrice = 6;
            String ProductManufacturer = "AJazz";
            Int32 ProductsInStock = 8;
            //invoke the mothod
            OK = AProduct.Valid(ProductName, ProductType, ProductDescription, ProductPrice, ProductManufacturer,
                                 ProductsInStock);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }


        /*[TestMethod]
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
        }*/
    }
}
