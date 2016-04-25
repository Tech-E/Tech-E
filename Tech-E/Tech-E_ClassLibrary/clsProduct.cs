using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tech_E_UnitTestProject
{
    public class clsProduct
    {
        //private data member for the ProductNo property
        private Int32 productNo;
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

        public Int32 ProductNo
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

        public bool FindProduct(Int32 ProductNo)
        {
            throw new NotImplementedException();
        }

               public bool Find(Int32 ProductNo)
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

              
               public bool Valid(string ProductName, string ProductType, string ProductDescription, decimal ProductPrice, string ProductManufacturer, int ProductsInStock)
               {
                   //create a Boolean variable to flag the error
                   Boolean OK = true;

                   if (ProductPrice > 50000)
                   {
                       OK = false;
                   }

                   if (ProductPrice == 0)
                   {
                       OK = false;
                   }

                   if (ProductsInStock > 1000)
                   {
                       OK = false;
                   }

                   if (ProductsInStock == 0)
                   {
                       OK = false;
                   }

                   //if the ProductName is Blank
                   if (ProductName.Length == 0)
                   {
                       //set the flag OK to false
                       OK = false;
                   }
                   //if the Productname is greater than 50 characters
                   if (ProductName.Length > 50)
                   {
                       //set the flag OK to false
                       OK = false;
                   }
                   //if the ProductType is blank
                   if (ProductType.Length == 0)
                   {
                       //set the flag OK to false
                       OK = false;
                   }
                   //if the ProductType is greater than 50 characters
                   if (ProductType.Length > 50)
                   {
                       //set the flag OK to false
                       OK = false;
                   }
                   //if the ProductDescription is Blank
                   if (ProductDescription.Length == 0)
                   {
                       //set the flag OK to false
                       OK = false;
                   }
                   //if the ProductDescription is greater than 50 characters
                   if (ProductDescription.Length > 300)
                   {
                       //set the flag OK to false
                       OK = false;
                   }
                   //if the ProductType is blank
                   if (ProductType.Length == 0)
                   {
                       //set the flag OK to false
                       OK = false;
                   }
                   //if the ProductType is greater than 50 characters
                   if (ProductType.Length > 50)
                   {
                       //set the flag OK to false
                       OK = false;
                   }
                   //if the ProductManufacturer is Blank
                   if (ProductManufacturer.Length == 0)
                   {
                       //set the flag OK to false
                       OK = false;
                   }
                   //if the ProductManufacturer is greater than 50 characters
                   if (ProductManufacturer.Length > 50)
                   {
                       //set the flag OK to false
                       OK = false;
                   }

                  

                   //return the value Ok
                   return OK;
               }
    }     
}
