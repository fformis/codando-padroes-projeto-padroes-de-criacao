public class Program
{
    public static void Main(string[] args)
    {
        Prototype prototypeA = new ConcretePrototypeA();
        Prototype cloneA = prototypeA.Clone();

        Prototype prototypeB = new ConcretePrototypeB();
        Prototype cloneB = prototypeB.Clone();
        Console.WriteLine("Cloned Prototype A: " + cloneA.GetType().Name);
        Console.WriteLine("Cloned Prototype B: " + cloneB.GetType().Name);

    }
}