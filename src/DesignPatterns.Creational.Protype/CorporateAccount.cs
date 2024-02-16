using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public  class CorporateAccount : AccountPrototype
    {
        public string CorporateName;
        public string TIN;
        public CorporateAccount(decimal balance)
        {
            this.Balance = balance;
        }
    }
}
