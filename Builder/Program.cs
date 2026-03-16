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

public class Director
{
    private IBuilder _builder;

    public void SetBuilder(IBuilder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.BuildPartA();
        _builder.BuildPartB();
        _builder.BuildPartC();
    }
}

public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
}

public class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();

    public void BuildPartA()
    {
        _product.Add("PartA");
    }

    public void BuildPartB()
    {
        _product.Add("PartB");
    }

    public void BuildPartC()
    {
        _product.Add("PartC");
    }

    public Product GetResult()
    {
        return _product;
    }
}

public class Product
{
    private List<string> _parts = new List<string>();

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public void Show()
    {
        Console.WriteLine("Product Parts:");
        foreach (var part in _parts)
        {
            Console.WriteLine(part);
        }
    }
}