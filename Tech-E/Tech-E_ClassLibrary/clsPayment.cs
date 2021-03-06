﻿using System;

namespace Tech_E_ClassLibrary
{
    public class clsPayment
    {


        private string paymentMethod;
        public string PaymentMethod {
            get
            {
                //return the private data
                return paymentMethod;
            }
            set
            {
                //set the value of the private data member
                paymentMethod = value;

            }

        }

        public bool Valid(string SomePaymentMethod)
        {
            //boolen flag to indicate that all is ok
            Boolean OK = true;
            //if the name of the paymentmethod is blank
            if (SomePaymentMethod == "")
            {
                //flag an error
                OK = false;
            }
            // if the name of the paymentmethod is more than 6 characters
            if (SomePaymentMethod.Length > 6)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }
        private DateTime dateAdded;
        public DateTime Dateadded {
            get
            {
                //return the private data
                return dateAdded;
            }
            set
            {
                //set the value of the private data member
                dateAdded = value;

            }
        }

        private Int32 paymentNo;
        public int PaymentNo
        {
            get
            {
                //return the private data
                return paymentNo;
            }
            set
            {
                //set the value of the private data member
                paymentNo = value;

            }


        }
        private decimal amount;
        public decimal Amount {
            get
            {
                //return the private data
                return amount;
            }
            set
            {
                //set the value of the private data member
                amount = value;

            }
        }
        public bool FindPayment(Int32 PaymentNo)
        {
            throw new NotImplementedException();
        }
        public bool Find(Int32 PaymentNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramter for the payemntno to search for
            DB.AddParameter("@PaymentNo", PaymentNo);
            //excute the stored procedure
            DB.Execute("sproc_tblPayment_FilterByPaymentNo");
            //if one record is found( there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data members
                paymentNo = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentNo"]);
                amount = Convert.ToDecimal(DB.DataTable.Rows[0]["Amount"]);
                paymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                dateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //return that everthing worked Ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
        private Boolean active;
        public bool Active {
            get
            {
                //return the private data
                return active;
            }
            set
            {
                //set the value of the private data member
                active = value;

            }

        }

        public bool Valid(string PaymentNo, string Amount, string PaymentMethod, string DateAdded)
        {
            //boolean varible
            Boolean Ok = true;
            //temporary varible to store date values
            DateTime DateTemp;
            //if the paymentNo is blank
            if (PaymentNo.Length == 0)
            {
                //set the flag ok to false
                Ok = false;
            }
            //if payment no is greater than 6 characters
            if (PaymentNo.Length > 6)
            {
                //set the flag ok to flase
                Ok = false;
            }

            //try the date validation assumng the data is a valid date
            try {
                //copy the dateadded value to the datetemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                //check to see if the date is less than todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //set the flag ok to false
                    Ok = false;
                }
            }
            //the data was not a date so flag an error
            catch
            {
                //set the flag ok to false
                Ok = false;
            }

            return Ok;

        }
    }
}


        