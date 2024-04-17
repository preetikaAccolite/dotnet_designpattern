using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the amount:");
            Double amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select any of the following card: 1.Membership card, 2.Employee card , 3.No card");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option) {
                case 1:
                    IPayment payment = PaymentFactory.create(Payment_cards.Membershipcard);
                    payment.Pay(amount);
                    break;
                case 2:
                    IPayment payment1 = PaymentFactory.create(Payment_cards.Employeecard);
                    payment1.Pay(amount);
                    break;
                case 3:
                    IPayment payment2 = PaymentFactory.create(Payment_cards.Nocard);
                    payment2.Pay(amount);
                    break;
                default:
                    Console.WriteLine("this payment method does not exist");
                    Console.ReadLine();
                    break;
  }
        }
    }
}
