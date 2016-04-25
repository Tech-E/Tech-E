using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tech_E
{
    public partial class ProductsBackEnd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                DisplayProducts();
            }
        }
        void DisplayProducts()
        {
            Tech_E_ClassLibrary.clsProductCollection Products = new Tech_E_ClassLibrary.clsProductCollection();
            lstProducts.DataSource = Products.ProductList;
            lstProducts.DataValueField = "ProductNo";
            lstProducts.DataTextField = "ProductName";
            lstProducts.DataBind();
        }
    }
}