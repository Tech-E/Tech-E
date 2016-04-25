using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tech_E_ClassLibrary;

namespace Tech_E
{
    public partial class ProductAddBackEnd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void Add()
        {
            clsProductCollection Products = new clsProductCollection();

            Boolean OK = Products.ThisProduct.Valid (txtProductName.Text, txtProductType.Text, txtProductDescription.Text, txtProductPrice.Text, txtProductManufacturer.Text, 
                                                        txtProductsInStock.Text);

         if (OK == true)
            {
                Products.ThisProduct.ProductName = txtFirstName.Text;
                Products.ThisProduct.ProductType = txtProductType.Text;
                Products.ThisProduct.ProductDescription = txtProductDescription.Text;
                Products.ThisProduct.ProductPrice = txtProductPrice.Text;
                Products.ThisProduct.ProductManufacturer = ProductManufacturer.Text;
                Products.ThisProduct.ProductsInStock = txtProductsInStock.Text;


                Products.Add();
            }
         else
         {
             lblError.Text = "There were problems";
         }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            Add();
            Response.Redirect("ProductsBackEnd.aspx");
        }
    }
}
    
