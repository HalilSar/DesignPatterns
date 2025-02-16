using System;

namespace DesignPatterns.Behavioral.Chain
{
    class Program
    {
        private static Coin chain;
        static void Main(string[] args)
        {
            chain = new OneCoin().SetNext(new TwoCoin().SetNext(new ThreeCoin().SetNext(new FourCoin())));
            AddCoin(new OneCoin());
            AddCoin(new TwoCoin());
            AddCoin(new ThreeCoin());
            AddCoin(new FourCoin());

        }
        // Parameter : Coin coin
        private static void AddCoin(Coin coin)
        {
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("Otomat "+coin.ToString() + "atıldı");
            chain.Check(coin);
            Console.WriteLine("+-------------------------+");
        }
    }
}
