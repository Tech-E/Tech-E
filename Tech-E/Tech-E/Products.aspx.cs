using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tech_E_ClassLibrary;

namespace Tech_E
{
    public partial class Products : System.Web.UI.Page
    {
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayProducts();

            }
        }

          public  void DisplayProducts()
          {

              /*//create an instance of the county collection
                clsProductCollection Products = new clsProductCollection();
    //set the data source to the list of products in the collection
    lstProducts.DataSource = Products.ProductList;
    //set the name of the primary key
    lstProducts.DataValueField = "ProductNo";
    //set the data field to display
    lstProducts.DataTextField = "ProductType";
    //biund the data to the list
    lstProducts.DataBind();*/
          }
                 

          protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
          {

          }
    }

 
}