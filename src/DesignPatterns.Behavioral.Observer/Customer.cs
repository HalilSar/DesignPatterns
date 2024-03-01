using System;

namespace DesignPatterns.Behavioral.Observer
{
    public class Customer : Subscriber
    {
        private NewsPaper newsPaper;
        private string name;
        private string surName;

        public Customer( string name , string surName)
        {
            this.surName = surName;
            this.name = name;
        }
        public void AddSubscribe(NewsPaper news)
        {
           this.newsPaper = news;
            news.AddSubscriber(this);
            Console.WriteLine(name + " " + surName + " " +news);
        }

        public void Cancel()
        {
            newsPaper.DeleteSubscriber(this);
            Console.WriteLine(name + " " + surName + " canceled subscriber");
        }

        public void Update()
        {
            Console.WriteLine(name + " " + surName + " bought newspaper");
        }
    }
}