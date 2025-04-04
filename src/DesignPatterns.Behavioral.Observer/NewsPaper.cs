using System.Collections.Generic;
namespace DesignPatterns.Behavioral.Observer
{
    public interface NewsPaper
    {
	//  Parameter Subscriber subscriber    
        void AddSubscriber(Subscriber subscriber);
        // Parameter Subscriber subscriber
	void DeleteSubscriber(Subscriber subscriber);
        // Return List<Subscriber>
        List<Subscriber> GetNewsPaper();
    }
}
