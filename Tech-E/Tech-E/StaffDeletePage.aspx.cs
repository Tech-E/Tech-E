using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tech_E_ClassLibrary;

namespace Tech_E
{
    public partial class StaffDeletePage : System.Web.UI.Page
    {
        int staffid;

        protected void Page_Load(object sender, EventArgs e)
        {
            staffid = Convert.ToInt32(Session["staffid"]);
            //create an instane of the collection
            


        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            clsStaffCollection clsstaffcollection = new clsStaffCollection();

            clsstaffcollection.Delete(staffid);
            Response.Redirect("Staffs.aspx");
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staffs.aspx");
        }
    }
}