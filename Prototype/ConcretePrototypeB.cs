public class ConcretePrototypeB : Prototype
{
    public Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}