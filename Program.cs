using projectBank;

Console.WriteLine("\nConta Corrente : Numero: 111 Titular: Maria");
Account account = new();
account.Number = 111;
account.Holder = "Maria";
Console.WriteLine("Deposit R$ 1.000,00");
account.Deposit(1000);
Console.WriteLine("Withdraw R$ 100,00");
account.Withdraw(100);
Console.WriteLine($"Balance: {account.Balance.ToString("c")}");

Console.WriteLine("Withdraw R$ 2.000,00");
account.Withdraw(2000);
Console.WriteLine($"Balance: {account.Balance.ToString("c")}");

Console.ReadKey();

Console.WriteLine("\n Savings Account : Numero: 222 Titular: João");
SavingsAccount savingsAccount = new();
savingsAccount.Number = 222;
savingsAccount.Holder = "João";
Console.WriteLine("Deposit R$ 1.000,00");
savingsAccount.Deposit(1000);
Console.WriteLine("Withdraw R$ 100,00");
savingsAccount.Withdraw(100);
Console.WriteLine($"Savings Account: {savingsAccount.Balance.ToString("c")}");
