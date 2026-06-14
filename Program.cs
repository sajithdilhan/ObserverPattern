

using ObserverPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Subject subject = new Subject();
        ISubscriber subscriber1 = new Subscriber("Subscriber 1");
        ISubscriber subscriber2 = new Subscriber("Subscriber 2");
        ISubscriber subscriber3 = new Subscriber("Subscriber 3");

        subject.Subscribe(subscriber1);
        subject.Subscribe(subscriber2);
        subject.Subscribe(subscriber3);

        subject.Status = "Paid";
    }
}

