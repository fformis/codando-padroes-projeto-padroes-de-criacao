public class Program
{
    public static void Main(string[] args)
    {
        Creator creator = new ConcreteCreator();
        IProduct product = creator.FactoryMethod();
        product.Operation();
    }
}

public interface IProduct
{
    void Operation();
}

public abstract class Creator
{
    public abstract IProduct FactoryMethod();
}

public class ConcreteProduct : IProduct
{
    public void Operation()
    {
        Console.WriteLine("ConcreteProduct Operation");
    }
}

public class ConcreteCreator : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct();
    }
}