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
        int staffid;
        protected void Page_Load(object sender, EventArgs e)
        {
            staffid = Convert.ToInt32(Session["staffid"]);
            if (staffid==-1)
            {
                Button1.Text = "Add";
            }
            else
            {
                Button1.Text = "Update";
            }
        }

        //add method
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (staffid == -1)
            {
                add();
            }
            else
            {
                update();
            }
        }


        //add method
        private void add()
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

        //update method
        private void update()
        {
            clsStaff clstaffs = new clsStaff();
            clstaffs = clstaffs.Find(staffid);
            TextBox2.Text = clstaffs.Staffname.ToString();
            TextBox3.Text = clstaffs.Age.ToString();
            TextBox4.Text = clstaffs.Brief.ToString();
            TextBox6.Text = clstaffs.Mobilesphone.ToString();
            TextBox8.Text = clstaffs.Workage.ToString();
            DropDownList1.Text = clstaffs.Position.ToString();
        }

    }
}