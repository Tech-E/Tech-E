using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tech_E_ClassLibrary;

namespace Tech_E
{
    public partial class Staffs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                //update the list box
                Disaplay();
            }
        }
        private void Disaplay()
        {
            //create an instane of the collection
            clsStaffCollection clsstaffcollection = new clsStaffCollection();
            //set data souce
            ListBox1.DataSource = clsstaffcollection.clsStaffListCollection();
            //set tje name of the primary key
            ListBox1.DataValueField = "staffid";
            ListBox1.DataTextField = "Staffname";
            //bind the data to the list
            ListBox1.DataBind();
        }

        //add method
        protected void btn3_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffsAdd.aspx");
        }

        //delete
        protected void btn5_Click(object sender, EventArgs e)
        {
            int staffid;
            if (ListBox1.SelectedIndex!=-1)
            {
                //get the primary key 
                staffid = Convert.ToInt32(ListBox1.SelectedValue);
                Session["staffid"] = staffid;
                //redirext to the delete page


            }
            else
            {
                //displayan error
                Response.Write("<script type='text/javascript'>alert('Please select a recordtp delete from the list');</script>");
            }
        }

       

    }
}