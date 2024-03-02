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

        public Coin GetNext() => next;
        public void Check(Coin money)
        {
            Console.WriteLine("" + this + "");
            if(money.value != this.value)
            {
                Console.WriteLine("" + this + "");
                if (GetNext() != null) GetNext().Check(money);

                else
                {
                    Console.WriteLine("Zincirin sonundayız Coin " + money.ToString() +" " + "bu otomat için uygun değil");
                }
            }
            else
            {
                coins.Add(money);
                Console.WriteLine(this.ToString() +" Accepted by otomat " );

            }
        }
    }
}
