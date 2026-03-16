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

public interface Prototype
{
    Prototype Clone();
}

public class ConcretePrototypeA : Prototype
{
    public Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}

public class ConcretePrototypeB : Prototype
{
    public Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}