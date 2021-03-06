﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_E_ClassLibrary
{
    public class clsStaff
    {

        //private datta member for staffid
        private int staffid;
        //private datta member for staffname
        private string staffname;
        //private datta member for age
        private int age;
        //private datta member for brief
        private string brief;
        //private datta member for gender
        private string gender;
        //private datta member for mobilesphone
        private string mobilesphone;
        //private datta member for workage
        private int workage;
        //private datta member for position
        private string position;

        //public property for staffid
        public int Staffid
        {
            get
            {
                //return the private data
                return staffid;
            }
            set
            {
                //set the private data
                staffid = value;
            }
        }


        //public property for staffname
        public string Staffname
        {
            get
            {
                //return the private data
                return staffname;
            }
            set
            {
                //set the private data
                staffname = value;
            }
        }

        //public property for age
        public int Age
        {
            get
            {
                //return the private data
                return age;
            }
            set
            {
                //set the private data
                age = value;
            }
        }


        //public property for brief
        public string Brief
        {
            get
            {
                //return the private data
                return brief;
            }
            set
            {
                //set the private data
                brief = value;
            }
        }


        //public property for gender
        public string Gender
        {
            get
            {
                //return the private data
                return gender;
            }
            set
            {
                //set the private data
                gender = value;
            }
        }

        //public property for mobilesphone
        public string Mobilesphone
        {
            get
            {
                //return the private data
                return mobilesphone;
            }
            set
            {
                //set the private data
                mobilesphone = value;
            }
        }


        //public property for workage
        public int Workage
        {
            get
            {
                //return the private data
                return workage;
            }
            set
            {
                //set the private data
                workage = value;
            }
        }

        //public property for position
        public string Position
        {
            get
            {
                //return the private data
                return position;
            }
            set
            {
                //set the private data
                position = value;
            }
        }



        public bool Valid(string StaffNameValid, string BriefValid, string GenderValid, string MobilesphoneValid, string PositionValid)
        {
            //boolen flag to indicate that all is ok
            Boolean OK = true;
            //if the name of the paymentmethod is blank
            if (StaffNameValid == "")
            {
                //flag an error
                OK = false;
            }
            // if the name of the paymentmethod is more than 10 characters
            if (StaffNameValid.Length > 10)
            {
                //flag an error
                OK = false;
            }

            //is the brief blank
            if (BriefValid.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the brief is too long
            if (BriefValid.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the gender blank
            if (GenderValid.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the gender is too long
            if (GenderValid.Length > 7)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the mobilesphoneValid blank
            if (MobilesphoneValid.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the mobilesphoneValid is too long
            if (MobilesphoneValid.Length > 11)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the positionValid blank
            if (PositionValid.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the positionValid is too long
            if (PositionValid.Length > 10)
            {
                //set the flag OK to false
                OK = false;
            }
            return OK;
        }

        public bool Valid(string StaffNameValid, string BriefValid, string GenderValid, string MobilesphoneValid, string PositionValid, int workage)
        {
            //boolen flag to indicate that all is ok
            Boolean OK = true;
            //if the name of the paymentmethod is blank
            if (StaffNameValid == "")
            {
                //flag an error
                OK = false;
            }
            // if the name of the paymentmethod is more than 10 characters
            if (StaffNameValid.Length > 10)
            {
                //flag an error
                OK = false;
            }

            //is the brief blank
            if (BriefValid.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the brief is too long
            if (BriefValid.Length > 50)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the gender blank
            if (GenderValid.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the gender is too long
            if (GenderValid.Length > 7)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the mobilesphoneValid blank
            if (MobilesphoneValid.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the mobilesphoneValid is too long
            if (MobilesphoneValid.Length > 11)
            {
                //set the flag OK to false
                OK = false;
            }

            //is the positionValid blank
            if (PositionValid.Length == 0)
            {
                //set the flag OK to false
                OK = false;
            }
            //if the positionValid is too long
            if (PositionValid.Length > 10)
            {
                //set the flag OK to false
                OK = false;
            }
            return OK;
        }

        public string StaffValid(string staffname, string age, string brief, string mobilesphone, string workage)
        {
            string ErrorMessageg;
            ErrorMessageg = "";
            int temp;


            if (staffname.Length < 1 | staffname.Length > 20)
            {
                //record an error
                ErrorMessageg = ErrorMessageg + "The Staff Name Must be Between 1 and 20 characters.\\n";
            }

            //wether is number
            try
            {
                temp = Convert.ToInt32(age);
            }
            catch//if it failed report an error
            {
                //set the error messsage
                ErrorMessageg = ErrorMessageg + "age No be a number. \\n";
            }


            //check brief
            if (brief.Length < 10)
            {
                //set the error messsage
                ErrorMessageg = ErrorMessageg + "brief must be less than 10 characters.\\n ";
            }

            //check mobilesphone
            if (mobilesphone.Length == 0)
            {
                //set the error messsage
                ErrorMessageg = ErrorMessageg + "mobilesphone cannot is null. \\n";
            }

            //wether is number about workage
            try
            {
                temp = Convert.ToInt32(workage);
            }
            catch//if it failed report an error
            {
                //set the error messsage
                ErrorMessageg = ErrorMessageg + "workage No be a number.\\n ";
            }


            return ErrorMessageg;
        }

        public clsStaff Find(Int32 Staffid)
        {

            //initialise the DBConnection
            clsDataConnection dBConnection = new clsDataConnection();
            //add the Product No parameter
            dBConnection.AddParameter("@Staffid", Staffid);
            //execute the query
            dBConnection.Execute("sproc_tblStaff_FilterByStaffid");
            //if the record was found
            clsStaff clstaffs = new clsStaff();
            if (dBConnection.Count == 1)
            {
                //get the Product No
                clstaffs.Staffid = Convert.ToInt32(dBConnection.DataTable.Rows[0]["Staffid"]);
                clstaffs.Staffname = Convert.ToString(dBConnection.DataTable.Rows[0]["Staffname"]);
                clstaffs.Age = Convert.ToInt32(dBConnection.DataTable.Rows[0]["Age"]);
                clstaffs.Brief = Convert.ToString(dBConnection.DataTable.Rows[0]["Brief"]);
                clstaffs.Gender = Convert.ToString(dBConnection.DataTable.Rows[0]["Gender"]);
                clstaffs.Mobilesphone = Convert.ToString(dBConnection.DataTable.Rows[0]["Mobilesphone"]);
                clstaffs.Workage = Convert.ToInt32(dBConnection.DataTable.Rows[0]["Workage"]);
                clstaffs.Position = Convert.ToString(dBConnection.DataTable.Rows[0]["Position"]);
            }
            //return success
            return clstaffs;

        }

    }

}
