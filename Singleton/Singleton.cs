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