public class Program
{
    public static void Main(string[] args)
    {
        Director director = new Director();
        ConcreteBuilder builder = new ConcreteBuilder();

        director.SetBuilder(builder);
        director.Construct();

        Product product = builder.GetResult();
        product.Show();
    }
}