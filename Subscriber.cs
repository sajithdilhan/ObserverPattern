namespace ObserverPattern;

internal class Subscriber : ISubscriber
{
    public string Name { get; private set; } = string.Empty;

    public Subscriber(string name)
    {
        Name = name;
    }

    public void UpdateStatus(string message)
    {
        Console.WriteLine($"{Name} {message}");
    }
}
