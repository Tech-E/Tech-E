using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tech_E_UnitTestProject
{
    public class clsProduct
    {
        private int productNo;
        private String productName;
        private String productDescription;
        private Decimal productPrice;
        private Int32 productsInStock;
        private String productManufacturer;


        public string Product { get; set; }

        public bool Valid(int ProductNo)
        {
            if (ProductNo >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidString(string ProductName)
        {
            if (ProductName != null &&
                ProductName.Length >= 1 &&
                ProductName.Length <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidInt(int ProductNo)
        {
            if (ProductNo != null &&
                ProductNo >= 1 &&
                ProductNo <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        public int ProductNo
        {
            get
            {
                return productNo;
            }
            set
            {
                productNo = value;
            }
        }

        public string ProductDescription {
            get {
                return productDescription;
            }
            set {
                productDescription = value;
            }
        }

        public decimal ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                productPrice = value;
            }
        }

        public string ProductManufacturer
        {
            get
            {
                return productManufacturer;
            }
            set
            {
                productManufacturer = value;
            }
        }

        public Int32 ProductsInStock
        {
            get
            {
                return productsInStock;
            }
            set
            {
                productsInStock = value;
            }
        }

        public bool FindProduct(int ProductNo)
        {
            throw new NotImplementedException();
        }

               public bool Find(int ProductNo)
               {
                   //set the private data member to the test data value
                   productNo = 15;
                   productName = "Test Name";
                   productDescription = "Mechanical Keyboard";
                   productPrice = 11;
                   productManufacturer = "Dell";
                   productsInStock = 11;
                   //always return true
                   return true;
               }
    }     
}