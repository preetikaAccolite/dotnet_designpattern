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
                    PaymentContext pay = new PaymentContext(new Membershipcard());
                    pay.performpayment(amount);
                    break;
                case 2:
                    PaymentContext pay1 = new PaymentContext(new Employeecard());
                    pay1.performpayment(amount);
                    break;
                case 3:
                    PaymentContext pay2 = new PaymentContext(new Nocard());
                    pay2.performpayment(amount);
                    break;
                default:
                    Console.WriteLine("this payment method does not exist");
                    Console.ReadLine();
                    break;
  }
        }
    }
}
