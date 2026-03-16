public class Program
{
    public static void Main(string[] args)
    {
        IAbstractFactory factory1 = new ConcreteFactory1();
        IProductA productA1 = factory1.CreateProductA();
        IProductB productB1 = factory1.CreateProductB();

        productA1.OperationA();
        productB1.OperationB();

        IAbstractFactory factory2 = new ConcreteFactory2();
        IProductA productA2 = factory2.CreateProductA();
        IProductB productB2 = factory2.CreateProductB();

        productA2.OperationA();
        productB2.OperationB();
    }
}

public interface IAbstractFactory
{
    IProductA CreateProductA();
    IProductB CreateProductB();
}

public interface IProductA
{
    void OperationA();
}

public interface IProductB
{
    void OperationB();
}

public class ProductA1 : IProductA
{
    public void OperationA()
    {
        Console.WriteLine("ProductA1 OperationA");
    }
}

public class ProductA2 : IProductA
{
    public void OperationA()
    {
        Console.WriteLine("ProductA2 OperationA");
    }
}

public class ProductB1 : IProductB
{
    public void OperationB()
    {
        Console.WriteLine("ProductB1 OperationB");
    }
}

public class ProductB2 : IProductB
{
    public void OperationB()
    {
        Console.WriteLine("ProductB2 OperationB");
    }
}



public class ConcreteFactory1 : IAbstractFactory
{
    public IProductA CreateProductA()
    {
        return new ProductA1();
    }

    public IProductB CreateProductB()
    {
        return new ProductB1();
    }
}

public class ConcreteFactory2 : IAbstractFactory
{
    public IProductA CreateProductA()
    {
        return new ProductA2();
    }

    public IProductB CreateProductB()
    {
        return new ProductB2();
    }
}