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
    }
}