using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public class Guardian : NewsPaper
    {
        private List<Subscriber> subscribers = new List<Subscriber>();
        // Parameter Subscriber subscriber
	public void AddSubscriber(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }
        // Parameter Subscriber subscriber
        public void DeleteSubscriber(Subscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }
        // Return List<Subscriber>
        public List<Subscriber> GetNewsPaper()
        {
            return this.subscribers;
        }
        // Return string
        public override string ToString()
        {
            return "Guardian";
        }
    }
}
