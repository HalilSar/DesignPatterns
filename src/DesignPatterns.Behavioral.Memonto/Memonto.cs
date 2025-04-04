﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memonto
{
   public class Memonto
    {
        private object[] elements;


        public Memonto( object[] elements ) 
        {
            this.elements = elements;
        }
        
	// return object[]
        public object[] GetElements() => elements;
        // parameter object[] elements
        public void SetElements(object[] elements) => this.elements = elements;


    }
}
