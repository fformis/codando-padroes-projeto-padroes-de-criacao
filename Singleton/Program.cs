public class Program
{
    public static void Main(string[] args)
    {
        Singleton singleton1 = Singleton.Instance;
        Console.WriteLine(singleton1.GetSingletonData());

        Singleton singleton2 = Singleton.Instance;
        Console.WriteLine(singleton2.GetSingletonData());

        Console.WriteLine("Are both instances the same? " + (singleton1 == singleton2));
    }
}

public class Singleton
{
    private static Singleton? _instance;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
                _instance._data = Guid.NewGuid().ToString();
            }
            return _instance;
        }
    }

    private string? _data;

    public string GetSingletonData()
    {
        return $"Singleton ID: {_data}";
    }
}