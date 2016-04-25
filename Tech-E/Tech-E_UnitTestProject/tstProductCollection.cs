using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tech_E_ClassLibrary;
using System.Collections.Generic;

namespace Tech_E_UnitTestProject
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //test to see that it exists
            Assert.IsNotNull(AllProducts);
        }

        [TestMethod]
        public void ProductListOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item of the test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.ProductNo = 1;
            TestItem.ProductName = "AJazz Keyboard";
            TestItem.ProductType = "Keyboard";
            TestItem.ProductDescription = "Mechanical Keyboard";
            TestItem.ProductPrice = 6;
            TestItem.ProductManufacturer = "AJazz";
            TestItem.ProductsInStock = 8;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductList, TestList);
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
        public void ThisProductPropertyOK()
        {
            //create an instance of the class that we want to create 
            clsProductCollection AllProducts = new clsProductCollection();
            //create sometest data to assign to the property
            clsProduct TestProduct = new clsProduct();
            //set the properties of the test object
            TestProduct.ProductNo = 1;
            TestProduct.ProductName = "AJazz Keyboard";
            TestProduct.ProductType = "Keyboard";
            TestProduct.ProductDescription = "Mechanical Keyboard";
            TestProduct.ProductPrice = 6;
            TestProduct.ProductManufacturer = "AJazz";
            TestProduct.ProductsInStock = 8;
            //assign the data to the property
            AllProducts.ThisProduct = TestProduct;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void ProductListAndCountOK()
        {
            //create an instance of the class that we want to create 
            clsProductCollection AllProducts = new clsProductCollection();
            //create sometest data to assign to the property
            List<clsProduct> TestList = new List<clsProduct>();
            //add an itm to the list
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //set the properties
            TestItem.ProductNo = 1;
            TestItem.ProductName = "AJazz Keyboard";
            TestItem.ProductType = "Keyboard";
            TestItem.ProductDescription = "Mechanical Keyboard";
            TestItem.ProductPrice = 6;
            TestItem.ProductManufacturer = "AJazz";
            TestItem.ProductsInStock = 8;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }

        /*[TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, 2);
        }*/

    }
}
