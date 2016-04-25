using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tech_E_ClassLibrary;

namespace Tech_E
{
    public partial class CustomerBackEnd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                DisplayCustomers();
            }
        }

        void DisplayCustomers()
        {
            clsCustomerCollection Customers = new clsCustomerCollection();

            lstCustomer.DataSource = Customers.CustomerList;

            lstCustomer.DataValueField = "AddressNo";

            lstCustomer.DataTextField = "FirstName";

            lstCustomer.DataBind();

        }
    }
}