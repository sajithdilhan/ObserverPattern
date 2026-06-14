namespace ObserverPattern;

internal interface ISubscriber
{
    string Name { get; }
    void UpdateStatus(string message);
}
