using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public  class PersonalAccount : AccountPrototype
    {
        public string Name;
        public string SurName { get; set; }
        public PersonalAccount(decimal balance,)
        {
            this.Balance = balance;
        }
    }
}
