using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public class Sun : NewsPaper
    {
        private List<Subscriber> subcscribers = new List<Subscriber>();
        public void AddSubscriber(Subscriber subscriber)
        {
            subcscribers.Add(subscriber);
        }

        public void DeleteSubscriber(Subscriber subscriber)
        {
            subcscribers.Remove(subscriber);
        }

        public List<Subscriber> GetNewsPaper()
        {
            return this.subcscribers;
        }

        public override string ToString()
        {
            return "Sun";
        }
    }
}
