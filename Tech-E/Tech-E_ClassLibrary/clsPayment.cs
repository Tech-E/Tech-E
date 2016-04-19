using System;

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
                paymentMethod= value;

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

        public bool Find(int PaymentNo)
        {
            //set the private data member to test data value
            paymentNo = 21;
            amount = 200;
            paymentMethod = "paypal";
            dateAdded = Convert.ToDateTime("19/04/2016");
            active = true;
            //always return true
            return true;
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
    }
}


        