public class ConcretePrototypeA : Prototype
{
    public Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}
