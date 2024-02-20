using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.ObjectAdapter
{
    public class ClientScreen
    {
        public virtual void Screen()
        {
            Console.WriteLine("Screen method run at PrintScreen object.");
        }
    }
}

