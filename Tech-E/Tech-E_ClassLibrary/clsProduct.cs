using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tech_E_UnitTestProject
{
    public class clsProduct
    {
        //private data member for the ProductNo property
        private int productNo;
        //private data member for the ProductName
        private String productName;
        //private data member for the ProductType
        private String productType;
        //private data member for the ProductDescription
        private String productDescription;
        //private data member for the ProductPrice
        private Decimal productPrice;
        //private data member for the ProductsInStock
        private Int32 productsInStock;
        //private data member for the ProductManufacturer
        private String productManufacturer;
        
        public string Product { get; set; }

        public bool Valid(Int32 ProductNo)
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

        public bool ValidInt(Int32 ProductNo)
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

        public string ProductType
        {
            get
            {
                return productType;
            }
            set
            {
                productType = value;
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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@ProductNo", ProductNo);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByProductNo");
            //if one record is found (there should either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                productNo = Convert.ToInt32(DB.DataTable.Rows[0]["ProductNo"]);
                productName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                productType = Convert.ToString(DB.DataTable.Rows[0]["ProductType"]);
                productDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                productPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ProductPrice"]);
                productManufacturer = Convert.ToString(DB.DataTable.Rows[0]["ProductManufacturer"]);
                productsInStock = Convert.ToInt32(DB.DataTable.Rows[0]["ProductsInStock"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a probelm
                return false;
            }
               }
    }     
}