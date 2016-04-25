using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_E_ClassLibrary
{
    public class clsStaffCollection
    {
        clsDataConnection dBConnection;
        clsStaff StaffModel = new clsStaff();
        public List<clsStaff> staffList = new List<clsStaff>();

        clsStaff thisstaff = new clsStaff();
        //public property for ThisStaff
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return thisstaff;
            }
            set
            {
                //set the private data
                thisstaff = value;
            }
        }

       


        public Int32 AddStaff()
        {
            clsDataConnection NewDBProducts = new clsDataConnection();
            //add the parameters
            // NewDBProduct.AddParameter("@ProductNo", ThisProduct.ProductNo);
            dBConnection.AddParameter("@Name", ThisStaff.Staffname);
            dBConnection.AddParameter("@Age", ThisStaff.Age);
            dBConnection.AddParameter("@Brief", ThisStaff.Brief);
            dBConnection.AddParameter("@Gender", ThisStaff.Gender);
            dBConnection.AddParameter("@Mobilesphone", ThisStaff.Mobilesphone);
            dBConnection.AddParameter("@workage", ThisStaff.Workage);
            dBConnection.AddParameter("@positiob", ThisStaff.Position);

            return dBConnection.Execute("sproc_Staff_Insert");
        }


        public void Delete()
        {
            //deletes the recoed point ti by this staff
            //connect to the database
            clsDataConnection NewDBProducts = new clsDataConnection();
            //set the paraters for the stored procedure
            NewDBProducts.AddParameter("@Staffid", ThisStaff.Staffid);
            //exectue the store procedure
            NewDBProducts.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //update the recoed point ti by this staff
            //connect to the database
            clsDataConnection NewDBProducts = new clsDataConnection();
            //set the paraters for the stored procedure
            dBConnection.AddParameter("@Name", ThisStaff.Staffname);
            dBConnection.AddParameter("@Age", ThisStaff.Age);
            dBConnection.AddParameter("@Brief", ThisStaff.Brief);
            dBConnection.AddParameter("@Gender", ThisStaff.Gender);
            dBConnection.AddParameter("@Mobilesphone", ThisStaff.Mobilesphone);
            dBConnection.AddParameter("@workage", ThisStaff.Workage);
            dBConnection.AddParameter("@positiob", ThisStaff.Position);

            //exectue the store procedure
            NewDBProducts.Execute("sproc_tblStaff_Update");
        }


        public List<clsStaff> clsStaffListCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            List<clsStaff> StaffList = new List<clsStaff>();
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to proccess
            while (Index < RecordCount)
            {
                clsStaff StaffOne = new clsStaff();
                StaffOne.Staffid = Convert.ToInt32(DB.DataTable.Rows[Index]["staffid"]);
                StaffOne.Staffname = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                StaffOne.Age = Convert.ToInt32(DB.DataTable.Rows[Index]["age"]);
                StaffOne.Brief = Convert.ToString(DB.DataTable.Rows[Index]["brief"]);
                StaffOne.Gender = Convert.ToString(DB.DataTable.Rows[Index]["gender"]);
                StaffOne.Mobilesphone = Convert.ToString(DB.DataTable.Rows[Index]["mobilesphone"]); 
                StaffOne.Workage = Convert.ToInt32(DB.DataTable.Rows[Index]["workage"]); 
                StaffOne.Position = Convert.ToString(DB.DataTable.Rows[Index]["position"]);
                StaffList.Add(StaffOne);
            //    //point at the next record
                Index++;

            }
            return StaffList;
        }





    }
}
