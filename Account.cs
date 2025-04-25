using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBank;

public class Account
{
    public int Number { get; set; }
    public string? Holder { get; set; }
    public decimal Balance { get; set; } = 0.00m;


    public virtual double Tariffs { get; set; } = 0.000;

    private decimal CalculateRemuneration(double tariffs)
    {
        return Balance * (decimal)Tariffs;
    }


    public decimal Deposit(decimal value)
    {
        Balance += value;
        Balance = Balance + CalculateRemuneration(Tariffs);
        return Balance;
    }


    public virtual decimal Withdraw(decimal value)
    {
        Balance -= value;

        return Balance;
    }

}
