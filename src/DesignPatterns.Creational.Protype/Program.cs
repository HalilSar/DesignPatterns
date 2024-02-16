using System;

namespace DesignPatterns.Creational.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(2000);
            Console.WriteLine("************");
            PersonalAccount personal = (PersonalAccount)account.Clone();
            personal.Name = "Abraham";
            personal.SurName = "Scott";
            personal.Balance = 3000;
            personal.DepositMoney(50);
            personal.WithDrawMoney(1250);
            Console.WriteLine($"{personal.Name} {personal.SurName} adlı kullanıcının bakiyesi: {personal.Balance}");
        }
    }
}
