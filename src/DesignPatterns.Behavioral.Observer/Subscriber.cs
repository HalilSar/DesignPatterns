namespace DesignPatterns.Behavioral.Observer
{
    public interface Subscriber
    {
        void Update();
        void Cancel();
        void AddSubscribe(NewsPaper news);
    }
}