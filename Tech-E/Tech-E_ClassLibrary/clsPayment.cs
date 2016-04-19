using System;

namespace Tech_E_ClassLibrary
{
    public class clsPayment
    {
      

        public string PaymentMethod { get; set; }

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

        public object Dateadded { get; set; }

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

        public object Amount { get; set; }

        public bool Find(int PaymentNo)
        {
            //set the private data member to test data value
            PaymentNo = 21;
            //always return true
            return true;
        }

        public bool Active { get; set; }
    }
}