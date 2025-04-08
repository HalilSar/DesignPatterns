namespace DesignPatterns.Behavioral.Observer
{
    public interface Subscriber
    {
        void Update();
        void Cancel();
        // Parameter : NewsPaper news
	void AddSubscribe(NewsPaper news);
    }
}
