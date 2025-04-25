using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBank
{
    public class SavingsAccount : Account
    {
        public override double Tariffs { get; set; } = 0.005;


        public decimal Withdraw(decimal value)
        {
            if(Balance >= value)
            {
                Balance -= value;
                return Balance;
            }

            else
            {
                Console.WriteLine("Insifficient balance...");
                    return Balance;
            }

        }


    }
}
