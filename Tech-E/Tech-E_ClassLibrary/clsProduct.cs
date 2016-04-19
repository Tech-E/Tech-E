using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tech_E_UnitTestProject
{
    public class clsProduct
    {
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

        public string ProductName { get; set; }

        public object ProductNo { get; set; }

        public string ProductDescription { get; set; }

        public decimal ProductPrice { get; set; }

        public string ProductManufacturer { get; set; }

        private int productsInStock;
        public int ProductsInStock
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

        public bool Find(int ProductNo)
        {
            throw new NotImplementedException();
        }
    }     
}