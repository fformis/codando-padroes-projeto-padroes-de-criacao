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