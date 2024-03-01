using System;

namespace DesignPatterns.Behavioral.Observer
{
    public interface NewsPaper
    {
        void AddSubscriber(Subscriber subscriber);
        void DeleteSubscriber(Subscriber subscriber);
    }
}
