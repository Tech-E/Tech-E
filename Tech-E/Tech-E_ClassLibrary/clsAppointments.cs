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

        public string AppointmentLocation { get; set; }

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

        public bool Find(int AppointmentID)
        {
            appointmentID = 21;
            return true;
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

        public DateTime Dateadded { get; set; }

        public bool Active { get; set; }
    }
}
