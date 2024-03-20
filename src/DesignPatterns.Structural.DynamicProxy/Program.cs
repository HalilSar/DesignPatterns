using System;

namespace DesignPatterns.Structural.DynamicProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = Log<BankAccount>.As<IBankAccount>();
            bankAccount.SetName("John");
            bankAccount.SetSurName("Smith");
            bankAccount.SetAccountStatus(100000000);
            bankAccount.WithDrawMoney(3);
            bankAccount.GetAccountStatus();
        }
    }
}
