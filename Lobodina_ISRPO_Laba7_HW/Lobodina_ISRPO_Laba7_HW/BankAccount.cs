//using System;

//class BankAccount
//{
//    public string AccountNumber;
//    private decimal balance;
//    public BankAccount(string accountNumber, decimal initialBalance = 0)
//    {
//        this.AccountNumber = accountNumber;
//        this.balance = initialBalance;
//    }
//    public void Deposit(decimal amount)
//    {
//        if (amount > 0)
//        {
//            this.balance += amount;
//            Console.WriteLine($"Пополнение: {amount} руб.");
//        }
//        else
//        {
//            Console.WriteLine("Сумма пополнения должна быть положительной");
//        }
//    }
//    public void Withdraw(decimal amount)
//    {
//        if (amount > 0 && amount <= this.balance)
//        {
//            this.balance -= amount;
//            Console.WriteLine($"Снятие: {amount} руб.");
//        }
//        else if (amount > this.balance)
//        {
//            Console.WriteLine("Недостаточно средств на счете");
//        }
//        else
//        {
//            Console.WriteLine("Сумма снятия должна быть положительной");
//        }
//    }
//    public void PrintBalance()
//    {
//        Console.WriteLine($"Текущий баланс: {this.balance} руб.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount account = new BankAccount("1234567890");

//        account.Deposit(1000);
//        account.Withdraw(500);
//        account.PrintBalance();
//    }
//}
