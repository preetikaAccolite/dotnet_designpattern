using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern1
{
    public class PaymentFactory
    {
        public static IPayment create(Payment_cards card)
        {
            switch(card)
            {
                case Payment_cards.Membershipcard:
                    return new Membershipcard();
                case Payment_cards.Employeecard:
                    return new Employeecard();
                case Payment_cards.Nocard:
                    return new Nocard();
                default:
                    throw new NotSupportedException(
                        "this payment method is not supported");

            }
        }
    }
}
