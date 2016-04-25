using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tech_E_ClassLibrary;

namespace Tech_E
{
    public partial class CustomerAddBackEnd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void Add()
        {
            clsCustomerCollection Customers = new clsCustomerCollection();

            Boolean OK = Customers.ThisCustomer.Valid (txtFirstName.Text, txtLastName.Text, txtAddressLine1.Text, txtAddressLine2.Text, txtTown.Text, 
                                                        txtPostCode.Text, txtPhoneNo.Text, txtEmailAddress.Text,txtUserName.Text,txtPassword.Text);

         if (OK == true)
            {
                Customers.ThisCustomer.FirstName = txtFirstName.Text;
                Customers.ThisCustomer.LastName = txtLastName.Text;
                Customers.ThisCustomer.AddressLine1 = txtAddressLine1.Text;
                Customers.ThisCustomer.AddressLine2 = txtAddressLine2.Text;
                Customers.ThisCustomer.Town = txtTown.Text;
                Customers.ThisCustomer.PostCode = txtPostCode.Text;
                Customers.ThisCustomer.EmailAddress = txtEmailAddress.Text;
                Customers.ThisCustomer.PhoneNo = txtPhoneNo.Text;
                Customers.ThisCustomer.UserName = txtUserName.Text;
                Customers.ThisCustomer.Password = txtPassword.Text;


                Customers.Add();
            }
         else
         {
             lblError.Text = "There were problems";
         }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            Add();
            Response.Redirect("CustomerBackEnd.aspx");
        }
    }
}