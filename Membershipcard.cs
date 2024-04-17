using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern1
{
    public class Membershipcard : IPayment
    {
        public void Pay(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("you have not purchased anything.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("you are eligible for 10% discount");
                amount = amount - amount / 10;
                Console.WriteLine($"you have to pay the total amount:${amount}");
                Console.ReadLine();
            }
        }
    }
}
