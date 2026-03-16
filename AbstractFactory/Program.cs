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