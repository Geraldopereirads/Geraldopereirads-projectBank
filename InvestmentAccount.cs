using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBank
{
    internal class InvestmentAccount : Account
    {
        public override double Tariffs { get; set; } = 0.009;
        public double Tax { get; set; } = 0.001;



        private decimal CalculaImposto(double imposto){
            return Balance * (decimal)Tax;
        }
   


        public override decimal Withdraw(decimal value)
        {
            if (Balance >= value)
            {
                Balance = Balance - value - CalculaImposto(Tax);
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
