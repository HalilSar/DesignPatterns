﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
   public class SiberianTiger:Tiger
    {
        // return string
        public string GetTigerSpecies()
        {
            return "Siberian Tiger";
        }
            
    }
}
