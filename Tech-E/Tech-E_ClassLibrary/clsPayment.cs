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
    }
}