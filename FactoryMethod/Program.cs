public class Program
{
    public static void Main(string[] args)
    {
        Creator creator = new ConcreteCreator();
        IProduct product = creator.FactoryMethod();
        product.Operation();
    }
}