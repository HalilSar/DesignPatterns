using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
   public class BengalTiger:Tiger
    {
        // return string
        public string GetTigerSpecies()
        {
            return "Bengal Tiger";
        }
            
    }
}
