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



    public decimal Deposit(decimal value)
    {
        Balance += value;
        return Balance;
    }


    public decimal withdraw(decimal value)
    {
        Balance -= value;
        return Balance;
    }

}
