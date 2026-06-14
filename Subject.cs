namespace ObserverPattern;

internal class Subject : ISubject
{
    private readonly Dictionary<string, ISubscriber> subscribers;

    private string _status = string.Empty;

    public string Status
    {
        get { return _status; }

        set
        {
            _status = value;
            NotifyObservers();
        }
    }

    public Subject()
    {
        subscribers = new Dictionary<string, ISubscriber>();
    }

    private void NotifyObservers()
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Value.UpdateStatus("Status has been changed");
            Console.WriteLine($"Updated {subscribers[subscriber.Key].Name}.");
        }
    }

    public bool Subscribe(ISubscriber observer)
    {
        return subscribers.TryAdd(observer.Name, observer);
    }


    public bool Unsubscribe(ISubscriber observer)
    {
        return subscribers.Remove(observer.Name);
    }
}
