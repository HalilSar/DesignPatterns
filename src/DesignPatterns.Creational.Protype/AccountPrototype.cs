﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public abstract class AccountPrototype : ICloneable
    {
        public decimal Balance { get; set; }

        public void DepositMoney(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Balance: {Balance}");
        }
        public void WithDrawMoney(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }
        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }
}
