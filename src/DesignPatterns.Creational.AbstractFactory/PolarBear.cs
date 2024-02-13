using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
   public class PolarBear:Bear
    {
        public string GetBearSpecies()
        {
            return "Polar Bear";
        }
            
    }
}
