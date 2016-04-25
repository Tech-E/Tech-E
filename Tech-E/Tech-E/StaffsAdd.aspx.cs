using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tech_E_ClassLibrary;

namespace Tech_E
{
    public partial class StaffsAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //add method
        protected void Button1_Click(object sender, EventArgs e)
        {
            clsStaff staffModel = new clsStaff();
            string ErrorMessage;

            //test  the data on the web form
            ErrorMessage = staffModel.StaffValid(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox6.Text, TextBox8.Text);
            if (ErrorMessage == "")
            {

                staffModel.Staffname = TextBox2.Text;
                staffModel.Age = Convert.ToInt32(TextBox3.Text);
                staffModel.Brief = TextBox4.Text;
                staffModel.Gender = "man";
                staffModel.Mobilesphone = TextBox6.Text;
                staffModel.Workage = Convert.ToInt32(TextBox8.Text);
                staffModel.Position = DropDownList1.Text;
                clsStaffCollection staffcollection = new clsStaffCollection();
                int a = staffcollection.AddStaff(staffModel);
                Response.Redirect("Staffs.aspx");
            }

            else
            {
                Response.Write("<script type='text/javascript'>alert('" + ErrorMessage + "');</script>");
            }
        }
    }
}