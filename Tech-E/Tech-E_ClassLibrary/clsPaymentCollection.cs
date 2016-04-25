using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_E_ClassLibrary
{
    public class clsPaymentCollection
    {

        //private data member for the list
        List<clsPayment> paymentList = new List<clsPayment>();


        public List<clsPayment> PaymentList
        {
            get
            {
                //return the private data
                return paymentList;
            }
            set
            {
                //set the private data
                paymentList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return paymentList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsPaymentCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblPayment_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to proccess
            while (Index < RecordCount)
            {
                //create a blank customer
                clsPayment APayment = new clsPayment();
                //    //read in the fields from the current record               
                APayment.PaymentNo = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentNo"]);
                APayment.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
                APayment.Amount = Convert.ToDecimal(DB.DataTable.Rows[Index]["Amount"]);
                APayment.Dateadded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //    //add the record to the private data member
                paymentList.Add(APayment);
                //    //point at the next record
                Index++;

            }
        }

        public Tech_E_UnitTestProject.clsProduct ThisPayment{ get; set; }


    }
}
