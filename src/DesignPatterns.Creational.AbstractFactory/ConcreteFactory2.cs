﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteFactory2: AbstractFactory
    {
        // return Bear
        public Bear GetBear()
        {
            return   new PolarBear();

        }
        //return Tiger
        public Tiger GetTiger()
        {
            return new SiberianTiger();

          
        }
    }
}
