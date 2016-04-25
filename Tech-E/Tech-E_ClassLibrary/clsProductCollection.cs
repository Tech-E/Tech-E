using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tech_E_UnitTestProject;

namespace Tech_E_ClassLibrary
{
        public class clsProductCollection
        {

            //private data member for the list
            List<clsProduct> productList = new List<clsProduct>();


            public List<clsProduct> ProductList
            {
                get
                {
                    //return the private data
                    return productList;
                }
                set
                {
                    //set the private data
                    productList = value;
                }
            }

            public int Count
            {
                get
                {
                    //return the count of the list
                    return productList.Count;
                }
                set
                {
                    //we shall worry about this later
                }
            }

            public clsProductCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to proccess
            while (Index < RecordCount)
            {
                //create a blank customer
                clsProduct AProduct = new clsProduct();
            //    //read in the fields from the current record               
                AProduct.ProductNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductNo"]);
                AProduct.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AProduct.ProductType = Convert.ToString(DB.DataTable.Rows[Index]["ProductType"]);
                AProduct.ProductDescription = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescription"]);
                AProduct.ProductPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ProductPrice"]);
                AProduct.ProductManufacturer = Convert.ToString(DB.DataTable.Rows[Index]["ProductManufacturer"]);
                AProduct.ProductsInStock = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductsInStock"]);
            //    //add the record to the private data member
                productList.Add(AProduct);
            //    //point at the next record
                Index++;
            }
        }

            public Tech_E_UnitTestProject.clsProduct ThisProduct { get; set; }
                        
        }
    }

