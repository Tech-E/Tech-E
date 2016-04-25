using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tech_E_ClassLibrary
{
    public class clsProductCollection
    {
        
        public List<Tech_E_UnitTestProject.clsProduct> ProductList { get; set; }

        public int Count { get; set; }

        public Tech_E_UnitTestProject.clsProduct ThisProduct { get; set; }
    }
}
