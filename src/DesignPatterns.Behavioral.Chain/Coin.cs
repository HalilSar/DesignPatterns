using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Chain
{
    public abstract  class Coin
    {
        private List<Coin> coins = new List<Coin>();
        public int value;
        private Coin next;
        // return coin
        public Coin GetNext() => next;

	// Return Coin
	// Parameter Coin next
        public Coin SetNext(Coin next)
        {
            this.next = next;
            return this;
        }

	// parameter Coin money
        public void Check(Coin money)
        {
            Console.WriteLine("The next object can only" + this);
            if(money.value != this.value)
            {
                Console.WriteLine("Okay, no we're moving to next object in the chain");
                if (GetNext() != null) GetNext().Check(money);

                else
                {
                    Console.WriteLine("We are at end of the chain. " + money.ToString() +" is not suitable for this vending machine.");
                }
            }
            else
            {
                coins.Add(money);
                Console.WriteLine(this.ToString() +" Accepted by Vending Machine. " );

            }
        }
    }
}
