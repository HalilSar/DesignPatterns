using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public interface AbstractFactory
    {
        // return Bear
        Bear GetBear();
        // return Tiger
        Tiger GetTiger();
    }
}
