using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public class Sun : NewsPaper
    {
        private List<Subscriber> subcscribers = new List<Subscriber>();

        // Parameter : Subscriber subscriber
        public void AddSubscriber(Subscriber subscriber)
        {
            subcscribers.Add(subscriber);
        }

        // Parameter : Subscriber subscriber
        public void DeleteSubscriber(Subscriber subscriber)
        {
            subcscribers.Remove(subscriber);
        }

        // Return : List<Subscriber>
        public List<Subscriber> GetNewsPaper()
        {
            return this.subcscribers;
        }

        // return : string
        public override string ToString()
        {
            return "Sun";
        }
    }
}
