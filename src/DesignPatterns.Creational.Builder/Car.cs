using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
   public  class Car
    {
        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}
