using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public abstract class Account : AccountPrototype
    {
        public Account(decimal balance)
        {
            this.Balance = balance;
        }
    }
}
