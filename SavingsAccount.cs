using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBank
{
    public class SavingsAccount : Account
    {
        public double tariffs { get; set; } = 0.005;


        public override decimal withdraw(decimal value)
        {
            if(value >= value)
            {
                value -= value;
                return value;
            }

            else
            {
                Console.WriteLine("Insifficient balance...")
                    return value;
            }

        }


    }
}
