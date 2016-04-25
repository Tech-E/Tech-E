using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tech_E_UnitTestProject;

namespace Tech_E_ClassLibrary
{
    public class clsAppointmentCollection
    {

        //private data member for the list
        List<clsAppointments> appointmentList = new List<clsAppointments>();


        public List<clsAppointments> AppointmentList
        {
            get
            {
                //return the private data
                return appointmentList;
            }
            set
            {
                //set the private data
                appointmentList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return appointmentList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsAppointmentCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAppointment_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to proccess
            while (Index < RecordCount)
            {
                //create a blank appointment
                clsAppointments AnAppointment = new clsAppointments();
                //    //read in the fields from the current record               
                AnAppointment.AppointmentID = Convert.ToInt32(DB.DataTable.Rows[Index]["AppointmentID"]);
                AnAppointment.AppointmentLocation = Convert.ToString(DB.DataTable.Rows[Index]["AppointmentLocation"]);
                AnAppointment.AppointmentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["AppointmentDate"]);
                //    //add the record to the private data member
                appointmentList.Add(AnAppointment);
                //    //point at the next record
                Index++;
            }
        }




        public clsAppointments ThisAppointment { get; set; }
    }
}