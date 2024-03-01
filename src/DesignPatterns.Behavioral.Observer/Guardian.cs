using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public class Guardian : NewsPaper
    {
        private List<Subscriber> subscribers = new List<Subscriber>();
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
            return this.subscribers;
        }

        public override string ToString()
        {
            return "Guardian";
        }
    }
}
