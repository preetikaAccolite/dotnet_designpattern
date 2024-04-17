using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern1
{
    public class Employeecard : IPayment
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


                Console.WriteLine("you are eligible for 20% discount");
                amount = amount - amount / 5;
                Console.WriteLine($"you have to pay the total amount:${amount}");
                Console.ReadLine();
            }
        }
    }
    
    
}
