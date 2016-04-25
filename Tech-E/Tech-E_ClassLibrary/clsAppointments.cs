using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_E_ClassLibrary
{
    public class clsAppointments
        
    {
        
        public bool Valid(int AppointmentID)
        {
            if (AppointmentID >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ValidString(string AppointmentLocation)
        {
            if (AppointmentLocation != null &&
                AppointmentLocation.Length >= 1 &&
                AppointmentLocation.Length <= 40)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Find(Int32 AppointmentID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@AppointmentID", AppointmentID);
            //execute the stored procedure
            DB.Execute("sproc_tblAppointment_FilterByAppointmentID");
            //if one record is found (there should either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                appointmentID = Convert.ToInt32(DB.DataTable.Rows[0]["AppointmentID"]);
                appointmentLocation = Convert.ToString(DB.DataTable.Rows[0]["AppointmentLocation"]);
                appointmentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["AppointmentDate"]);             
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a probelm
                return false;
            }
        }

        private Int32 appointmentID;
        public int AppointmentID
        {
            get
            {
                return appointmentID;

            }
            set
            {
                appointmentID = value;
            }
        }

        private DateTime appointmentDate;
        public DateTime AppointmentDate { get; set; }

        private DateTime appointmentTime;
        public DateTime AppointmentTime { get; set; }

        public bool Active { get; set; }

        private string appointmentLocation;
        public string AppointmentLocation
        {
            get
            {
                return appointmentLocation;
            }
            set
            {
                appointmentLocation = value;
            }
        }

        

        
        public bool Valid(string AppointmentLocation, string AppointmentDate)
        {
            //create a Boolean variable to flag the error
            Boolean OK = true;
            //temporary varible to store date values
            DateTime DateTemp;

            if (AppointmentLocation.Length == 0)
            {
                OK = false;
            }

            if (AppointmentLocation.Length > 50)
            {
                OK = false;
            }
            //try the date validation assumng the data is a valid date
            try
            {
                //copy the dateadded value to the datetemp variable
                DateTemp = Convert.ToDateTime(AppointmentDate);
                //check to see if the date is less than todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag ok to false
                    OK = false;
                }
            }
            //the data was not a date so flag an error
            catch
            {
                //set the flag ok to false
                OK = false;
            }
            
            //return the value Ok
            return OK;
        }
    }
}
