using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public class Sun : NewsPaper
    {
        private List<Subscriber> subcscribers = new List<Subscriber>();
        public void AddSubscriber(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void DeleteSubscriber(Subscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public List<Subscriber> GetNewsPaper()
        {
            return this.subcscribers;
        }
    }
}
