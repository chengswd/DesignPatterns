namespace DesignPatterns.Factory;

public class AppleFactory: IFactory
{
    public Fruit CreateFruit()
    {
        return new Apple();
    }
}