using System;

namespace DesignPatterns.Creational.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(2000);
            account.DepositMoney(50);
            account.WithDrawMoney(1250);
            Console.WriteLine("************");
            PersonalAccount personal = new PersonalAccount(3000);
            personal.Name = "Abraham";
            personal.SurName = "Scott";
            personal.DepositMoney(50);
            personal.WithDrawMoney(1250);
            Console.WriteLine($"{personal.Name} {personal.SurName} adlı kullanıcının bakiyesi: {personal.Balance}");
            Console.WriteLine("************");
            PersonalAccount personal2 = (PersonalAccount)personal.Clone();
            personal2.Name = "Micheal";
            personal2.SurName = "Lincoln";
            personal2.Balance = 3000;
            personal2.DepositMoney(50);
            personal2.WithDrawMoney(1250);
            Console.WriteLine($"{personal.Name} {personal.SurName} adlı kullanıcının bakiyesi: {personal.Balance}");
            Console.WriteLine("************");

        }
    }
}
