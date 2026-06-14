namespace ObserverPattern;

internal interface ISubject
{
    public bool Subscribe(ISubscriber observer);
    public bool Unsubscribe(ISubscriber observer);

}
