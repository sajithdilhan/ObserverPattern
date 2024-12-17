

internal class Program
{
   private static void Main(string[] args)
   {
      Subject subject = new Subject();
      IObserver observer1 = new Observer("Observer 1");
      IObserver observer2 = new Observer("Observer 2");
      IObserver observer3 = new Observer("Observer 3");
      
      subject.Subscribe(observer1);
      subject.Subscribe(observer2);
      subject.Subscribe(observer3);
      
      subject.Status = "";
   }
}

internal interface IObserver
{
    void Update();
}

internal interface ISubject
{
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
}

internal class Observer : IObserver
{
    private readonly string name;

    public Observer(string name)
    {
        this.name = name;
    }
    public void Update()
    {
        Console.WriteLine($"An update is received to: {this.name}");
    }
}

internal class Subject : ISubject
{
    private List<IObserver> observers;

    private string status;

    public string Status { 
        get => this.status;
        set
        {
            this.status = value;
            this.Notify();
        }
    }

    public Subject()
    {
        this.observers = new List<IObserver>();
    }
    
    public void Subscribe(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        observers.Remove(observer);
    }

    private void Notify()
    {
        observers.ForEach(x=>x.Update());
    }
}