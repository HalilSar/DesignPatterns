using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class Character
    {
        private string characterValue;
        public Character(string character)
        {
            this.characterValue = character;

        }

        public string CharacterValue { 
            get {
                return this.characterValue;
            } set { value= characterValue; } }
        
    }
}
