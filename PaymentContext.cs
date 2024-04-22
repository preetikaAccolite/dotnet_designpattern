using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern1
{
    public class PaymentContext
    {
        //private double amount;
        private IPayment payment;
        public PaymentContext(IPayment payment)
        {
            this.payment = payment;
        }
        public void setIPaymnet(IPayment payment)
        {
            this.payment = payment;
        }
        public void performpayment(Double amount)
        {
            payment.Pay(amount);
        }

    }
}
